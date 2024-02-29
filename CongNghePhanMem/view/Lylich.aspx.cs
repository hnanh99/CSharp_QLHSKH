using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.view
{
    public partial class Lylich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id"] == null)
            {
                // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
                Response.Redirect("~/Login.aspx?ReturnUrl=" + Server.UrlEncode(Request.Url.PathAndQuery));
            }
            string id=Session["a"].ToString();
            DataTable selectThongtin = Model.DbHoSo.SelectThongtin(id);
            HoVaTen.Text = selectThongtin.Rows[0]["HoVaTen"].ToString();
            SoDienThoai.Text = selectThongtin.Rows[0]["SoDienThoai"].ToString();
            GioiTinh.Text = selectThongtin.Rows[0]["GioiTinh"].ToString();
            NamSinh.Text = selectThongtin.Rows[0]["NamSinh"].ToString();
            HoVaTen.Text = selectThongtin.Rows[0]["HoVaTen"].ToString();
            QueQuan.Text = selectThongtin.Rows[0]["QueQuan"].ToString();
            Email.Text = selectThongtin.Rows[0]["Email"].ToString();
            HocVi.Text = selectThongtin.Rows[0]["HocVi"].ToString();
            DataTable selectHS = Model.DbHoSo.SelectHS(id);
            DataList1.DataSource = selectHS;
            DataList1.DataBind();
        }
    }
}