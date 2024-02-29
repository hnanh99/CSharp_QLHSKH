using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.view
{
    public partial class DoiMatKhau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id"] == null)
            {
                // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
                Response.Redirect("~/Login.aspx?ReturnUrl=" + Server.UrlEncode(Request.Url.PathAndQuery));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtPW.Text == "")
            {
                
            }
            else if (txtMKmoi.Text == "")
            {
                
            }
            else if (txtXN.Text == "")
            {
              
            }
            else
            {
                DataTable CheckChangePassword = Model.DbUsers.CheckChangePassword(Login.User_Id);
                if (CheckChangePassword != null)
                {
                    if (CheckChangePassword.Rows.Count > 0)
                    {
                        if (CheckChangePassword.Rows[0]["_Password"].ToString() == txtPW.Text)
                        {
                            if (txtMKmoi.Text == txtXN.Text)
                            {
                                DataTable ChangePassword = Model.DbUsers.ChangePassword(Login.User_Id, txtMKmoi.Text);
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('Đổi mật khẩu thành công'); setTimeout(function(){ window.location.href = '/Default.aspx'; }, 0);", true);


                            }
                            else
                            {
                               
                            }
                        }
                        else
                        {
                           
                        }
                    }
                }
            }
        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool isValid = false;

            string PW = args.Value;
            DataTable CheckChangePassword = Model.DbUsers.CheckChangePassword(Login.User_Id);
            if (CheckChangePassword != null)
            {
                if (CheckChangePassword.Rows.Count > 0)
                {
                    if (CheckChangePassword.Rows[0]["_Password"].ToString() == txtPW.Text)
                    {
                        if (txtMKmoi.Text == txtXN.Text)
                        {
                            DataTable ChangePassword = Model.DbUsers.ChangePassword(Login.User_Id, txtMKmoi.Text);
                            isValid = true;

                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
            }
           
            args.IsValid = isValid;//false là báo lỗi
        }
    }
}