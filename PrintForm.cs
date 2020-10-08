using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windoesprint
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();//refence created to button
            b.Text = "Click here First";//Text implemented as "Click here first" on the button appearance
            b.Size = new Size(100, 50);//Size mentoined for the button
            b.Location = new Point(150, 150);//point located on the button created 
            this.Controls.Add(b);//Controls mechanism of button should go the center

            //Show the Message
            //b.Click += new EventHandler(button1_Click1);

            //Delegate with Anonymous Method
            b.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("This is Printing!!!");
            };
            //(line no 42)-Initalization component

            //this.button1.Click += new System.EventHandler(this.button1_click);//Delegate been created
        }
        //Method creation
        /*private void button1_Click1(object sender1, EventArgs e1)
        {

            MessageBox.Show("This is Printing!!!!");
        }*/
    }
}

