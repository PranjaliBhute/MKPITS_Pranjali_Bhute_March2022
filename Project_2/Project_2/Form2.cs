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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
        SqlCommand cmd = null;
        string qr = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                qr = "insert into Department_mast values(@Department_Id,@Department_Name)";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Department_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                cmd.Parameters.Add("@Department_Name", SqlDbType.VarChar).Value = textBox2.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record added successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                display_Department_mast();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                qr = "update Department_mast set Department_Name=@Department_Name where Department_Id=@Department_Id";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Department_Name", SqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Department_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record updated successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                display_Department_mast();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                qr = "delete from Department_mast where Department_Id=@Department_Id";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Department_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record deleted successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                display_Department_mast();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                qr = "select * from Department_mast where Department_Id=@Department_Id";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Department_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                conn.Open();
                int flag = 0;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["Department_Name"].ToString();

                }
                if (flag == 0)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                    MessageBox.Show("No record found");
                }
                dr.Close();
                conn.Close();
                MessageBox.Show("Record search successfully");
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            display_Department_mast();
        }
        public void display_Department_mast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Department_mast", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Department_mast");
                dataGridView1.DataSource = ds.Tables["Department_mast"];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
