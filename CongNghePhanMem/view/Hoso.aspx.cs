using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.view
{
    
    public partial class Hoso : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id"] == null)
            {
                // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
                Response.Redirect("~/Login.aspx?ReturnUrl=" + Server.UrlEncode(Request.Url.PathAndQuery));
            }
            DataTable SelectHoSo = Model.DbHoSo.SelectHoSo(Session["User_Id"].ToString());
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
                string  idValue = GridView1.Rows[selectedIndex].Cells[1].Text;
               
                if (!string.IsNullOrEmpty(idValue))
                {
                    // Store the data in Session
                    Session["SelectedData_Column1"] = idValue;
                    
                }

            }
            else
            {
                Session["SelectedData_Column1"] = "";
            }

        }



        protected void btnThem_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/view/ThemHoSo.aspx");
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            GridView1_SelectedIndexChanged(GridView1, EventArgs.Empty);
            if (Session["SelectedData_Column1"].ToString()!="")
            {
                DataTable KT = Model.DbHoSo.KThoSo(Session["SelectedData_Column1"].ToString());

                if (KT.Rows[0]["Status"].ToString() != "1")
                {
                    Response.Redirect("~/view/SuaHoSo.aspx");
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alerMessage", "alert('Hồ Sơ đã được duyệt, không thể sửa')", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alerMessage", "alert('Vui lòng chọn hồ sơ')", true);
                return;
            }
        }

        //protected void btnChiTiet_Click(object sender, EventArgs e)
        //{
        //    //Response.Redirect("~/view/XemHoSo.aspx");
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1_SelectedIndexChanged(GridView1, EventArgs.Empty);
            string Id = Session["SelectedData_Column1"].ToString();
            if (Id != null)
            {
                DataTable KT = Model.DbHoSo.KThoSo(Id);

                if (KT.Rows[0]["Status"].ToString() != "1")
                {
                    DataTable DelectHoSo = Model.DbHoSo.DelectHoSo(Id);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alerMessage", "alert('Xóa bài báo thành công')", true);
                }
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