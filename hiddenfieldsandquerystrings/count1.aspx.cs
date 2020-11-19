using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HiddenFields
{
    public partial class count1 : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HiddenField1.Value == String.Empty)
                HiddenField1.Value = "4";
            HiddenField1.Value = (Convert.ToInt32(HiddenField1.Value) + 1).ToString();
            Label2.Text = HiddenField1.Value;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HiddenField.Value = "Haritha";
            Label2.Text = HiddenField.Value;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}