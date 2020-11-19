using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HiddenFields
{
    public partial class pageform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Request.Form["HiddenField1"];
            Response.Write("your current hit count is :" + value);
        }
    }
}