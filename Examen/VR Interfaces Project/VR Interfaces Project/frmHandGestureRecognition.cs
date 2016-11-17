using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
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
    public enum Filter
    {
        Bgr,
        Hsv,
        Gray,
        ColorRange,
        Canny
    }

    public partial class frmHandGestureRecognition : Form
    {
        private SerialPort port;
        private Capture mCapture;
        private ushort countWrittenToDisplay = 0;
        private const int PCWEBCAM = 0, ANDROIDWEBCAM = 1;
        private bool mIsRunning = false;

        #region Initialize
        public frmHandGestureRecognition()
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

        #region Camera Access
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
                WriteInfoToDisplay(rtbOutputInfo, excpt.GetType() + ": " + excpt.Message);
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
                    WriteInfoToDisplay(rtbOutputInfo, ex.GetType() + ": " + ex.Message);
                }
                finally
                {
                    if (port.IsOpen)
                    {
                        WriteInfoToDisplay(rtbOutputInfo, "Succeeded opening " + cbPorts.SelectedItem + "!");
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
   
                    WriteInfoToDisplay(rtbOutputInfo, "Succesfully closed " + cbPorts.SelectedItem + "!");
                }
            }
            catch (Exception ex)
            {
                WriteInfoToDisplay(rtbOutputInfo, ex.GetType() + ": " + ex.Message);
            }

            Release();
        }
        #endregion

        #region ProcessFrame
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
                Mat endImg = new Mat();

                if (tcPages.SelectedTab == tpProgram)
                {
                    if (rbBGR.Checked)
                    {
                        // Do nothing with the original image
                        // So just put it in the endImg variable
                        endImg = image;
                    }

                    if (rbHSV.Checked)
                    {
                        endImg = ConvertToHSV(image);
                    }

                    if (rbCanny.Checked)
                    {
                        endImg = ConvertToCanny(image, tbMinThresh.Value, tbMaxThresh.Value);
                    }

                    if (rbColorRange.Checked)
                    {
                        endImg = ConvertToColorRange(image);

                        if (ckbxErode.Checked) // erode the image
                        {
                            try
                            {
                                Mat erodeStruct = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size((int)nbErode.Value, (int)nbErode.Value), new Point(-1, -1));
                                CvInvoke.Erode(endImg, endImg, erodeStruct, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.GetType() + ": " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ckbxErode.Checked = false;    // fallback, otherwise it keeps giving an error message
                            }

                        }

                        if (ckbxDilate.Checked) // dilate the image
                        {
                            try
                            {
                                Mat dilateStruct = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size((int)nbDilate.Value, (int)nbDilate.Value), new Point(-1, -1));
                                CvInvoke.Dilate(endImg, endImg, dilateStruct, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.GetType() + ": " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ckbxDilate.Checked = false;    // fallback, otherwise it keeps giving an error message
                            }
                        }
                    }

                    // Put the endImg in the preview imagebox
                    ibPreview.Image = image;
                    ibOutput.Image = endImg;
                }
                else // we're on the color settings tab
                {
                    if (rbHSVSettings.Checked)
                    {
                        endImg = ConvertToHSV(image);
                    }
                    else if(rbColorRangeSettings.Checked)
                    {
                        endImg = ConvertToColorRange(image);
                    }

                    ibPreviewSettings.Image = endImg;
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
                ibOutput.Image = null;
            }
        }
        #endregion

        #region Shape Detection
        private void ExtractContourAndHull(Mat img)
        {
            VectorOfVectorOfPoint contours;

            GetContours(ConvertToCanny(img, tbMinThresh.Value, tbMaxThresh.Value), out contours);
        }

        /// <summary>
        /// Find the contours on a captured image.
        /// </summary>
        /// <param name="cannyImg">The image on which we will find the contours.</param>
        /// <returns>The found contours.</returns>
        private void GetContours(Mat cannyImg, out VectorOfVectorOfPoint contours)
        {
            double largestArea = 0;
            VectorOfPoint largestContour;
            contours = new VectorOfVectorOfPoint();
            

            CvInvoke.FindContours(cannyImg, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

            for(int i = 0; i < contours.Size; i++)
            {
                double a = CvInvoke.ContourArea(contours[i], false);

                if(a > largestArea)
                {
                    largestContour = contours[i];
                }
            }

            if(largestContour != null)
            {
                CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.1, true);
            }
        }
        #endregion

        #region Erode/Dilate Enabling
        private void erodeChkBx_CheckedChanged(object sender, EventArgs e)
        {
            nbErode.Enabled = ckbxErode.Checked;
        }

        private void dilateChkBx_CheckedChanged(object sender, EventArgs e)
        {
            nbDilate.Enabled = ckbxDilate.Checked;
        }
        #endregion

        #region Conversion
        /// <summary>
        /// Converts an image to the HSV color spave and returns it.
        /// </summary>
        /// <param name="img"></param>
        /// <returns>An image in the HSV color space.</returns>
        private Mat ConvertToHSV(Mat img)
        {
            Mat HSVimage = new Mat();
            CvInvoke.CvtColor(img, HSVimage, ColorConversion.Bgr2Hsv);

            return HSVimage;
        }

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

        /// <summary>
        /// Converts an image to the color range color space and returns it.
        /// </summary>
        /// <param name="img">The image to be converted.</param>
        /// <returns>An image in the color range color space.</returns>
        private Mat ConvertToColorRange(Mat img)
        {
            Mat colorRangeImg = new Mat();

            // Store the min and max values in an array
            // These values will be used to filter out the color we want
            ScalarArray lowerbounds = new ScalarArray(new MCvScalar(hueMinBar.Value, satMinBar.Value, valMinBar.Value));
            ScalarArray upperbounds = new ScalarArray(new MCvScalar(hueMaxBar.Value, satMaxBar.Value, valMaxBar.Value));

            CvInvoke.InRange(ConvertToHSV(img), lowerbounds, upperbounds, colorRangeImg);

            return colorRangeImg;
        }
        #endregion

        #region UI
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

        /// <summary>
        /// Enable trackbars min and maxranges.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbHSV_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.Equals(rbColorRange))
            {
                ckbxDilate.Enabled = true;
                ckbxErode.Enabled = true;
            }
            else
            {
                ckbxDilate.Enabled = false;
                ckbxErode.Enabled = false;
            }
        }

        /// <summary>
        /// Change between camera's when running.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        WriteInfoToDisplay(rtbOutputInfo, ex.GetType() + ": " + ex.Message);
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
                        WriteInfoToDisplay(rtbOutputInfo, ex.GetType() + ": " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Clear the infobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnClear_Click(object sender, EventArgs e)
        {
            if (rtbOutputInfo.Text != string.Empty)
            {
                rtbOutputInfo.Clear();
            }
        }

        #region Trackbars
        private void hueBar_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(hueMinBar))
            {
                lblHueMin.Text = "Hue:\n" + hueMinBar.Value.ToString() + "°";
            }
            else
            {
                lblHueMax.Text = "Hue:\n" + hueMaxBar.Value.ToString() + "°";
            }
        }

        private void satBar_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(satMinBar))
            {
                lblSatMin.Text = "Sat:\n" + satMinBar.Value.ToString() + "°";
            }
            else
            {
                lblSatMax.Text = "Sat:\n" + satMaxBar.Value.ToString() + "°";
            }
        }

        private void tbYMin_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(tbYMin))
            {
                lblYMin.Text = "Y:\n" + tbYMin.Value.ToString() + "°";
            }
            else
            {
                lblYMax.Text = "Y:\n" + tbYMax.Value.ToString() + "°";
            }
        }

        private void tbCbMin_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(tbCbMin))
            {
                lblCbMin.Text = "Y:\n" + tbCbMin.Value.ToString() + "°";
            }
            else
            {
                lblCbMax.Text = "Y:\n" + tbCbMax.Value.ToString() + "°";
            }
        }

        private void tbCrMin_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(tbCrMin))
            {
                lblCrMin.Text = "Y:\n" + tbCrMin.Value.ToString() + "°";
            }
            else
            {
                lblCrMax.Text = "Y:\n" + tbCrMax.Value.ToString() + "°";
            }
        }

        private void tbMaxThresh_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(tbMinThresh))
            {
                lblMinThreshold.Text = "Min value:\r\n" + tbMinThresh.Value.ToString();
            }
            else
            {
                lblMaxThreshold.Text = "Max value:\r\n" + tbMaxThresh.Value.ToString();
            }
        }

        private void valBar_Scroll(object sender, EventArgs e)
        {
            if (sender.Equals(valMinBar))
            {
                lblValMin.Text = "Val:\n" + valMinBar.Value.ToString() + "°";
            }
            else
            {
                lblValMax.Text = "Val:\n" + valMaxBar.Value.ToString() + "°";
            }
        }
        #endregion
        #endregion
    }
}
