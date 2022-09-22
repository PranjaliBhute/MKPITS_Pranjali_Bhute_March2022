using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_using_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bsal = Convert.ToInt32(textBox2.Text);
            float bonus = bsal * 0.40f;
            float totalsal = bsal + bonus;
            label1.Text = "";
            label2.Text = "";
            if (checkBox1.Checked)
                label1.Text = "Bonus = " + bonus;
            if (checkBox2.Checked)
                label2.Text = "Total salary = " + totalsal;
        }
    }
}
