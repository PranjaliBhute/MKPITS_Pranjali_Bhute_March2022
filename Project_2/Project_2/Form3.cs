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
    public partial class Form3 : Form
    {
        public Form3()
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
                qr = "insert into Vendor_mast values(@Vendor_Id,@Vendor_Name)";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Vendor_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                cmd.Parameters.Add("@Vendor_Name", SqlDbType.VarChar).Value = textBox2.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record added successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                display_Vendor_mast();

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
                qr = "update Vendor_mast set Vendor_Name=@Vendor_Name where Vendor_Id=@Vendor_Id";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Vendor_Name", SqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Vendor_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record updated successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                display_Vendor_mast();

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
                qr = "delete from Vendor_mast where Vendor_Id=@Vendor_Id";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Vendor_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record deleted successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                display_Vendor_mast();

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
                qr = "select * from Vendor_mast where Vendor_Id=@Vendor_Id";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Vendor_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                conn.Open();
                int flag = 0;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["Vendor_Name"].ToString();

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

        private void Form3_Load(object sender, EventArgs e)
        {
            display_Vendor_mast();
        }
        public void display_Vendor_mast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Vendor_mast", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Vendor_mast");
                dataGridView1.DataSource = ds.Tables["Vendor_mast"];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
