using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class genraltech : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox2.Focus(); 

    }

    protected void button1_Click(object sender, EventArgs e)
    {
        string unique = "Hello" + TextBox2.Text + "This is Asp.Net Framework";
        Response.Write(unique);
        
    }



    protected void rdnred_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is ASP.Net Webform which is in red");
    }

    protected void rdnblue_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is ASP.Net Webform which is in blue");
    }

    protected void rdngreen_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is ASP.Net Webform which is in green");
    }



    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}