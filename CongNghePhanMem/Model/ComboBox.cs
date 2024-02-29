using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace CongNghePhanMem.Model
{
    public class ComboBox
    {
        public static SqlConnection con = new SqlConnection(ConnetDb.connectionString());
        public static DataTable xaPhuong(string t)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_003_DMHC @Action = N'xaPhuong',"
                    + "@Text =" + t;
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
        public static DataTable quanHuyen(string t)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_003_DMHC @Action = N'quanHuyen',"
                    + "@Text =" + t;
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
        public static DataTable tinhThanh()
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_003_DMHC @Action = N'tinhThanh'";
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
        public static DataTable gioiTinh()
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_003_DMHC @Action = N'gioiTinh'";
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
        public static DataTable hocVi()
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_003_DMHC @Action = N'hocVi'";
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
            ,  string _HoVaTen
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
    }
}