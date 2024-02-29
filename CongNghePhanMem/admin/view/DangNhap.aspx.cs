using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.admin.view
{
    public partial class DangNhap : System.Web.UI.Page
    {
        public static string User_Id = "";
        public static string UserCode = "";
        public static string UserName = "";
        public static string Password = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }



  

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Password = "";
           
           
                DataTable table1 = Model.Dbadmin.checklogin(txtUserName1.Text);
                if (table1 != null)
                {
                    if (table1.Rows.Count > 0)
                    {
                        Password = table1.Rows[0]["Password"].ToString();
                        if (PW1.Text == Password)
                        {
                            User_Id = table1.Rows[0]["User_Id"].ToString();
                            UserCode = table1.Rows[0]["UserCode"].ToString();
                            UserName = table1.Rows[0]["UserName"].ToString();

                            Session["User_Id_admin"] = User_Id;
                            string returnUrl = Request.QueryString["ReturnUrl"];

                            if (!string.IsNullOrEmpty(returnUrl))
                            {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('Đăng nhập thành công'); setTimeout(function(){ window.location.href = returnUrl; }, 0);", true);
                            //trả về href admin

                            }
                            else
                            {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('Đăng nhập thành công'); setTimeout(function(){ window.location.href = '/admin/view/Home.aspx'; }, 0);", true);
                           

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
            DataTable table1 = Model.Dbadmin.checklogin(username);

            if (table1 != null)
            {
                if (table1.Rows.Count > 0)
                {
                    Password = table1.Rows[0]["Password"].ToString();
                    if (Password == PW1.Text)
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