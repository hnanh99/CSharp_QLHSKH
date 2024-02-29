using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.view
{
    public partial class TimKiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id"] == null)
            {
                // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
                Response.Redirect("~/Login.aspx?ReturnUrl=" + Server.UrlEncode(Request.Url.PathAndQuery));
            }

        }
        protected void TimKiem_Click(object sender, EventArgs e)
        {
            string tieuDe = "N'" + txttieuDe.Text.Replace("'", "''") + "'";
            string tacGia = "N'" + txttacGia.Text.Replace("'", "''") + "'";
            DataTable TimKiemHoSo = Model.DbHoSo.TimKiemHoSo(tieuDe,tacGia);
            DataList1.DataSource = TimKiemHoSo;
            DataList1.DataBind();
        }
        protected void Lylich_Click(object sender, EventArgs e)
        {

            string a = ((LinkButton)sender).CommandArgument.ToString();
            Session["a"] = a;
            Response.Redirect("~/view/Lylich.aspx");
        }
    }
}