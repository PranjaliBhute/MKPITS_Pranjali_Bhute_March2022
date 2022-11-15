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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("server =HP-LAPTOP\\SQLEXPRESS;integrated security=true;database=Project_2");
        SqlCommand cmd = null;
        string qr = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    if (textBox2.Text == textBox3.Text && textBox2.Text != "")
                    {
                        qr = "insert into Users_Details values(@username,@password)";
                        cmd = new SqlCommand(qr, connection);
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = textBox2.Text;
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successfull, go to login button");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Password not matched");
                    }
                }
                else
                {
                    MessageBox.Show("Username must not be empty");
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
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }
    }
}
