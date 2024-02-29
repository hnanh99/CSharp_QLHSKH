using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem
{
    public partial class Login : System.Web.UI.Page
    {
        public static string User_Id = "";
        public static string UserCode = "";
        public static string UserName = "";
        public static string Password = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DangKy.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Password = "";
            
                DataTable table1 = Model.DbUsers.checklogin(txtUserName.Text);
                if (table1 != null)
                {
                    if (table1.Rows.Count > 0)
                    {
                        Password = table1.Rows[0]["Password"].ToString();
                        if (PW.Text == Password)
                        {
                            User_Id = table1.Rows[0]["User_Id"].ToString();
                            UserCode = table1.Rows[0]["UserCode"].ToString();
                            UserName = table1.Rows[0]["UserName"].ToString();

                            Session["User_Id"] = User_Id;
                            string returnUrl = Request.QueryString["ReturnUrl"];
                            if (!string.IsNullOrEmpty(returnUrl))
                            {
                                //redirect tới href returnURL
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('Đăng nhập thành công'); setTimeout(function(){ window.location.href = '" + returnUrl + "'; }, 0);", true);
                            }
                            else
                            {
                                //redirect tới Default.apsx
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('Đăng nhập thành công'); setTimeout(function(){ window.location.href = 'Default.aspx'; }, 0);", true);

                            } //
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            
        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool isValid = false;
            
            string username = args.Value;
            DataTable table1 = Model.DbUsers.checklogin(username);
            
            if (table1 != null)
            {
                if(table1.Rows.Count > 0)
                {
                    Password = table1.Rows[0]["Password"].ToString();
                    if (Password == PW.Text)
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }
            
            args.IsValid = isValid;//false là báo lỗi
        }
    }
}