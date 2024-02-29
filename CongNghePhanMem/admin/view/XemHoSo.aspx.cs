using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.admin.view
{
    public partial class XemHoSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id_admin"] == null)
            {
                // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
                Response.Redirect("~/admin/view/DangNhap.aspx?ReturnUrl=" + Server.UrlEncode(Request.Url.PathAndQuery));
            }
            if (!IsPostBack)
            {
                // Kiểm tra xem Session có tồn tại không
                if (Session["SelectedData_Column2"] != null)
                {
                    // Lấy dữ liệu từ Session
                    string Id = Session["SelectedData_Column2"].ToString();

                    DataTable TimKiemHoSo = Model.Dbadmin.ChiTietHoSo(Id);
                    DataList1.DataSource = TimKiemHoSo;
                    DataList1.DataBind();

                    // Hiển thị dữ liệu trên trang

                    // Xóa Session sau khi sử dụng nếu cần

                }

            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataTable XacNhan = Model.Dbadmin.XacNhan(Session["SelectedData_Column2"].ToString(),TextBox1.Text);
            Response.Redirect("/admin/view/hoso.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable TuChoi = Model.Dbadmin.TuChoi(Session["SelectedData_Column2"].ToString(),TextBox1.Text);
            Response.Redirect("/admin/view/hoso.aspx");
        }
    }
}