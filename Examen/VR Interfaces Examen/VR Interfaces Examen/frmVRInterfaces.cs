using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
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

namespace VR_Interfaces_Examen
{
    public partial class frmVRInterfaces : Form
    {
        private SerialPort port;
        private Capture mCapture;
        private ushort countWrittenToDisplay = 0;
        private bool mIsRunning = false;
        private const int PCWEBCAM = 0, ANDROIDWEBCAM = 1;

        private float xPos, yPos, curXPos1, curYPos1, curXPos2, curYPos2;

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
            foreach (string p in ports)
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
            if (cbPorts.SelectedItem != null)
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
                MessageBox.Show("Check first if you have selected a COM port", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                    WriteInfoToDisplay(rtbPreviewInfo, "Succesfully closed " + cbPorts.SelectedItem + "!");
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

                    if (rbCircle.Checked)
                    {
                        endImg = DetectCircles(ConvertToGray(image), tbCannyThresh.Value, tbAcumulatorThresh.Value, (double)numDp.Value, (double)numMinDist.Value, (int)numMinRadius.Value, Color.FromName(cbColors.SelectedItem.ToString()), (FontFace)cbFonts.SelectedValue, (double)numSize.Value, (int)numThickness.Value);
                    }

                    // Put the endImg in the preview imagebox
                    ibPreview.Image = endImg;
                }
                else if (tcTabs.SelectedTab == tpGame)
                {
                    Mat circleImg = new Mat();
                    Mat endImg = image;

                    if (ckbxCircles.Checked)
                    {
                        circleImg = DetectCircles(ConvertToGray(image), tbCannyThresh.Value, tbAcumulatorThresh.Value, (double)numDp.Value, (double)numMinDist.Value, (int)numMinRadius.Value, Color.FromName(cbColors.SelectedItem.ToString()), (FontFace)cbFonts.SelectedValue, (double)numSize.Value, (int)numThickness.Value);
                        CvInvoke.AddWeighted(endImg, 1.0, circleImg, 1.0, 0.0, endImg);
                    }

                    if(lblPos1.Text != "Position 1:" && lblPos2.Text != "Position 2:")
                    {
                        bttnSend.Enabled = true;
                    }
                    else
                    {
                        bttnSend.Enabled = false;
                    }

                    if (lblPos1.Text != "Position 1:" || lblPos2.Text != "Position 2:")
                    {
                        bttnReset.Enabled = true;
                    }
                    else
                    {
                        bttnReset.Enabled = false;
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
        #endregion

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

        #endregion

        #region UI
        private void rbCanny_CheckedChanged(object sender, EventArgs e)
        {
            gbThreshold.Enabled = ((RadioButton)sender).Checked;
        }

        /// <summary>
        /// Computes the difference between the two positions and sends them to the Arduino.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSend_Click(object sender, EventArgs e)
        {
            float diffXPos = curXPos1 - curXPos2;
            float diffYPos = curYPos1 - curYPos2;

            WriteInfoToDisplay(rtbGameInfo, "Difference between first and second position:\n(" + diffXPos + ", " + diffYPos + ")");

            try
            {
                if (port.IsOpen)
                {
                    port.Write(diffXPos.ToString() + "," + diffYPos.ToString() + "," + nbSpeed.Value.ToString());
                    //port.Write(diffYPos.ToString());
                    //port.Write(nbSpeed.Value.ToString());
                }
            }
            catch(Exception ex)
            {
                WriteInfoToDisplay(rtbGameInfo, ex.GetType() + ": " + ex.Message);
            }
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

        /// <summary>
        /// Reset positions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnReset_Click(object sender, EventArgs e)
        {
            lblPos1.Text = "Position 1:";
            lblPos2.Text = "Position 2:";

            curXPos1 = 0;
            curYPos1 = 0;
            curXPos2 = 0;
            curYPos2 = 0;

            bttnSetPos.Enabled = true;
            bttnSetSecPos.Enabled = true;

            WriteInfoToDisplay(rtbGameInfo, "Reset positions.");
        }

        /// <summary>
        /// Save the current position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSetPos_Click(object sender, EventArgs e)
        {
            Label l;

            if (sender.Equals(bttnSetPos))
            {
                l = lblPos1;

                curXPos1 = xPos;
                curYPos1 = yPos;

                l.Text += string.Format(" ({0}, {1})", curXPos1, curYPos1);
            }
            else // second postion
            {
                l = lblPos2;

                curXPos2 = xPos;
                curYPos2 = yPos;

                l.Text += string.Format(" ({0}, {1})", curXPos2, curYPos2);
            }
                            
            ((Button)sender).Enabled = false;

            WriteInfoToDisplay(rtbGameInfo, string.Format("Set {0} to {1}.", 
                                 l == lblPos1 ? "first position" : "second position", 
                                 l == lblPos1 ? "(" + curXPos1 + "," + curYPos1 + ")" : "(" + curXPos2 + "," + curYPos2 + ")"
                              ));
        }

        /// <summary>
        /// Clear the infoboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnClear_Click(object sender, EventArgs e)
        {
            if (rtbGameInfo.Text != string.Empty || rtbPreviewInfo.Text != string.Empty)
            {
                rtbGameInfo.Clear();
                rtbPreviewInfo.Clear();
            }
        }
        #endregion
    }
}
