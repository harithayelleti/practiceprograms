using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class DropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue=="")
            {
                Label1.Text = "Please Select a city";
                
            }
            else
            {
                Label1.Text = "Your choice is" + DropDownList1.SelectedValue;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedValue == "")
            {
                Label1.Text = "Please Select your fav food";

            }
            else
            {
                Label1.Text = "Your choice is" + DropDownList2.SelectedValue;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text == "P@ssword")
            {
                //Storing an email to te session
                Session["email"] = Email.Text;
                Session["mobile"] = Email.Text;
                
            }
            //Checking  if session variable is empty
            if (Session["email"] != null)
            {
                //Display the stored email
                Label1.Text = "This email is stored in the session";
                Label2.Text = Session["email"].ToString();
            }
        }
    }
}