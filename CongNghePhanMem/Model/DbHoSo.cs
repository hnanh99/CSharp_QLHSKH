using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Drawing;

namespace CongNghePhanMem.Model
{
    
    public class DbHoSo
    {
        public static SqlConnection con = new SqlConnection(ConnetDb.connectionString());
        public static DataTable SelectHoSo(string username)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_002_HoSo @Action = N'SelectHoSo',"
                    + "@Idx = " + username
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
        public static DataTable KThoSo(string id)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_002_HoSo @Action = N'KThoSo',"
                    + "@Idx = " + id
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
        public static DataTable UpdateHoSo(
                   string tieuDe
                   , string tomTat
                   , string tacGia
                   , string link
                   , string noiXB
                   , string namXB
                   , string status
                   , string huy
                   , string id
                   )
                {
                    try
                    {
                        DataTable table1 = new DataTable();
                        SqlCommand cmd_Show = con.CreateCommand();
                        cmd_Show.CommandTimeout = 1;
                        cmd_Show.CommandText = "exec SP_002_HoSo @Action = N'UpdateHoSo',"
                            + "@tieuDe = " + tieuDe + ","
                            + "@tomTat = " + tomTat + ","
                            + "@tacGia = " + tacGia + ","
                            + "@link = " + link + ","
                            + "@noiXB = " + noiXB + ","
                            + "@namXB = " + namXB + ","
                            + "@status = " + status + ","
                            + "@huy = " + huy + ","
                              + "@Idx = " + id
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
        public static DataTable DelectHoSo(string _Id)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_002_HoSo @Action = N'DelectHoSo'," 
                    +"@Idx ="  + _Id
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
        public static DataTable ThemHoSo(
              string tieuDe
            , string tomTat
            , string tacGia
            , string link
            , string noiXB
            , string namXB
            , string status 
            , string huy
            , string nguoiTao
            )
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_002_HoSo @Action = N'InsertHoSo', "
                    + "@tieuDe = " + tieuDe + ","
                    + "@tomTat = " + tomTat + ","
                    + "@tacGia = " + tacGia + ","
                    + "@link = " + link + ","
                    + "@noiXB = " + noiXB + ","
                    + "@namXB = " + namXB + ","
                    + "@status = " + status + ","
                    + "@huy = " + huy + ","
                    + "@nguoiTao = " + nguoiTao
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
        public static DataTable LoadHoSo(string _Id)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_002_HoSo @Action = N'LoadHoSo',"
                    + "@Idx = " + _Id
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
        public static DataTable TimKiemHoSo(
            string tieuDe
            , string tacGia)
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_002_HoSo @Action = N'TimKiemHoSo',"
                    + "@tieuDe = " + tieuDe + ","
                    + "@tacGia = " + tacGia
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
        public static DataTable SelectThongtin(
              string id
            )
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_002_HoSo @Action = N'selectThongtin', "
                    + "@idx = " + id
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
        public static DataTable SelectHS(
              string id
            )
        {
            try
            {
                DataTable table1 = new DataTable();
                SqlCommand cmd_Show = con.CreateCommand();
                cmd_Show.CommandTimeout = 1;
                cmd_Show.CommandText = "exec SP_002_HoSo @Action = N'selectHS', "
                    + "@idx = " + id
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