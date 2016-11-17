using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_Interfaces_Project
{
    public partial class frmVRInterfaces : Form, IFrmGame
    {
        private SerialPort port;
        private Capture mCapture;
        private ushort countWrittenToDisplay = 0;
        private Game mGame;
        private RotatedRect[,] rects;
        private Triangle2DF[,] triangs;
        private CircleF[,] circs;
        private bool mIsRunning = false;
        private const int PCWEBCAM = 0, ANDROIDWEBCAM = 1;

        #region Properties
        public Panel GameView
        {
            get { return pnlGameView; }
        }
        #endregion

        #region Initialization
        public frmVRInterfaces()
        {
            InitializeComponent();
            Init("COM4", "9600", Color.Blue);
        }

        /// <summary>
        /// Initializes the form for the user.
        /// </summary>
        /// <param name="port">The portname which should be automatically selected.</param>
        /// <param name="baudrate">The baudrate which should be used for commication with the arduino.</param>
        private void Init(string port, string baudrate, Color color)
        {
            var ports = SerialPort.GetPortNames();

            // Add all available ports to the portscombobox
            foreach(string p in ports)
            {
                cbPorts.Items.Add(p);
            }

            // Add all fonts to the fontscombobox
            cbFonts.DataSource = Enum.GetValues(typeof(FontFace));

            GetColorNames();

            // Set standard port in ports combobox
            cbPorts.SelectedIndex = cbPorts.Items.IndexOf(port);

            // Set standard Baudrate in Baudrate combobox
            cbBaudrates.SelectedIndex = cbBaudrates.Items.IndexOf(baudrate);

            // Set standard color in color combobox
            cbColors.SelectedIndex = cbColors.Items.IndexOf(color.Name);

            bttnStop.Enabled = false;
        }

        /// <summary>
        /// Get all color names and puts them in the colors combobox.
        /// </summary>
        private void GetColorNames()
        {
            PropertyInfo[] props = typeof(Color).GetProperties();
            string fullName = "System.Drawing.Color";

            // Add all colors to the colorscombobox
            foreach (PropertyInfo prop in props)
            {
                if (prop.PropertyType.FullName == fullName)
                {
                    cbColors.Items.Add(prop.Name);
                }
            }
        }
        #endregion

        #region Port and Camera Acces
        /// <summary>
        /// Get access to the webcam so it get's turned on.
        /// </summary>
        private void AccessCamera()
        {
            try
            {
                if (rbPCWebcam.Checked)
                {
                    mCapture = new Capture(PCWEBCAM);
                }
                else if (rbAndroid.Checked)
                {
                    mCapture = new Capture(ANDROIDWEBCAM);
                }
            }
            catch (NullReferenceException excpt)
            {
                WriteInfoToDisplay(rtbPreviewInfo, excpt.GetType() + ": " + excpt.Message);
            }
        }

        /// <summary>
        /// Opens a connection to the arduino and start recording.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnStart_Click(object sender, EventArgs e)
        {
            if (mGame != null && cbPorts.SelectedItem != null)
            {
                AccessCamera();

                port = new SerialPort();

                try
                {
                    port = new SerialPort(cbPorts.SelectedItem.ToString(), int.Parse(cbBaudrates.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
                    port.DtrEnable = true;
                    port.Open();
                }
                catch (Exception ex)
                {
                    WriteInfoToDisplay(rtbPreviewInfo, ex.GetType() + ": " + ex.Message);
                }
                finally
                {
                    if (port.IsOpen)
                    {
                        WriteInfoToDisplay(rtbPreviewInfo, "Succeeded opening " + cbPorts.SelectedItem + "!");
                        mIsRunning = true;
                        bttnStart.Enabled = false;
                        bttnStop.Enabled = true;
                    }
                }

                // The application lets the webcam catch the images
                // and put them in the imagebox
                Application.Idle += ProcessFrame;
            }
            else
            {
                MessageBox.Show("Check first if:\r\n1) You have set a new game\r\n2) You have selected a COM port", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Stop recording and close the port.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();

                    bttnStop.Enabled = false;
                    bttnStart.Enabled = true;
                    bttnStopGame.Enabled = true;

                    WriteInfoToDisplay(rtbPreviewInfo, "Succesfully closed " + cbPorts.SelectedItem + "!");

                    // reset game view
                    if (mGame != null)
                    {
                        mGame.ResetGameView();
                    }

                    WriteInfoToDisplay(rtbGameInfo, "Game stopped! Result: " + (mGame.HasWon ? "Player Won!" : "PC Won!"));
                }
            }
            catch (Exception ex)
            {
                WriteInfoToDisplay(rtbPreviewInfo, ex.GetType() + ": " + ex.Message);
            }

            Release();
        }
        #endregion

        #region Image Processing
        private void ProcessFrame(object sender, EventArgs e)
        {
            Mat img = mCapture.QueryFrame();
            ApplyImg(img);
        }

        /// <summary>
        /// Applies the captured image to an imagebox.
        /// </summary>
        /// <param name="image">The image to be applied.</param>
        private void ApplyImg(Mat image)
        {
            if (image != null)
            {
                if (tcTabs.SelectedTab == tpSettings)
                {
                    Mat endImg = new Mat();

                    if (rbBgr.Checked)
                    {
                        // Do nothing with the original image
                        // So just put it in the endImg variable
                        endImg = image;
                    }

                    if (rbGray.Checked)
                    {
                        endImg = ConvertToGray(image);
                    }

                    if (rbCanny.Checked)
                    {
                        endImg = ConvertToCanny(image, tbMinThresh.Value, tbMaxThresh.Value);
                    }

                    if (rbGrid.Checked)
                    {
                        endImg = DetectRectangles(ConvertToCanny(image, tbMinThresh.Value, tbMaxThresh.Value), Color.FromName(cbColors.SelectedItem.ToString()), (FontFace)cbFonts.SelectedValue, (double)numSize.Value, (double)numArea.Value, (int)numThickness.Value);
                    }

                    if (rbCircle.Checked)
                    {
                        endImg = DetectCircles(ConvertToGray(image), tbCannyThresh.Value, tbAcumulatorThresh.Value, (double)numDp.Value, (double)numMinDist.Value, (int)numMinRadius.Value, Color.FromName(cbColors.SelectedItem.ToString()), (FontFace)cbFonts.SelectedValue, (double)numSize.Value, (int)numThickness.Value);
                    }

                    if (rbTriangle.Checked)
                    {
                        endImg = DetectTriangles(ConvertToCanny(image, tbMinThresh.Value, tbMaxThresh.Value), Color.FromName(cbColors.SelectedItem.ToString()), (FontFace)cbFonts.SelectedValue, (double)numSize.Value, (double)numArea.Value, (int)numThickness.Value);
                    }

                    // Put the endImg in the preview imagebox
                    ibPreview.Image = endImg;
                }
                else if (tcTabs.SelectedTab == tpGame)
                {
                    Mat rectangleImg = new Mat();
                    Mat triangleImg = new Mat();
                    Mat circleImg = new Mat();
                    Mat endImg = image;

                    if (ckbxRectangles.Checked)
                    {
                        rectangleImg = DetectRectangles(ConvertToCanny(image, tbMinThresh.Value, tbMaxThresh.Value), Color.FromName(cbColors.SelectedItem.ToString()), (FontFace)cbFonts.SelectedValue, (double)numSize.Value, (double)numArea.Value, (int)numThickness.Value);
                        CvInvoke.AddWeighted(endImg, 1.0, rectangleImg, 1.0, 0.0, endImg);
                    }

                    if (ckbxTriangles.Checked)
                    {
                        triangleImg = DetectTriangles(ConvertToCanny(image, tbMinThresh.Value, tbMaxThresh.Value), Color.FromName(cbColors.SelectedItem.ToString()), (FontFace)cbFonts.SelectedValue, (double)numSize.Value, (double)numArea.Value, (int)numThickness.Value);
                        CvInvoke.AddWeighted(endImg, 1.0, triangleImg, 1.0, 0.0, endImg);
                    }

                    if (ckbxCircles.Checked)
                    {
                        circleImg = DetectCircles(ConvertToGray(image), tbCannyThresh.Value, tbAcumulatorThresh.Value, (double)numDp.Value, (double)numMinDist.Value, (int)numMinRadius.Value, Color.FromName(cbColors.SelectedItem.ToString()), (FontFace)cbFonts.SelectedValue, (double)numSize.Value, (int)numThickness.Value);
                        CvInvoke.AddWeighted(endImg, 1.0, circleImg, 1.0, 0.0, endImg);
                    }

                    // Put the endImg in the camera viewbox
                    ibCamView.Image = endImg;
                }
            }
        }

        /// <summary>
        /// Stop recording.
        /// </summary>
        private void Release()
        {
            if (mCapture != null)
            {
                mCapture.Dispose();

                // reset image views
                ibPreview.Image = null;
                ibCamView.Image = null;
            }
        }

        #region Conversion
        /// <summary>
        /// Converts an image to a gray image.
        /// </summary>
        /// <param name="img">The image to be converted to gray.</param>
        /// <returns>A gray image.</returns>
        private Mat ConvertToGray(Mat img)
        {
            Mat grayImg = new Mat();
            CvInvoke.CvtColor(img, grayImg, ColorConversion.Bgr2Gray);

            return grayImg;
        }

        /// <summary>
        /// Converts the gray img to a canny img.
        /// </summary>
        /// <param name="img">The gray frame captured by the webcam.</param>
        /// <param name="cannyImg">The image to which the edges will be stored.</param>
        /// <param name="minThresh">The minimum threhshold for the edges to be found.</param>
        /// <param name="maxThresh">The maximum threshold for the edges to be found.</param>
        /// <returns>A canny image.</returns>
        private Mat ConvertToCanny(Mat img, double minThresh, double maxThresh)
        {
            Mat smallImg = new Mat();
            Mat bigImg = new Mat();
            Mat cannyImg = new Mat();

            // Convert the coloured image to a gray image
            // Make the image smaller
            CvInvoke.PyrDown(ConvertToGray(img), smallImg);

            // Make the small image larger
            CvInvoke.PyrUp(smallImg, bigImg);

            // Convert to canny
            CvInvoke.Canny(bigImg, cannyImg, minThresh, maxThresh);

            return cannyImg;
        }
        #endregion

        #region Shape Detection
        /// <summary>
        /// Detects and draws circles on the captured image.
        /// </summary>
        /// <param name="grayImg">The gray image on which the circles are detected.</param>
        /// <param name="cannyThreshold">The higher threshold of the two passed to the canny edge detector.</param>
        /// <param name="circleAccumulatorThreshold">The accumulator threshold for the circle centers at the detection stage.</param>
        /// <param name="dp">Inverse ratio of the accumulator resolution to the image resolution.</param>
        /// <param name="minDist">The minimum distance of the circles.</param>
        /// <param name="minRadius">The minimum radius of the circles to be drawn.</param>
        /// <param name="c">The color which will be used to draw.</param>
        /// <param name="f">The font used to draw on the image.</param>
        /// <param name="fontsize">The size of the font which will be drawn on the image.</param>
        /// <param name="thickness">The thickness of the lines to be drawn.</param>
        /// <returns>An image with drawed circles.</returns>
        private Mat DetectCircles(Mat grayImg, double cannyThreshold, double circleAccumulatorThreshold, double dp, double minDist, int minRadius, Color c, FontFace f, double fontsize, int thickness)
        {
            Mat circleImg;

            CvInvoke.PyrDown(grayImg, grayImg);
            CvInvoke.PyrUp(grayImg, grayImg);

            CircleF[] circles = CvInvoke.HoughCircles(grayImg, HoughType.Gradient, dp, minDist, cannyThreshold, circleAccumulatorThreshold, minRadius);

            DrawCircles(grayImg, out circleImg, circles, f, fontsize, c, thickness);

            if(tcTabs.SelectedTab == tpGame)
            {
                AddCirclesToGameField(circles);
            }

            return circleImg;
        }

        /// <summary>
        /// Draws the circles to the image.
        /// </summary>
        /// <param name="grayImg">The captured image converted to grayscale.</param>
        /// <param name="circleImg">The image on which the circles will be drawn.</param>
        /// <param name="arr">The array in which the circles are stored.</param>
        /// <param name="f">The font used to draw on the image.</param>
        /// <param name="fontsize">The size of the font.</param>
        /// <param name="c">The color which will be used to draw.</param>
        /// <param name="thickness">The thickness of the lines which will be drawn.</param>
        private void DrawCircles(Mat grayImg, out Mat circleImg, CircleF[] arr, FontFace f, double fontsize, Color c, int thickness)
        {
            circleImg = new Mat(grayImg.Size, DepthType.Cv8U, 3);
            circleImg.SetTo(new MCvScalar(0));

            foreach (CircleF circle in arr)
            {
                CvInvoke.Circle(circleImg, Point.Round(circle.Center), (int)circle.Radius, new Bgr(c).MCvScalar, 2);

                if (ckbxShowLabels.Checked)
                {
                    CvInvoke.PutText(circleImg, SetLabel("Circle", circle), Point.Round(circle.Center), f, fontsize, new Bgr(c).MCvScalar, thickness, LineType.EightConnected);
                }
            }
        }

        /// <summary>
        /// Sets a label to be drawn on the filtered image.
        /// </summary>
        /// <param name="text">The text to be written.</param>
        /// <param name="o">The object of which we require the position. This can be a circle, rectangle, triangle...</param>
        /// <returns>The formatted text to be displayed on the filtered image.</returns>
        private string SetLabel(string text, dynamic o)
        {
            float xPos = 0, yPos = 0;

            if (o.GetType() == typeof(CircleF) || o.GetType() == typeof(RotatedRect))
            {
                xPos = o.Center.X;
                yPos = o.Center.Y;
            }
            else if (o.GetType() == typeof(Triangle2DF))
            {
                xPos = o.Centeroid.X;
                yPos = o.Centeroid.Y;
            }
            
            return string.Format("{0} ({1},{2})", text, xPos, yPos);
        }

        /// <summary>
        /// Detects if there are triangles on the captured image.
        /// </summary>
        /// <param name="cannyImg">The captured image.</param>
        /// <param name="c">The color in which will be drawn.</param>
        /// <param name="f">The font which is being used for the label.</param>
        /// <param name="fontsize">The size of the font.</param>
        /// <param name="area">The area which will determine if a polygon is detected.</param>
        /// <param name="thickness">The thickness in which will be drawn.</param>
        /// <returns>An image on which the triangles are drawn.</returns>
        private Mat DetectTriangles(Mat cannyImg, Color c, FontFace f, double fontsize, double area, int thickness)
        {
            Mat triangleImg;

            // Make a list in which we will store the triangles
            List<dynamic> triangles = new List<dynamic>();
            
            // This will store the contours 
            VectorOfVectorOfPoint contours;

            GetContours(cannyImg, out contours);
            FindFigures(contours, triangles, area, typeof(Triangle2DF));

            DrawTriangles(cannyImg, out triangleImg, triangles, c, f, fontsize, thickness);

            if (tcTabs.SelectedTab == tpGame)
            {
                AddTrianglesToGameField(triangles);
            }

            return triangleImg;
        }

        private void AddTrianglesToGameField(List<dynamic> triangles)
        {
            byte minDist = 200;
            byte currentIndex = 0;

            try
             {
                for (byte i = 0; i < mGame.Height; i++)
                {
                    for (byte j = 0; j < mGame.Width; j++)
                    {
                        float distX = Math.Abs(rects[i, j].Center.X - triangles[currentIndex].Centeroid.X);
                        float distY = Math.Abs(rects[i, j].Center.Y - triangles[currentIndex].Centeroid.Y);

                        if (distX < minDist && distY < minDist)
                        {
                            triangs[i, j] = triangles[currentIndex];
                            currentIndex++;
                        }
                    }
                }

                mGame.AddToGameField(triangs, "D");
            }
            catch(Exception e)
            {
                WriteInfoToDisplay(rtbGameInfo, e.GetType() + ": " + e.Message);
            }
        }

        private void AddCirclesToGameField(CircleF[] circles)
        {
            byte minDist = 5;
            byte currentIndex = 0;

            try
            {
                for (byte i = 0; i < mGame.Height; i++)
                {
                    for (byte j = 0; j < mGame.Width; j++)
                    {
                        float distX = Math.Abs(rects[i, j].Center.X - circles[currentIndex].Center.X);
                        float distY = Math.Abs(rects[i, j].Center.Y - circles[currentIndex].Center.Y);

                        if (distX < minDist && distY < minDist)
                        {
                            circs[i, j] = circles[currentIndex];
                            currentIndex++;
                        }
                    }
                }

                mGame.AddToGameField(circs, "C");
            }
            catch (Exception e)
            {
                WriteInfoToDisplay(rtbGameInfo, e.GetType() + ": " + e.Message);
            }
        }

        /// <summary>
        /// Find a certain type of figure in the contours.
        /// </summary>
        /// <param name="contours">The contours which were found using the GetContours()-function.</param>
        /// <param name="figures">The list of figures to which the figures should be added.</param>
        /// <param name="area">Which area should the figure take to be treated as a figure?</param>
        /// <param name="t">What are we looking for?</param>
        private void FindFigures(VectorOfVectorOfPoint contours, List<dynamic> figures, double area, Type t)
        {
            int countoursCount = contours.Size;

            for (byte i = 0; i < countoursCount; i++)
            {
                using (VectorOfPoint contour = contours[i])
                using (VectorOfPoint approxContour = new VectorOfPoint())
                {
                    CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.1, true);

                    // We only want the polygons which are big enough to be treated as a figure
                    // ContourArea > false to return absolute value
                    if (CvInvoke.ContourArea(approxContour, false) > area)
                    {
                        AddFiguresToList(approxContour, figures, t);
                    }
                }
            }
        }

        /// <summary>
        /// Adds the found triangles to a list of triangles.
        /// </summary>
        /// <param name="approxContour">The calculated vertacies.</param>
        /// <param name="triangles">The list of triangles to which the trianges are added.</param>
        private void AddFiguresToList(VectorOfPoint approxContour, List<dynamic> figures, Type t)
        {
            if (approxContour.Size == 3 && t == typeof(Triangle2DF)) // it's a triangle
            {
                Point[] pts = approxContour.ToArray();
                figures.Add(new Triangle2DF(pts[0], pts[1], pts[2]));
            }
            else if (approxContour.Size == 4 && t == typeof(RotatedRect)) // it's a rectangle
            {
                bool isRectangle = false;
                Point[] pts = approxContour.ToArray();
                LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                for (int j = 0; j < edges.Length; j++)
                {
                    // measure angle between the first (or second) line and the current line
                    double angle = Math.Abs(edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));

                    if (angle > 80 || angle < 100)
                    {
                        isRectangle = true;
                        break;
                    }
                }

                if (isRectangle)
                {
                    figures.Add(CvInvoke.MinAreaRect(approxContour));
                }
            }
        }

        /// <summary>
        /// Detects if there are rectangles on the captured image.
        /// </summary>
        /// <param name="cannyImg">The captured image.</param>
        /// <param name="c">The color in which will be drawn.</param>
        /// <param name="f">The font which is being used for the label.</param>
        /// <param name="fontsize">The size of the font.</param>
        /// <param name="area">The area which will determine if a polygon is detected.</param>
        /// <param name="thickness">The thickness in which will be drawn.</param>
        /// <returns>An image on which the rectangles are drawn.</returns>
        private Mat DetectRectangles(Mat cannyImg, Color c, FontFace f, double fontsize, double area, int thickness)
        {
            Mat rectangleImg;
            CvInvoke.GaussianBlur(cannyImg, cannyImg, new Size(15, 15), 0);

            // Make a list in which we will store the found rectangle
            List<dynamic> rectangles = new List<dynamic>();
            VectorOfVectorOfPoint contours;

            GetContours(cannyImg, out contours);
            FindFigures(contours, rectangles, area, typeof(RotatedRect));
            FilterRectangles(rectangles);

            label1.Text = rectangles.Count().ToString();

            DrawRectangles(cannyImg, out rectangleImg, rectangles, c, f, fontsize, thickness);
            return rectangleImg;
        }

        /// <summary>
        /// Filters the biggest rectangle out of the image.
        /// </summary>
        /// <param name="rectangles">The list of rectangles in which the tracked rectangles are stored.</param>
        private void FilterRectangles(List<dynamic> rectangles)
        {
            try
            {
                // Take the first element out of the list
                RotatedRect selectedRect = rectangles[0];

                foreach (RotatedRect r in rectangles)
                {
                    // When the width and height of the current rectangle is bigger than the selected rectangle
                    if (r.Size.Width > selectedRect.Size.Width && r.Size.Height > selectedRect.Size.Height)
                    {
                        // The current rectangle is bigger than the selected rectangle
                        // so assign the current rectangle to the selected rectangle
                        selectedRect = r;
                    }
                }

                // when the biggest rectangle has been found, delete it from the list
                rectangles.Remove(selectedRect);
            }
            catch (Exception ex)
            {
                WriteInfoToDisplay(rtbPreviewInfo, ex.GetType() + ": " + ex.Message);
            }
        }

        /// <summary>
        /// Draws the found rectangles to the image.
        /// </summary>
        /// <param name="cannyImg">The original image.</param>
        /// <param name="triangleImg">The image on which the rectangles will be drawn.</param>
        /// <param name="rectangles">The list of rectangles.</param>
        /// <param name="c">The color in which will be drawn.</param>
        /// <param name="thickness">The thickness of the drawings.</param>
        private void DrawRectangles(Mat cannyImg, out Mat rectangleImg, List<dynamic> rectangles, Color c, FontFace f, double fontsize, int thickness)
        {
            rectangleImg = new Mat(cannyImg.Size, DepthType.Cv8U, 3);
            rectangleImg.SetTo(new MCvScalar(0));

            foreach (RotatedRect r in rectangles)
            {
                CvInvoke.Polylines(rectangleImg, Array.ConvertAll(r.GetVertices(), Point.Round), true, new Bgr(c).MCvScalar, thickness);

                if (ckbxShowLabels.Checked)
                {
                    CvInvoke.PutText(rectangleImg, SetLabel("Rect", r), Point.Round(r.Center), f, fontsize, new Bgr(c).MCvScalar, thickness);
                }
            }

            InitializeGameField(rectangles);
        }

        private void InitializeGameField(List<dynamic> rectangles)
        {
            try
            {
                if (tcTabs.SelectedTab == tpGame && !mGame.HasInitialized)
                {
                    byte numRectangles = (byte)rectangles.Count();

                    if (numRectangles == (numWidth.Value * numHeight.Value))
                    {
                        WriteInfoToDisplay(rtbGameInfo, "Number of fields " + numRectangles);
                        WriteInfoToDisplay(rtbGameInfo, "Adding fields to array.");

                        byte currentRect = 0;
                        byte width = (byte)numWidth.Value, height = (byte)numHeight.Value;

                        mGame = new Game(width, height, this);
                        rects = new RotatedRect[width, height];
                        triangs = new Triangle2DF[width, height];
                        circs = new CircleF[width, height];

                        for (byte i = 0; i < height; i++)
                        {
                            for (byte j = 0; j < width; j++)
                            {
                                rects[i, j] = rectangles[currentRect];
                                currentRect++;
                            }
                        }

                        mGame.InitializeGame();
                    }
                }
            }
            catch(Exception ex)
            {
                WriteInfoToDisplay(rtbPreviewInfo, ex.GetType() + ": " + ex.Message);
            }
        }

        /// <summary>
        /// Draws the found triangles to the image.
        /// </summary>
        /// <param name="cannyImg">The original image.</param>
        /// <param name="triangleImg">The image on which the triangles will be drawn.</param>
        /// <param name="triangles">The list of triangles.</param>
        /// <param name="c">The color in which will be drawn.</param>
        /// <param name="thickness">The thickness of the drawings.</param>
        private void DrawTriangles(Mat cannyImg, out Mat triangleImg, List<dynamic> triangles, Color c, FontFace f, double fontsize, int thickness)
        {
            triangleImg = new Mat(cannyImg.Size, DepthType.Cv8U, 3);
            triangleImg.SetTo(new MCvScalar(0));

            foreach (Triangle2DF triangle in triangles)
            {
                CvInvoke.Polylines(triangleImg, Array.ConvertAll(triangle.GetVertices(), Point.Round), true, new Bgr(c).MCvScalar, thickness);

                if (ckbxShowLabels.Checked)
                {
                    CvInvoke.PutText(triangleImg, SetLabel("Triangle", triangle), Point.Round(triangle.Centeroid), f, fontsize, new Bgr(c).MCvScalar, thickness);
                }
            }
        }

        /// <summary>
        /// Find the contours on a captured image.
        /// </summary>
        /// <param name="cannyImg">The image on which we will find the contours.</param>
        /// <returns>The found contours.</returns>
        private void GetContours(Mat cannyImg, out VectorOfVectorOfPoint contours)
        {
            contours = new VectorOfVectorOfPoint();

            CvInvoke.FindContours(cannyImg, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
        }
        #endregion
        #endregion

        #region UI
        private void rbCanny_CheckedChanged(object sender, EventArgs e)
        {
            gbThreshold.Enabled = ((RadioButton)sender).Checked;
        }

        private void tbCannyThresh_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(tbCannyThresh))
            {
                lblCannyThresh.Text = "Canny threshold: " + tbCannyThresh.Value.ToString();
            }
            else if (sender.Equals(tbAcumulatorThresh))
            {
                lblAccumulatorThresh.Text = "Accumulator threshold: " + tbAcumulatorThresh.Value.ToString();
            }
            else if (sender.Equals(tbMinThresh))
            {
                lblMinThreshold.Text = "Min value:\r\n" + tbMinThresh.Value.ToString();
            }
            else
            {
                lblMaxThreshold.Text = "Max value:\r\n" + tbMaxThresh.Value.ToString();
            }
        }

        /// <summary>
        /// Writes a certain message to the infobox.
        /// </summary>
        /// <param name="sender">The object to which the text should be written.</param>
        /// <param name="text">Text to write to the control.</param>
        private void WriteInfoToDisplay(object sender, string text)
        {
            ((RichTextBox)sender).Text += string.Format("> log {0}: {1}\r\n\r\n--------------------------------------------------------------------------------------------\r\n", 
                                                 countWrittenToDisplay, text);
            countWrittenToDisplay++;
        }

        private void rbAndroid_CheckedChanged(object sender, EventArgs e)
        {
            Release();

            if (mIsRunning)
            {
                if (sender.Equals(rbAndroid))
                {
                    try
                    {
                        mCapture = new Capture(ANDROIDWEBCAM);
                    }
                    catch (Exception ex)
                    {
                        WriteInfoToDisplay(rtbPreviewInfo, ex.GetType() + ": " + ex.Message);
                    }
                }
                else if (sender.Equals(rbPCWebcam))
                {
                    try
                    {
                        mCapture = new Capture(PCWEBCAM);
                    }
                    catch (Exception ex)
                    {
                        WriteInfoToDisplay(rtbPreviewInfo, ex.GetType() + ": " + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Game Logic
        /// <summary>
        /// Before starting the webcam feed, set a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSetGame_Click(object sender, EventArgs e)
        {
            try
            {
                mGame = new Game(numWidth.Value, numHeight.Value, this);

                numWidth.Enabled = false;
                numHeight.Enabled = false;
                ((Button)sender).Enabled = false;

                WriteInfoToDisplay(rtbGameInfo, "Set game to: " + numWidth.Value + " by " + numHeight.Value);
            }
            catch (Exception ex)
            {
                WriteInfoToDisplay(rtbGameInfo, ex.GetType() + ": " + ex.Message);
            }
        }

        /// <summary>
        /// Clear the infoboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnClear_Click(object sender, EventArgs e)
        {
            if(rtbGameInfo.Text != string.Empty || rtbPreviewInfo.Text != string.Empty)
            {
                rtbGameInfo.Clear();
                rtbPreviewInfo.Clear();
            }
        }

        /// <summary>
        /// Stop the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnStopGame_Click(object sender, EventArgs e)
        {
            mGame = null;

            WriteInfoToDisplay(rtbGameInfo, "Game stopped.");

            numWidth.Enabled = true;
            numHeight.Enabled = true;
            ((Button)sender).Enabled = false;
            bttnSetGame.Enabled = true;
        }
        #endregion
    }
}
