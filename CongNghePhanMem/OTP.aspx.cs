using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Data;

namespace CongNghePhanMem
{
    public partial class OTP : System.Web.UI.Page
    {

        public string DM_Id;

        //public OTP(DangKy xn)
        //{


        //    this.xn = xn;
        //}
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string passwordText = txtXN.Text;
            int enteredOtp;
            if (int.TryParse(passwordText, out enteredOtp))
            {
                // Conversion successful
                if (enteredOtp == DangKy.otp)
                {

                    string HoVaTen = DangKy.HoVaTen;
                    string Email = DangKy.Email;
                    String Password=DangKy.Password;
                            DataTable Insert = Model.DbUsers.InsertUser(
                                     Email
                                   
                                    , HoVaTen
                                    , Password
                                    ,"null"
                                    ,"null"
                                    , "null"
                                    , "null"
                                    , "null"
                                    , "null"
                                    ,"null"
                                    , "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "'"
                                    , "null"
                                    , "0"

                                    );
                            if (Insert.Rows.Count > 0)
                            {
                                DM_Id = Insert.Rows[0]["Id"].ToString();

                            }
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('Đăng kí thành công. Vui lòng đăng nhập'); setTimeout(function(){ window.location.href = 'Login.aspx'; }, 0);", true);
                    //Response.Redirect("~/Login.aspx");
                }
                else
                {
                    
                }
            }
        }
        
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool isValid = false;
            string otp = args.Value;
            int int_otp;
            int.TryParse(otp, out int_otp);
            if (int_otp == DangKy.otp)
            {
                isValid = true;
            }
            args.IsValid = isValid;//false là báo lỗi
        }
    }
}