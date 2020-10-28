using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class registration : System.Web.UI.Page
    {
        protected System.Web.UI.HtmlControls.HtmlInputFile File1;
        protected System.Web.UI.HtmlControls.HtmlInputButton Register;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Username.Text = "";
            //Emailaddress.Text = "";


            message.Text = "Hello" + Username.Text + "Good Afternoon!!!!!!";
            //Label1.Text = "Hello" + Username.Text + "Good Afternoon!!!!!!";
            message.Text = message.Text + "<br/> you have sucessfully Registered with the following features";


            ShowUserName.Text = "<br/>"+ "USername:" + " " + Username.Text;
            ShowEmailAddress.Text = "<br/>" + "Email:" + " " + Emailaddress.Text;

            if (RadioButton1.Checked)
               ShowGender.Text = "<br/>"+ "Gender:" + " " + RadioButton1.Text + " ";
              
            else
                ShowGender.Text ="<br/>" +"Gender:"+ " " + RadioButton2.Text + " ";

            var Courses = " ";
            if (CheckBox1.Checked)
                Courses += CheckBox1.Text + "" + "";
            if (CheckBox2.Checked)
                Courses += CheckBox2.Text + "" + "";
            if (CheckBox3.Checked)
                Courses += CheckBox3.Text + "" + "";
            if (CheckBox4.Checked)
                Courses += CheckBox4.Text + "" + "";
            if (CheckBox5.Checked)
                Courses += CheckBox5.Text + " " + " ";
            if (CheckBox6.Checked)
                Courses += CheckBox6.Text + " " + " ";

            ShowCourses.Text = "<br/>" + "Courses:"+" "+Courses;   
            //ShowUsernameLabel.Text =  "Username";
            //ShowEmailAddressLabel.Text = "EmailAddress";
            //ShowGenderLabel.Text =  "Gender";
            //ShowCoursesLabel.Text = "Courses";
            

            RadioButton1.Checked = false;
            RadioButton2.Checked = false;

            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;
            CheckBox6.Checked = false;




        }
    }
}