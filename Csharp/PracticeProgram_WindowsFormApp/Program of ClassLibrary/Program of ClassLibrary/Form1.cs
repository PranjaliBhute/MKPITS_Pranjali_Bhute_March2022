﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Calculatelibrary;

namespace Program_of_ClassLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate C = new Calculate();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = C.addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Addition = " + r;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = C.substraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Substraction = " + r;
        }

    }
}

