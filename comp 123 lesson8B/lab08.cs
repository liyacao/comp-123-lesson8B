﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp_123_lesson8B
{
    public partial class outputlable : Form
    {   // classs properties
        public string username { get; set; }
        public float  userage { get; set; }

        public outputlable()
        {

            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lab08_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {
           submitbutton.Enabled 
        }
        /// <summary>
        /// this is the event handler for the submitbutton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitbutton_Click(object sender, EventArgs e)
        {
            username = nametextBox.Text;
           
            userage = float.Parse(agetextbox.Text);
            //option a
            nametextBox.Clear();
            agetextbox.Clear();
            outputlabel.Text=nametextbox.Text+"" 
            // option b
            nametextBox = string.Empty;


        }
        ///this is the event handler for the AGETEXT CHANGE event
    }
}
