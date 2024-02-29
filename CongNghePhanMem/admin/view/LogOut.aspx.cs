using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.admin.view
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["User_Id_admin"] = null;

            // Redirect to the login page or any other desired page
            Response.Redirect("/admin/view/DangNhap.aspx");
        }
    }
}