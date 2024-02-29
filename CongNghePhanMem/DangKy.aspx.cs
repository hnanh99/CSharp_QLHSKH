using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Text.RegularExpressions;

namespace CongNghePhanMem
{
    public partial class DangKy : System.Web.UI.Page
    {
        public string DM_Id;
        public string ThaoTac;
        Random random = new Random();
        public static string HoVaTen;
        public static string Email;
        public static string Password;
        public static int otp = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "")
            {
                
            }
            else if (txtEmail.Text == "")
            {
                
            }
            else if (txtPassWord.Text == "")
            {
               

            }
            else if (txtPassWord.Text != txtXNPassWord.Text)
            {
                
            }
            else
            {
                DataTable table1 = Model.DbUsers.checkEmail(txtEmail.Text);
                if (IsValidEmail(txtEmail.Text) && table1.Rows.Count == 0)
                {
                    otp = random.Next(100000, 999999);
                    string senderEmail = "Lendoan07@gmail.com";
                    string senderPassword = "zbxtnjpvfchdgbec";
                    string recipientEmail = txtEmail.Text;
                    MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail);
                    mailMessage.Subject = "Xác thực tài khoản";
                    mailMessage.Body = $"Mã xác thực của bạn là: {otp.ToString()}";
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtpClient.EnableSsl = true;
                    try
                    {
                        // Gửi email
                        smtpClient.Send(mailMessage);
                        HoVaTen = "N'" + txtHoVaTen.Text.Replace("'", "''") + "'";
                        Email = "N'" + txtEmail.Text.Replace("'", "''") + "'";
                        Password = "N'" + txtPassWord.Text.Replace("'", "''") + "'";
                    }
                    catch (Exception ex)
                    {

                    }
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('OTP đã được gửi đến email của bạn, nhập mã OTP để xác thực'); setTimeout(function(){ window.location.href = 'OTP.aspx'; }, 0);", true);
                    /*Response.Redirect("~/OTP.aspx");*/
                }
            }
        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool isValid = false;
            string email = args.Value;
            isValid = IsValidEmail(email);
            args.IsValid = isValid;//false là báo lỗi
        }
        static bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$";

            // Sử dụng Regex để kiểm tra định dạng email
            Match match = Regex.Match(email, pattern);

            // Trả về true nếu email hợp lệ, ngược lại trả về false
            return match.Success;
        }
        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool isValid = true;
            string email = args.Value;
            DataTable table1 = Model.DbUsers.checkEmail(email);
            if (table1 == null)
            {
                isValid = true;
            }
            else
            {
                if (table1.Rows.Count > 0)
                {
                    isValid = false;
                }
                args.IsValid = isValid;//false là báo lỗi
            }
        }
        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool isValid = false;
            string XNPW = args.Value;
            
            if (XNPW == txtPassWord.Text)
            {
                isValid = true;
            }
            args.IsValid = isValid;//false là báo lỗi
        }
    }
}