﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resolution_Grabber.src
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "check resolution")
            {
                textBox1.Enabled = false;
                button1.Text = "stop";
            } else
            {
                textBox1.Enabled = true;
                button1.Text = "check resolution";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}