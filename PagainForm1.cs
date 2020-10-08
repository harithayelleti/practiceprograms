﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class PagainForm1 : Form
    {
        public PagainForm1()
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


            //Delegate with Anonymous Method
            b.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("This is Printing!!!");
                
            };
            b.Click += delegate (object sender2, EventArgs e2)
            {
                
                MessageBox.Show("This is Printing again!!!");
            };
        }
    }
}