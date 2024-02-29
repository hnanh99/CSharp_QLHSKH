using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;
using System.Data;

namespace CongNghePhanMem.view
{
    public partial class ThemHoSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id"] == null)
            {
                // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
                Response.Redirect("~/Login.aspx?ReturnUrl=" + Server.UrlEncode(Request.Url.PathAndQuery));
            }
        }
        protected void Submit(object sender, EventArgs e)
        {
            
            string tieuDe = "N'" + txtTieuDe.Text.Replace("'", "''") + "'";
            string tomTat = "N'" + txtTomTat.Text.Replace("'", "''") + "'";
            string tacGia = "N'" + txtTacGia.Text.Replace("'", "''") + "'";
            string link = "N'" + txtLink.Text.Replace("'", "''") + "'";
            string noiXB = "N'" + txtNoiXB.Text.Replace("'", "''") + "'";
            string namXB = "N'" + txtNamXB.Text.Replace("'", "''") + "'";
            DataTable Insert = Model.DbHoSo.ThemHoSo(
                        tieuDe
                    , tomTat
                    , tacGia
                    , link
                    , noiXB
                    , namXB
                    , "0"
                    , "0"
                    , Session["User_Id"].ToString()
                    );
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('Thêm mới bài báo thành công'); setTimeout(function(){ window.location.href = '/view/HoSo.aspx'; }, 0);", true);
            //Response.Redirect("~/view/HoSo.aspx");
            
        }
    }
}