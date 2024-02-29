﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id"]==null)
            {
                personalNavItem.Visible = false;
            }    
            else
            {
                userLink.InnerText = Login.UserName;
                personalNavItem.Visible = true;
            }    
        }
    }
}