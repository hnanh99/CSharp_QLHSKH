using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
namespace CongNghePhanMem.Model
{
    public class Dbadmin
    {
        public static SqlConnection con = new SqlConnection(ConnetDb.connectionString());
        public static DataTable checklogin(string _username)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_004_admin @UserCode = N'" + _username + "',@Action = N'CheckLogin'";
                con.Open();
                table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                con.Close();
                return table1;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable ChiTietHoSo(
           string Id
           )
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_004_admin @Action = N'TimKiemHoSo',"
                    + "@Idx = " + Id 
                   
                    ;
                con.Open();
                table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                con.Close();
                return table1;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable SelectHoSo()
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_004_admin @Action = N'SelectHoSo'";
                con.Open();
                table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                con.Close();
                return table1;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable XacNhan(
          string Id,
          string Nhanxet
          )
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_004_admin @Action = N'XacNhan',"
                    + "@Idx = " + Id + ","
                    +"@NhanXet = N'" + Nhanxet + "'"

                    ;
                con.Open();
                table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                con.Close();
                return table1;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable TuChoi(
          string Id
            , string Nhanxet
          )
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_004_admin @Action = N'TuChoi',"
                    + "@Idx = " + Id + ","
                    + "@NhanXet = N'" + Nhanxet + "'"

                    ;
                con.Open();
                table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                con.Close();
                return table1;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable CheckChangePassword(string _User_Id)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_004_admin @Action=N'CheckChangePassword',"
                    + "@User_Id =" + _User_Id
                    ;
                con.Open();
                table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                con.Close();
                return table1;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable ChangePassword(string _User_Id, string _Password)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_004_admin @Action=N'ChangePassword',"
                    + "@User_Id =" + _User_Id + ","
                    + "@Password =N'" + _Password
                    ;
                con.Open();
                table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                con.Close();
                return table1;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable UpdateThongTin(
           string id
           , string _HoVaTen
           , string _SoDienThoai
           , string _XaPhuong
           , string _QuanHuyen
           , string _TinhThanh

           , string _GioiTinh
           , string _NamSinh
           , string _HocVi,
           string _NgayCapNhat
           , string status
           )
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_003_DMHC @Action = N'UpdateThongTin',"
                    + "@IDx = " + id + ","
                    + "@HoVaTen = " + _HoVaTen + ","
                    + "@SoDienThoai = " + _SoDienThoai + ","
                    + "@XaPhuong = " + _XaPhuong + ","
                    + "@QuanHuyen = " + _QuanHuyen + ","
                    + "@TinhThanh = " + _TinhThanh + ","
                    + "@GioiTinh = " + _GioiTinh + ","
                    + "@NamSinh = " + _NamSinh + ","
                    + "@HocVi = " + _HocVi + ","
                    + "@NgayCapNhat = " + _NgayCapNhat + ","
                    + "@Status = " + status
                    ;
                con.Open();
                table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                con.Close();
                return table1;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable LoadThongTin(string _username)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_004_admin @UserCode = N'" + _username + "',@Action = N'LoadThongTin'";
                con.Open();
                table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                con.Close();
                return table1;
            }
            catch
            {
                return null;
            }
        }
    }
}