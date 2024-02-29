using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.view
{
    public partial class SuaHoSo : System.Web.UI.Page
    {
        public string Id;
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
                    DataTable LoadHoSo = Model.DbHoSo.LoadHoSo(Id);
                    {
                        if (LoadHoSo == null)
                        {
                            return;
                        }
                        if (LoadHoSo.Rows.Count > 0)
                        {
                            if (LoadHoSo.Rows[0]["status"].ToString() == "0" ||( LoadHoSo.Rows[0]["status"].ToString() == "1" && LoadHoSo.Rows[0]["Huy"].ToString() == "0"))
                            {
                                txtTieuDe.Text = LoadHoSo.Rows[0]["tieuDe"].ToString();
                                txtTomTat.Text = LoadHoSo.Rows[0]["tomTat"].ToString();
                                txtTacGia.Text = LoadHoSo.Rows[0]["tacGia"].ToString();
                                txtNoiXB.Text = LoadHoSo.Rows[0]["noiXB"].ToString();
                                txtNamXB.Text = LoadHoSo.Rows[0]["namXB"].ToString();
                                txtLink.Text = LoadHoSo.Rows[0]["Link"].ToString();
                            }
                            else
                            {
                                Response.Redirect("~/view/HoSo.aspx");
                            }
                        }
                    }



                    // Hiển thị dữ liệu trên trang

                    // Xóa Session sau khi sử dụng nếu cần

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string Id = Session["SelectedData_Column1"].ToString();
            DataTable LoadHoSo = Model.DbHoSo.LoadHoSo(Id);
            string TieuDe = "N'" + txtTieuDe.Text.Replace("'", "''") + "'";
            string TomTat = "N'" + txtTomTat.Text.Replace("'", "''") + "'";
            string TacGia = "N'" + txtTacGia.Text.Replace("'", "''") + "'";
            string NoiXuatBan = "N'" + txtNoiXB.Text.Replace("'", "''") + "'";
            string NamXuatBan = "N'" + txtNamXB.Text.Replace("'", "''") + "'";
            string Link = "N'" + txtLink.Text.Replace("'", "''") + "'";

            DataTable updateHoSo = Model.DbHoSo.UpdateHoSo(
                TieuDe,
                TomTat,
                TacGia,
                Link, NoiXuatBan,
                NamXuatBan,
                "0",
                "0",
                Id

                );
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "alert('Cập nhật thành công'); setTimeout(function(){ window.location.href = '/view/HoSo.aspx'; }, 0);", true);
            


        }
    }
}