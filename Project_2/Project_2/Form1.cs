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
    public partial class Form1 : Form
    {
        public Form1()
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
                qr = "insert into Item_master values(@Item_Id,@Item_Name,@Category,@Rate,@Balance_Quantity)";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Item_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                cmd.Parameters.Add("@Item_Name", SqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = comboBox1.Text;
                cmd.Parameters.Add("@Rate", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox3.Text);
                cmd.Parameters.Add("@Balance_Quantity", SqlDbType.Int).Value = Convert.ToInt32(textBox4.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                label7.Text = "Record added successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                display_Item_master();
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
                qr = "update Item_master set Item_Name=@Item_Name,Category=@Category,Rate=@Rate,Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Item_Name", SqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = comboBox1.Text;
                cmd.Parameters.Add("@Rate", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox3.Text);
                cmd.Parameters.Add("@Balance_Quantity", SqlDbType.Int).Value = textBox4.Text;
                cmd.Parameters.Add("@Item_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                label7.Text = "Record updated successfully";
                textBox1.Clear();
                textBox2.Clear();
                // comboBox1.Items.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                display_Item_master();
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
                qr = "delete from Item_master where Item_Id=@Item_Id";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Item_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                label7.Text = "Record deleted successfully";
                textBox1.Clear();
                textBox2.Clear();
                // comboBox1.Items.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                display_Item_master();

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
                qr = "select * from Item_master where Item_Id=@Item_Id";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@Item_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                conn.Open();
                int flag = 0;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["Item_Name"].ToString();
                    comboBox1.Text = dr["Category"].ToString();
                    textBox3.Text = dr["Rate"].ToString();
                    textBox4.Text = dr["Balance_Quantity"].ToString();
                }
                if (flag == 0)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    // comboBox1.Items.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox1.Focus();
                    label7.Text = "No record found";
                }
                dr.Close();
                conn.Close();
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display_Item_master();
        }
        public void display_Item_master()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Item_master", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Item_master");
                dataGridView1.DataSource = ds.Tables["Item_master"];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
