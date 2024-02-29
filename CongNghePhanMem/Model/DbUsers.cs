using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace CongNghePhanMem.Model
{
    public class DbUsers
    {
        public static SqlConnection con = new SqlConnection(ConnetDb.connectionString());
        public static DataTable checklogin(string _username)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_001_Users @UserCode = N'" + _username + "',@Action = N'CheckLogin'";
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
                cmd_Show.CommandText = "exec SP_001_Users @UserCode = N'" + _username + "',@Action = N'LoadThongTin'";
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
        public static DataTable InsertUser(
              string _Email 
            , string _HoVaTen
            , string _Password
            , string _SoDienThoai
            ,string _XaPhuong
            ,string _QuanHuyen
            , string _TinhThanh
            
            , string _GioiTinh
            , string _NamSinh
            ,string _HocVi
            , string _NgayTao
            , string _NgayCapNhat
            , string _Huy

            )
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_001_Users @Action = N'InsertUser', "
                    + "@Email = " + _Email + ","
                    + "@HoVaTen = " + _HoVaTen + ","
                    + "@Password = " + _Password + ","
                    + "@SoDienThoai = " + _SoDienThoai + ","
                    + "@XaPhuong = " + _XaPhuong + ","
                    + "@QuanHuyen = " + _QuanHuyen + ","
                    + "@TinhThanh = " + _TinhThanh + ","
                    + "@GioiTinh = " + _GioiTinh + ","
                    + "@NamSinh = " + _NamSinh + ","
                    + "@HocVi = " + _HocVi + ","
                     + "@NgayTao = " + _NgayTao + ","
                    + "@NgayCapNhat = " + _NgayCapNhat + ","
                    + "@Huy = " + _Huy

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
         public static DataTable checkEmail(string email)
                {
                    try
                    {
                        DataTable table1 = new DataTable();
                        SqlCommand cmd_Show = con.CreateCommand();
                        cmd_Show.CommandTimeout = 1;
                        cmd_Show.CommandText = "exec SP_001_Users @Text = N'" + email + "',@Action = N'CheckEmail'";
                        con.Open();
                        table1.Load(cmd_Show.ExecuteReader(CommandBehavior.CloseConnection));
                        con.Close();
                        return table1;
                    }
                    catch(Exception ex)
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
                cmd_Show.CommandText = "exec SP_001_Users @Action=N'CheckChangePassword',"
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
                cmd_Show.CommandText = "exec SP_001_Users @Action=N'ChangePassword',"
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
    }
}