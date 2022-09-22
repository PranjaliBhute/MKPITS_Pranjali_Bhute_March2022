using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empname = textBox1.Text;
            int bsal = Convert.ToInt32(textBox2.Text);
            string desig = textBox3.Text;
            float hra = 0;
            float bonus = 0;
            float totalsal = 0;
            switch (desig)
            {
                case "Manager":
                    hra = bsal * 0.35f;
                    bonus = bsal * 0.5f;
                    break;
                case "Clerk":
                    hra = bsal * 0.25f;
                    bonus = bsal * 0.3f;
                    break;
                case "Peon":
                    hra = bsal * 0.15f;
                    bonus = bsal * 0.2f;
                    break;

            }
            label4.Text = "Hra = " + hra;
            label5.Text = "Bonus = " + bonus;
            totalsal = hra + bonus + bsal;
            label6.Text = "Total salary = " + totalsal;
        }
    }
}
