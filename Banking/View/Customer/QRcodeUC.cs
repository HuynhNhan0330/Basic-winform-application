using AForge.Video;
using AForge.Video.DirectShow;
using Banking.AControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode.Internal;

namespace Banking
{
    public partial class QRcodeUC : UserControl
    {
        FilterInfoCollection cameras;
        public VideoCaptureDevice cam;

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

        private void timerQR_Tick(object sender, EventArgs e)
        {
            deCode();
        }

        private void deCode()
        {
            Bitmap imgQRCode = (Bitmap)pibCam.Image;

            if (imgQRCode != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(imgQRCode);

                    if (result == null) return;

                    string decoded = result.ToString().Trim();

                    timerQR.Enabled = false;
                    bool isChange = changePage(decoded);

                    imgQRCode.Dispose();

                    if (!isChange)
                    {
                        AMessageBoxFrm ms = new AMessageBoxFrm("Mã QR không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        timerQR.Enabled = false;
                        ms.ShowDialog();
                        timerQR.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }
            }
        }

        private bool changePage(string code)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
            return form.loadTrasferMoney(code);
        }
    }
}
