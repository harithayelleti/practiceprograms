﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net
{
    public partial class oncommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("Ordered Jumpsuit from sasfarass");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Write("Ordered Jumpsuit from sasfarasss");
        }
    }
}