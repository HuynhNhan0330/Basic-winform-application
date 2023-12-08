using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class QRcodeUC : UserControl
    {
        FilterInfoCollection cameras;
        VideoCaptureDevice cam;

        public QRcodeUC()
        {
            InitializeComponent();
            runCam();
        }

        private void runCam()
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (cam != null && cam.IsRunning) cam.Stop();
            cam = new VideoCaptureDevice(cameras[0].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap b = (Bitmap)eventArgs.Frame.Clone();
            pibCam.Image = b;
        }
    }
}
