using Android.App;
using Android.Widget;
using Android.OS;
using Android.Hardware.Camera2;
using Android.Content;
using Android.Content.PM;
using Android.Util;

namespace CameraStream
{
    [Activity(Label = "CameraStream", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

        private bool CheckCameraHardware(Context context)
        {
            if (context.PackageManager.HasSystemFeature(PackageManager.FeatureCamera))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static CameraManager GetCameraInstance()
        {
            CameraManager cm = null;

            try
            {
                cm.OpenCamera()
            }
        }
    }
}

