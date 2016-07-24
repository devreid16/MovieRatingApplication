﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterSample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SiteMapPath sp = (SiteMapPath)Master.FindControl("SiteMapPath1");
            sp.Visible = (SiteMap.CurrentNode != SiteMap.RootNode);
        }
    }
}