using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Face_Detection
{
    public partial class faceDetectfrm : Form
    {
        private Capture capture;
        private bool isInProgress = false;
        private CascadeClassifier haar;

        public faceDetectfrm()
        {
            InitializeComponent();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            Mat img = capture.QueryFrame();
            Mat converted_img = new Mat();

            if(img != null)
            {
                CvInvoke.CvtColor(img, converted_img, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                Rectangle[] detectedFaces = haar.DetectMultiScale(converted_img, 1.1, 10, new Size(20, 20));
            }

            camImageBox.Image = converted_img;
        }

        private void startBttn_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (isInProgress)
                {
                    startBttn.Text = "Start";
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    startBttn.Text = "Pause";
                    Application.Idle += ProcessFrame;
                }

                isInProgress = !isInProgress;
            }
        }

        private void ReleaseData()
        {
            if(capture != null)
            {
                capture.Dispose();
            }
        }

        private void faceDetectfrm_Load(object sender, EventArgs e)
        {
            haar = new CascadeClassifier("C:\\Emgu\\emgucv-windesktop 3.1.0.2282\\bin\\haarcascade_frontalface_default.xml");
        }
    }
}
