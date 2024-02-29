using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CongNghePhanMem.admin.view
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id_admin"] == null)
            {
                personalNavItem.Visible = false;
            }
            else
            {
                personalNavItem.Visible = true;
            }

        }
    }
}