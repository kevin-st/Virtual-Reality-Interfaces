using Emgu.CV;
using System;
using System.Windows.Forms;

namespace Camera_Application
{
    public partial class CamCapture : Form
    {
        private Capture capture;
        private bool isInprogress;

        public CamCapture()
        {
            InitializeComponent();
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Mat frame = capture.QueryFrame();
            camImageBox.Image = frame;
        }

        private void startBttn_Click(object sender, EventArgs e)
        {
            if(capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (isInprogress)
                {
                    startBttn.Text = "Start";

                    // callback
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    startBttn.Text = "Pause";

                    // callback
                    Application.Idle += ProcessFrame;
                }

                // invert the current state of isInProgress
                isInprogress = !isInprogress;
            }
        }

        private void ReleaseData()
        {
            if(capture != null)
            {
                capture.Dispose(); // safely close the application
            }
        }
    }
}
