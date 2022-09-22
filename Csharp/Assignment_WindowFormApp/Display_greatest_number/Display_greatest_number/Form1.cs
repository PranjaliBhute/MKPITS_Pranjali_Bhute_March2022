using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_greatest_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int n3 = Convert.ToInt32(textBox3.Text);
            if (n1 > n2 && n1 > n3)
            {
                label4.Text = "n1 is greater number.";
            }
            else
            if (n2 > n1 && n2 > n3)
            {
                label4.Text = "n2 is greater number.";
            }
            else
            {
                label4.Text = "n3 is greater number.";
            }

        }
    }
}
