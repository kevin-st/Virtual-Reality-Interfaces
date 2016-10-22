using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.Util;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortCommunication
{
    public enum Filter
    {
        Bgr,
        Hsv,
        Gray,
        ColorRange,
        Canny
    }

    public partial class SerialPortTestfrm : Form, ISerialPortTestfrm
    {
        #region variables
        private SerialPort port;
        private Capture mCapture = null;

        private string defaultSavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VR Interfaces\\config";
        private string defaultSaveName = "config.ini";
        private string defaultLoadPath = "";

        private Filter mfilter;
        private SaveManager sm;
        #endregion

        public SerialPortTestfrm()
        {
            InitializeComponent();
            Init("COM4", "9600");
            sm = new SaveManager(this);
        }

        #region Properties
        public string SavePath
        {
            get { return savePathTxtBx.Text; }
            set { savePathTxtBx.Text = value; }
        }

        public string LoadPath
        {
            get { return loadTxtBx.Text; }
            set { loadTxtBx.Text = value; }
        }

        public Filter AppliedFilter
        {
            get
            {
                if (bgrRadio.Checked) { return Filter.Bgr; }
                else if (hsvRadio.Checked) { return Filter.Hsv; }
                else if (grayRadio.Checked) { return Filter.Gray; }
                else if (colorRangeRadio.Checked) { return Filter.ColorRange; }
                else { return Filter.Canny; }
            }
            set
            {
                if (AppliedFilter == Filter.Bgr) { bgrRadio.Checked = true; }
                else if (AppliedFilter == Filter.Hsv) { hsvRadio.Checked = true; }
                else if (AppliedFilter == Filter.Gray) { grayRadio.Checked = true; }
                else if (AppliedFilter == Filter.ColorRange) { colorRangeRadio.Checked = true; }
                else { cannyRadio.Checked = true; }
            }
        }

        public int HueMinValue
        {
            get { return hueMinBar.Value; }
            set { hueMinBar.Value = value; }
        }

        public int HueMaxValue
        {
            get { return hueMaxBar.Value; }
            set { hueMaxBar.Value = value; }
        }

        public int SatMinValue
        {
            get { return satMinBar.Value; }
            set { satMinBar.Value = value; }
        }

        public int SatMaxValue
        {
            get { return satMaxBar.Value; }
            set { satMaxBar.Value = value; }
        }

        public int ValMinValue
        {
            get { return valMinBar.Value; }
            set { valMinBar.Value = value; }
        }

        public int ValMaxValue
        {
            get { return valMaxBar.Value; }
            set { valMaxBar.Value = value; }
        }

        public bool IsErodeEnabled
        {
            get { return erodeChkBx.Checked; }
            set { erodeChkBx.Checked = value; }
        }

        public bool IsDilateEnabled
        {
            get { return dilateChkBx.Checked; }
            set { dilateChkBx.Checked = value; }
        }

        public decimal ErodeValue
        {
            get { return erodeNmBx.Value; }
            set { erodeNmBx.Value = value; }
        }

        public decimal DilateValue
        {
            get { return dilateNmBx.Value; }
            set { dilateNmBx.Value = value; }
        }

        public int CannyMinValue
        {
            get { return minThreshBar.Value; }
            set { minThreshBar.Value = value; }
        }

        public int CannyMaxValue
        {
            get { return maxThreshBar.Value; }
            set { maxThreshBar.Value = value; }
        }
        #endregion

        /// <summary>
        /// Initialises the form for the user
        /// </summary>
        /// <param name="portName">The standard value which should be found for the port.</param>
        /// <param name="baudrateName">The standard value which should be found for the baudrate.</param>
        private void Init(string portName, string baudrateName)
        {
            // Find all ports available on the pc
            var ports = SerialPort.GetPortNames();

            // Add all ports to the combobox
            foreach (string s in ports)
            {
                portsCmbx.Items.Add(s);
            }

            // set default values for the comboboxes
            portsCmbx.SelectedIndex = portsCmbx.Items.IndexOf(portName);
            baudrateCmbx.SelectedIndex = baudrateCmbx.Items.IndexOf(baudrateName);

            // Fill in standard save values
            savePathTxtBx.Text = defaultSavePath;

            // when not running, the stop button is disabled
            stopBttn.Enabled = false;
        }

        #region Port Access
        /// <summary>
        /// Opens a connection to the arduino and start recording.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBttn_Click(object sender, EventArgs e)
        {
            // Get access to the webcam
            AccessCamera();

            port = new SerialPort();

            try
            {
                port = new SerialPort(portsCmbx.SelectedItem.ToString(), int.Parse(baudrateCmbx.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
                port.DtrEnable = true;
                port.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ": " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (port.IsOpen)
                {
                    MessageBox.Show("Succeeded opening " + portsCmbx.SelectedItem + "!", "Succes!");
                    startBttn.Enabled = false;
                    stopBttn.Enabled = true;
                }
            }

            // The application lets the webcam catch the images
            // and put them in the imagebox
            Application.Idle += ProcessFrame;
        }

        #region Erode/Dilate Enabling
        private void erodeChkBx_CheckedChanged(object sender, EventArgs e)
        {
            erodeNmBx.Enabled = erodeChkBx.Checked;
        }

        private void dilateChkBx_CheckedChanged(object sender, EventArgs e)
        {
            dilateNmBx.Enabled = dilateChkBx.Checked;
        }
        #endregion

        /// <summary>
        /// Stop recording and close the port.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();

                    stopBttn.Enabled = false;
                    startBttn.Enabled = true;

                    MessageBox.Show("Succesfully closed " + portsCmbx.SelectedItem + "!", "Succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ": " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Release();
        }
        #endregion

        #region Trackbar values
        private void hueBar_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(hueMinBar))
            {
                hueMinLbl.Text = "Hue:\n" + hueMinBar.Value.ToString() + "°";
            }
            else
            {
                hueMaxLbl.Text = "Hue:\n" + hueMaxBar.Value.ToString() + "°";
            }
        }

        private void satBar_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(satMinBar))
            {
                satMinLbl.Text = "Sat:\n" + satMinBar.Value.ToString() + "°";
            }
            else
            {
                satMaxLbl.Text = "Sat:\n" + satMaxBar.Value.ToString() + "°";
            }
        }

        private void valBar_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(valMinBar))
            {
                valMinLbl.Text = "Val:\n" + valMinBar.Value.ToString() + "°";
            }
            else
            {
                valMaxLbl.Text = "Val:\n" + valMaxBar.Value.ToString() + "°";
            }
        }


        private void minThreshBar_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(minThreshBar))
            {
                minThreshLbl.Text = "Min value:\n" + minThreshBar.Value.ToString();
            }
            else
            {
                maxThreshLbl.Text = "Max value:\n" + maxThreshBar.Value.ToString();
            }
        }
        #endregion

        /// <summary>
        /// Get access to the webcam so it get's turned on.
        /// </summary>
        private void AccessCamera()
        {
            try
            {
                mCapture = new Capture();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        /// <summary>
        /// Catches the frames from the webcam and puts them inside the imagebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessFrame(object sender, EventArgs e)
        {
            // original frame captured by the webcam
            Mat img = mCapture.QueryFrame();
            Mat hsvImg = new Mat();
            Mat grayImg = new Mat();
            Mat cannyImg = new Mat();
            Mat colorRangeImg = new Mat();

            if (img != null)
            {
                // Convert the original frame to hsv color space
                CvInvoke.CvtColor(img, hsvImg, ColorConversion.Bgr2Hsv);
                CvInvoke.CvtColor(img, grayImg, ColorConversion.Bgr2Gray);
                ConvertToCanny(grayImg, cannyImg, minThreshBar.Value, maxThreshBar.Value);

                if (colorRangeRadio.Checked)
                {
                    // Store the min and max values in an array
                    // These values will be used to filter out the color we want
                    ScalarArray lowerbounds = new ScalarArray(new MCvScalar(hueMinBar.Value, satMinBar.Value, valMinBar.Value));
                    ScalarArray upperbounds = new ScalarArray(new MCvScalar(hueMaxBar.Value, satMaxBar.Value, valMaxBar.Value));

                    CvInvoke.InRange(hsvImg, lowerbounds, upperbounds, colorRangeImg);

                    #region Comment Blobs
                    //Track(colorRangeImg, out trackedColorRangeImg);

                    //trackedColorRangeImg = colorRangeImg.ToImage<Gray, byte>();
                    //Emgu.CV.Cvb.CvBlobs blobs = new Emgu.CV.Cvb.CvBlobs();
                    //Emgu.CV.Cvb.CvBlobDetector detector = new Emgu.CV.Cvb.CvBlobDetector();

                    //detector.Detect(trackedColorRangeImg, blobs);

                    //for (uint i = 1; i <= blobs.Count; i++)
                    //{
                    //    CvInvoke.Rectangle(img, new Rectangle(), new MCvScalar(255, 255, 255), 5);
                    //}
                    #endregion
                }
            }

            if (erodeChkBx.Checked)
            {
                try
                {
                    Mat erodeStruct = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size((int)erodeNmBx.Value, (int)erodeNmBx.Value), new Point(-1, -1));
                    CvInvoke.Erode(colorRangeImg, colorRangeImg, erodeStruct, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.GetType() + ": " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    erodeChkBx.Checked = false;    // fallback, otherwise it keeps giving an error message
                }
                
            }

            if (dilateChkBx.Checked)
            {
                try
                {
                    Mat dilateStruct = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size((int)dilateNmBx.Value, (int)dilateNmBx.Value), new Point(-1, -1));
                    CvInvoke.Dilate(colorRangeImg, colorRangeImg, dilateStruct, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.GetType() + ": " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dilateChkBx.Checked = false;    // fallback, otherwise it keeps giving an error message
                }
            }

            // Depending on which checkbox is checked
            // put the correct filter into their corresponding boxes
            if (bgrRadio.Checked)
            {
                previewImgBx.Image = img;
                filterImgBx.Image = img;
            }
            else if (hsvRadio.Checked)
            {
                previewImgBx.Image = hsvImg;
                filterImgBx.Image = hsvImg;
            }
            else if(colorRangeRadio.Checked)
            {
                previewImgBx.Image = colorRangeImg;
                filterImgBx.Image = colorRangeImg;
            }
            else if (cannyRadio.Checked)
            {
                previewImgBx.Image = cannyImg;
                filterImgBx.Image = cannyImg;
            }
            else // gray radio button is checked
            {
                previewImgBx.Image = grayImg;
                filterImgBx.Image = grayImg;
            }

            // Put the original frame in the "original" image box
            originalImgBx.Image = img;

            // Put the HSV frame in the HSV image box
            hsvImgBx.Image = hsvImg;

            // Put the gray frame in the gray image box
            grayImgBx.Image = grayImg;

            // Put the canny frame in the canny image box
            cannyImgBx.Image = cannyImg;

            shapeImgBx.Image = DetectCircles(grayImg);
        }

        private Mat DetectCircles(Mat img)
        {
            CvInvoke.PyrDown(img, img);
            CvInvoke.PyrUp(img, img);

            double cannyThreshold = 180.0;
            double circleAccumulatorThreshold = 120;
            CircleF[] circles = CvInvoke.HoughCircles(img, HoughType.Gradient, 2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, 5);

            Mat circleImage = new Mat(img.Size, DepthType.Cv8U, 3);
            circleImage.SetTo(new MCvScalar(0));

            foreach (CircleF circle in circles)
            {
                CvInvoke.Circle(circleImage, Point.Round(circle.Center), (int)circle.Radius, new Bgr(Color.Brown).MCvScalar, 2);
                CvInvoke.PutText(circleImage, "Circle", Point.Round(circle.Center), FontFace.HersheyPlain, 5, new MCvScalar(255,255,255), 1, LineType.EightConnected);
            }

            return circleImage;
        }

        /// <summary>
        /// Converts the gray img to a canny img.
        /// </summary>
        /// <param name="img">The gray frame captured by the webcam.</param>
        /// <param name="cannyImg">The image to which the edges will be stored.</param>
        /// <param name="minThresh">The minimum threhshold for the edges to be found.</param>
        /// <param name="maxThresh">The maximum threshold for the edges to be found.</param>
        private void ConvertToCanny(Mat img, Mat cannyImg, double minThresh, double maxThresh)
        {
            Mat smallImg = new Mat();
            Mat bigImg = new Mat();

            // Make the image smaller
            CvInvoke.PyrDown(img, smallImg);

            // Make the small image larger
            CvInvoke.PyrUp(smallImg, bigImg);

            // Convert to canny
            CvInvoke.Canny(bigImg, cannyImg, minThresh, maxThresh);
        }

        /// <summary>
        /// Stop recording.
        /// </summary>
        private void Release()
        {
            if (mCapture != null)
            {
                mCapture.Dispose();
            }
        }

        private void cannyRadio_CheckedChanged(object sender, EventArgs e)
        {
            thresholdGrBx.Visible = cannyRadio.Checked;
        }

        #region comment Save Load
        ///// <summary>
        ///// When clicked on the savePathBttn a dialog window pops up, prompting the user to select a folder to save the config file to.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void savePathBttn_Click(object sender, EventArgs e)
        {
        //    FolderBrowserDialog fbd = new FolderBrowserDialog();

        //    if(fbd.ShowDialog() == DialogResult.OK)
        //    {
        //        savePathTxtBx.Text = fbd.SelectedPath;
        //    }
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
        //    sm.Save(this, savePathTxtBx.Text, "\\" + defaultSaveName);
        }

        private void loadFileBttn_Click(object sender, EventArgs e)
        {
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "Text files (*.txt)|*.txt|Configuration files (*.config)|*.config|Initialization files (*.ini)|*.ini|All files (*.*)|*.*";
        //    ofd.InitialDirectory = defaultSavePath;

        //    if(ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        loadTxtBx.Text = System.IO.Path.GetDirectoryName(ofd.FileName) + "\\" + ofd.SafeFileName;
        //        //sm.Load(loadTxtBx.Text);

        //        defaultLoadPath = loadTxtBx.Text;
        //    }
        }
        #endregion
    }
}
