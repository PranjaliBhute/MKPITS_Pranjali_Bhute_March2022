using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnitherExWithRuntimePolymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account act = null;
        private void button1_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string str = act.deposit(Convert.ToInt32(textBox2.Text));
            label4.Text = str;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string str = act.withdrawl(Convert.ToInt32(textBox2.Text));
            label4.Text = str;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string str = act.showbalance();
            label4.Text = "Account no = " + act.accountno + " and " + str;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Saving")
            {
                act = new Saving();
            }
            else if (comboBox1.Text == "Current")
            {
                act = new Current();
            }
        }
    }       

}
