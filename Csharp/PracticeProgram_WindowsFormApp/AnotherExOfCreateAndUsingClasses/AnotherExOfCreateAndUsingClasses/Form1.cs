using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherExOfCreateAndUsingClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bank b = new Bank();
        private void button1_Click(object sender, EventArgs e)
        {
            b.accountno = Convert.ToInt32(textBox1.Text);
            string str = b.deposit(Convert.ToInt32(textBox2.Text));
            label3.Text = str;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            b.accountno = Convert.ToInt32(textBox1.Text);
            string str = b.withdrawl(Convert.ToInt32(textBox2.Text));
            label3.Text = str;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            b.accountno = Convert.ToInt32(textBox1.Text);
            string str = b.showbalance();
            label3.Text = "Account no = " + b.accountno + "\n" + str;

        }
    }
}
