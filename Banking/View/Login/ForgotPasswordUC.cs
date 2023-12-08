using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking.AControls;
using Banking.DALs;

namespace Banking
{
    public partial class ForgotPasswordUC : UserControl
    {
        private int otp = 111111;

        public ForgotPasswordUC()
        {
            InitializeComponent();
        }

        private void pibHideViewPassword_Click(object sender, EventArgs e)
        {
            if (atxbPassword.PasswordChar)
            {
                atxbPassword.PasswordChar = false;
                pibHideViewPassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbPassword.PasswordChar = true;
                pibHideViewPassword.BackgroundImage = Properties.Resources.view;
            }
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            FormLogin currentForm = FindForm() as FormLogin;
            currentForm.loadBody(new LoginUC());
        }

        public void sendOTP(string recipient)
        {
            // Thông tin tài khoản Gmail
            string email = "nhanhelpxx@gmail.com";
            string password = "xxts wmgb aeoe favp";

            // Tạo đối tượng MailMessage
            MailMessage message = new MailMessage();
            message.From = new MailAddress(email);
            message.To.Add(recipient);
            message.Subject = "Gửi mã xác nhận OTP";

            // Tạo ngẫu nhiên
            Random random = new Random();
            otp = random.Next(100000, 1000000);
            message.Body = "Mã OTP: " + otp.ToString();

            // Tạo đối tượng SmtpClient và cấu hình thông tin SMTP của Gmail
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(email, password);

            try
            {
                // Gửi email
                smtpClient.Send(message);

                AMessageBoxFrm ms = new AMessageBoxFrm("Đã gửi mã xác nhận OTP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            catch (Exception ex)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void lbSendOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Email không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                sendOTP(atxbEmail.Texts.Trim());
            }
        }

        private void abtnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Email không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbOTP.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mã OTP không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (atxbOTP.Texts.Trim() != otp.ToString())
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mã OTP không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Tạo mới mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ms.ShowDialog() == DialogResult.OK)
                {
                    CustomerDAL.Ins.changePassword(atxbEmail.Texts.Trim(), atxbPassword.Texts.Trim());

                    FormLogin currentForm = FindForm() as FormLogin;
                    currentForm.loadBody(new LoginUC());
                }
            }
        }
    }
}
