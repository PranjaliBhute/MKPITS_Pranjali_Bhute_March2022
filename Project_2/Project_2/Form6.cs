using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("server =HP-LAPTOP\\SQLEXPRESS;integrated security=true;database=Project_2");
        SqlCommand cmd = null;
        string qr = null;

        public int user_id = 0;
        public void Access_id()
        {
            try
            {
                SqlConnection connection = new SqlConnection("server =HP-LAPTOP\\SQLEXPRESS;integrated security=true;database=Project_2");
                qr = "select id from Users_Details where username='" + textBox1.Text + "'";
                cmd = new SqlCommand(qr, connection);
                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    user_id = Convert.ToInt32(dr["id"].ToString());
                }
                MessageBox.Show("user_id" + user_id);
                dr.Close();
                connection.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                qr = "select count(*) from Users_Details where username=@username and password=@password";
                cmd = new SqlCommand(qr, connection);
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = textBox2.Text;
                connection.Open();
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (cnt > 0)
                {
                    label3.Text = "Login successfull";
                    panel1.Visible = false;
                    menuStrip1.Visible = true;
                    Access_id();

                }
                else
                {
                    label3.Text = "Invalid credential,try again";
                }

            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void departmentmastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void departmentmastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void vendormastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.Show();
        }
    }
}
