using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CongNghePhanMem
{
    public class ConnetDb
    {
        internal static string connectionString()
        {
            //string connectionString = @"Data Source=MSI;Initial Catalog=Science_Profile_Management;User ID=sa;Password=123";
            string connectionString = @"Data Source=DESKTOP-F9R90SK;Initial Catalog=Science_Profile_Management;User ID=sa;Password=123456";
            return connectionString;
        }
    }
}