﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemanagemetdemoonweb
{
    public partial class gethiddenfieldvalues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Request.Form["hfcount1"];
            Response.Write("Your current hit count is:" + value);
        }
    }
}