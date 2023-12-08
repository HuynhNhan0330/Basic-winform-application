using Banking.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Banking.Utils
{
    public class Helper
    {
        public static string FormatVNMoney(decimal money)
        {
            if (money == 0)
            {
                return "0 ₫";
            }
            return String.Format(CultureInfo.InvariantCulture,
                                "{0:#,#} ₫", money);
        }

        public static string nextCode(string code, string key)
        {
            if (code is null)
                return key + "0001";

            string newCodeString = $"000{int.Parse(code.Substring(key.Length)) + 1}";
            return key + newCodeString.Substring(newCodeString.Length - 4, 4);
        }

        public static Customer getCurrentCustomer()
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
            return form.customer;
        }

        public static Image loadImagePath(string path)
        {
            try
            {
                Image img = Image.FromFile(path);
                return img;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                return null;
            }
        }
    }
}
