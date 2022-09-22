using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_2_dimention_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] album = new string[1,2];
        StringBuilder sb = new StringBuilder();

        private void button1_Click(object sender, EventArgs e)
        {
            album[0,0] = textBox1.Text;
            album[0,1] = textBox2.Text;
            sb.Append("Album name : " + album[0, 0] + " and Singer name : " + album[0, 1]);
            label3.Text = sb.ToString();
        }
    }
}
