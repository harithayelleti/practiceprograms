using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class cookiecollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Setting Expiry Date and time of the cookie
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label2.Text = "Please select your choice:";
            //Adding cookies
            
            if (CheckBox1.Checked)
            
                Response.Cookies["computer"]["Iphone"]="u have checked iphone and computer";
            
            if (CheckBox2.Checked)
            
                Response.Cookies["computer"]["Honor"] = "u have checked Honor and computer";
            
            if (CheckBox3.Checked)
            
                Response.Cookies["computer"]["Oneplus"] = "u have checked Oneplus and computer";
            
            if (CheckBox4.Checked)
            
                Response.Cookies["computer"]["Realme"] = "u have checked Realme and computer";
            
            if (CheckBox5.Checked)
            
                Response.Cookies["computer"]["Samsung"] = "u have checked Samsung and computer";
            
            if (CheckBox6.Checked)
            
                Response.Cookies["computer"]["Vivo"] = "u have checked Vivo and computer";
            
            if (CheckBox7.Checked)
            
                Response.Cookies["computer"]["Poco"] = "u have checked Poco and computer";
            
            if (CheckBox8.Checked)
            
                Response.Cookies["computer"]["Asus"] = "u have checked Asus and computer";
            
            if (CheckBox9.Checked)
            
                Response.Cookies["computer"]["Lenovo"] = "u have checked Lenovo and computer";
            
            if (CheckBox10.Checked)
            
                Response.Cookies["computer"]["Mi"] = "u have checked MI and computer";
            
            //fetching cookies
            if (Request.Cookies["computer"].Values.ToString()!=null)
            {
                if (Request.Cookies["computer"]["Iphone"] != null)
                    Label2.Text = Label2.Text+Response.Cookies["computer"]["Iphone"] + "" + "";
                if (Request.Cookies["computer"]["Honor"] != null)
                    Label2.Text = Label2.Text + Response.Cookies["computer"]["Honor"] + "" + "";
                if (Request.Cookies["computer"]["Oneplus"] != null)
                    Label2.Text = Label2.Text + Response.Cookies["computer"]["Oneplus"] + "" + "";
                if (Request.Cookies["computer"]["Realme"] != null)
                    Label2.Text = Label2.Text + Response.Cookies["computer"]["Realme"] + "" + "";
                if (Request.Cookies["computer"]["Samsung"] != null)
                    Label2.Text = Label2.Text + Response.Cookies["computer"]["Samsung"] + "" + "";
                if (Request.Cookies["computer"]["Vivo"] != null)
                    Label2.Text = Label2.Text + Response.Cookies["computer"]["Vivo"] + "" + "";
                if (Request.Cookies["computer"]["Poco"] != null)
                    Label2.Text = Label2.Text + Response.Cookies["computer"]["Poco"] + "" + "";
                if (Request.Cookies["computer"]["Asus"] != null)
                    Label2.Text = Label2.Text + Response.Cookies["computer"]["Asus"] + "" + "";
                if (Request.Cookies["computer"]["Lenovo"] != null)
                    Label2.Text = Label2.Text + Response.Cookies["computer"]["Lenovo"] + "" + "";
                if (Request.Cookies["computer"]["Mi"] != null)
                    Label2.Text = Label2.Text + Response.Cookies["computer"]["Mi"] + "" + "";
            }
            else
            {
                Label2.Text = "Select any choice";
                Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);

            }
        }
    }
}