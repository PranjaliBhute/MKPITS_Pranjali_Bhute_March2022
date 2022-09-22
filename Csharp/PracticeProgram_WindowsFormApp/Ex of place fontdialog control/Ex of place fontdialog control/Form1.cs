using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_of_place_fontdialog_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

    }
}
