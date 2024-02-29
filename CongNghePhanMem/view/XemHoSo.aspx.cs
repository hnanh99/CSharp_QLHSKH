using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.view
{
    public partial class XemHoSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id"] == null)
            {
                // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
                Response.Redirect("~/Login.aspx?ReturnUrl=" + Server.UrlEncode(Request.Url.PathAndQuery));
            }
            if (!IsPostBack)
            {
                // Kiểm tra xem Session có tồn tại không
                if (Session["SelectedData_Column1"] != null)
                {
                    // Lấy dữ liệu từ Session
                    string Id = Session["SelectedData_Column1"].ToString();


                    // Hiển thị dữ liệu trên trang

                    // Xóa Session sau khi sử dụng nếu cần

                }

            }
        }
    }
}