using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.admin.view
{
    public partial class Hoso : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id_admin"] == null)
            {
                // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
                Response.Redirect("~/admin/view/DangNhap.aspx?ReturnUrl=" + Server.UrlEncode(Request.Url.PathAndQuery));
            }
            DataTable SelectHoSo = Model.Dbadmin.SelectHoSo();
            GridView1.DataSource = SelectHoSo;
            GridView1.DataBind();
            /*DataList1.DataSource = SelectHoSo;
            DataList1.DataBind();*/
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (GridView1.SelectedIndex >= 0 && GridView1.SelectedIndex < GridView1.Rows.Count)
            {
                int selectedIndex = GridView1.SelectedIndex;
                // Assuming "ID" is the name of the data key specified in DataKeyNames
                string idValue = GridView1.Rows[selectedIndex].Cells[1].Text;

                if (!string.IsNullOrEmpty(idValue))
                {
                    // Store the data in Session
                    Session["SelectedData_Column2"] = idValue;
                }
                else
                {
                    // Handle the case where the data key is not found or is null
                    // You might want to log or display an error message.
                }
            }

        }




        protected void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (Session["SelectedData_Column2"].ToString() != null)
            {
                Response.Redirect("/admin/view/XemHoSo.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alerMessage", "alert('Vui lòng chọn hồ sơ')", true);
                return;
            }
        }
        /*protected void TimKiemClick(object sender, EventArgs e)
        {
            string a = ((LinkButton)sender).CommandArgument.ToString();
            Response.Redirect("~/view/ThemHoSo.aspx");
        }*/
    }
}