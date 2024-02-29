using CongNghePhanMem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.admin.view
{
    public partial class CapNhatThongTin : System.Web.UI.Page
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
                    DataTable TinhThanh = Model.ComboBox.tinhThanh();

                    // Gán dữ liệu vào DropDownListxaPhuong
                    DropDownListTinhThanh.DataSource = TinhThanh;
                    DropDownListTinhThanh.DataTextField = "ten";
                    DropDownListTinhThanh.DataValueField = "idx";
                    DropDownListTinhThanh.DataBind();
                    // Lấy thông tin người dùng
                    DataTable GioiTinh = Model.ComboBox.gioiTinh();
                    DropDownListGioiTinh.DataSource = GioiTinh;
                    DropDownListGioiTinh.DataTextField = "fillname";
                    DropDownListGioiTinh.DataValueField = "fillcode";
                    DropDownListGioiTinh.DataBind();
                    DataTable HocVi = Model.ComboBox.hocVi();
                    DropDownListHocVi.DataSource = HocVi;
                    DropDownListHocVi.DataTextField = "hocVi";
                    DropDownListHocVi.DataValueField = "id";
                    DropDownListHocVi.DataBind();
                    DataTable LoadThongTin = Model.Dbadmin.LoadThongTin(Session["User_Id"].ToString());

                    if (LoadThongTin != null && LoadThongTin.Rows.Count > 0)
                    {
                        txtHoVaTen.Text = LoadThongTin.Rows[0]["HoVaTen"].ToString();
                        txtSDT.Text = LoadThongTin.Rows[0]["SDT"].ToString();
                        txtNamsinh.Text = LoadThongTin.Rows[0]["NamSinh"].ToString();

                        // Đặt giá trị cho DropDownListgioiTinh
                        DropDownListGioiTinh.SelectedValue = LoadThongTin.Rows[0]["GioiTinh"].ToString();

                        // Đặt giá trị cho DropDownListhocVi
                        DropDownListHocVi.SelectedValue = LoadThongTin.Rows[0]["HocVi"].ToString();

                        // Đặt giá trị cho DropDownListtinhThanh
                        DropDownListTinhThanh.SelectedValue = LoadThongTin.Rows[0]["TinhThanh"].ToString();

                        // Gọi sự kiện SelectedIndexChanged của DropDownListtinhThanh để cập nhật quận/huyện và xã/phường
                        DropDownListtinhThanh_SelectedIndexChanged(null, EventArgs.Empty);
                    }
                }
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                string hoten = "N'" + txtHoVaTen.Text.Replace("'", "''") + "'";
                string SDT = "N'" + txtSDT.Text.Replace("'", "''") + "'";
                string namsinh = "N'" + txtNamsinh.Text.Replace("'", "''") + "'";
                string tinhThanh = "null";
                if (DropDownListTinhThanh.SelectedItem != null)
                {
                    tinhThanh = DropDownListTinhThanh.SelectedValue.ToString();
                }
                string quanHuyen = "null";
                if (DropDownListQuanHuyen.SelectedItem != null)
                {
                    quanHuyen = DropDownListQuanHuyen.SelectedValue.ToString();
                }
                string xaPhuong = "null";
                if (DropDownListXaPhuong.SelectedItem != null)
                {
                    xaPhuong = DropDownListXaPhuong.SelectedValue.ToString();
                }
                string gioiTinh = "null";
                if (DropDownListGioiTinh.SelectedItem != null)
                {
                    gioiTinh = DropDownListGioiTinh.SelectedValue.ToString();
                }
                string hocVi = "null";
                if (DropDownListHocVi.SelectedItem != null)
                {
                    hocVi = DropDownListHocVi.SelectedValue.ToString();
                }
                string user_id = Session["User_Id"].ToString();
                DataTable UpdateThongtin = Model.Dbadmin.UpdateThongTin(
                        user_id
                        , hoten
                        , SDT
                        , xaPhuong
                        , quanHuyen
                        , tinhThanh
                        , gioiTinh
                        , namsinh
                        , hocVi
                        , "'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "'"
                        , "0"
                    );
                Response.Redirect("LylichCanhan.aspx");

            }
            protected void DropDownListtinhThanh_SelectedIndexChanged(object sender, EventArgs e)
            {

                string tinhThanhId = DropDownListTinhThanh.SelectedValue;

                // Lấy danh sách quận/huyện từ Database
                DataTable quanHuyen = Model.ComboBox.quanHuyen(tinhThanhId);

                // Gán dữ liệu vào DropDownListquanHuyen
                DropDownListQuanHuyen.DataSource = quanHuyen;
                DropDownListQuanHuyen.DataTextField = "ten";
                DropDownListQuanHuyen.DataValueField = "idx";
                DropDownListQuanHuyen.DataBind();

                // Gọi sự kiện SelectedIndexChanged của DropDownListquanHuyen để cập nhật xã/phường
                DropDownListquanHuyen_SelectedIndexChanged(null, EventArgs.Empty);
            }
            protected void DropDownListquanHuyen_SelectedIndexChanged(object sender, EventArgs e)
            {
                string quanHuyenId = DropDownListQuanHuyen.SelectedValue;

                // Lấy danh sách xã/phường từ Database
                DataTable xaPhuong = Model.ComboBox.xaPhuong(quanHuyenId);

                // Gán dữ liệu vào DropDownListxaPhuong
                DropDownListXaPhuong.DataSource = xaPhuong;
                DropDownListXaPhuong.DataTextField = "ten";
                DropDownListXaPhuong.DataValueField = "idx";
                DropDownListXaPhuong.DataBind();
            }

            protected void DropDownListgioiTinh_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            protected void DropDownListhocVi_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            protected void txtSDT_TextChanged(object sender, EventArgs e)
            {

            }


        }
    }
