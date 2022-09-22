using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_of_MDI_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resistorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform r = new registerform();
            r.MdiParent = this;
            r.Show();

        }
        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent = this;
            a.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform r = new registerform();
            r.MdiParent = this;
            r.Show();

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent = this;
            a.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
