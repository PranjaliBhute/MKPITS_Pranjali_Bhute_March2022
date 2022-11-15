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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int Balance_Quantity;
        int Item_Id;
        int Department_Id;
        int Vendor_Id;

        private void Form4_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    int cnt = 0;
                    SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                    string qr = "select Transaction_Id from Transactions";
                    SqlCommand cmd = new SqlCommand(qr, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cnt = Convert.ToInt32(dr["Transaction_Id"].ToString());
                    }
                    dr.Close();
                    if (cnt == 0)
                    {
                        textBox1.Text = "1";
                        textBox3.Text = "1";
                    }
                    else
                    {
                        cnt = cnt + 1;
                        textBox1.Text = cnt.ToString();
                        textBox3.Text = cnt.ToString();
                    }
                    conn.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

                try
                {
                    SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                    string qr = "select distinct Item_Name from Item_master";
                    SqlCommand cmd = new SqlCommand(qr, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["Item_Name"].ToString());
                        comboBox3.Items.Add(dr["Item_Name"].ToString());


                    }
                    dr.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }


                try
                {
                    SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                    string qr = "select * from Department_mast";
                    SqlCommand cmd = new SqlCommand(qr, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBox2.Items.Add(dr["Department_Name"].ToString());
                        Department_Id = Convert.ToInt32(dr["Department_Id"].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                try
                {
                    SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                    string qr = "select * from Vendor_mast";
                    SqlCommand cmd = new SqlCommand(qr, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBox4.Items.Add(dr["Vendor_Name"].ToString());
                        Vendor_Id = Convert.ToInt32(dr["Vendor_Id"].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Balance_Quantity == 0)
            {
                MessageBox.Show("Can't issue item as balance quantity is 0");
            }
            else if (Balance_Quantity < Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("balance quantity is less than entered quantity");

            }
            else
            {

                SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                conn.Open();
                SqlTransaction sqltr = conn.BeginTransaction();
                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.Transaction = sqltr;
                try
                {
                    cmd1.CommandText = "insert into Transactions values(@Transaction_Id,@Item_Id,@Transaction_Date,@Department_Id,@Vendor_Id,@Quantity)";
                    cmd1.Parameters.Add("@Transaction_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                    cmd1.Parameters.Add("@Item_Id", SqlDbType.Int).Value = Item_Id;
                    cmd1.Parameters.Add("@Transaction_Date", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                    cmd1.Parameters.Add("@Department_Id", SqlDbType.Int).Value = Department_Id;
                    cmd1.Parameters.Add("@Vendor_Id", SqlDbType.Int).Value = 0;
                    cmd1.Parameters.Add("@Quantity", SqlDbType.Int).Value = Convert.ToInt32(textBox2.Text);
                    cmd1.ExecuteNonQuery();

                    int remain_qty = Balance_Quantity - Convert.ToInt32(textBox2.Text);
                    cmd1.CommandText = "update Item_master set Balance_Quantity=@Balance_Quantity where Item_Id=@Id";
                    cmd1.Parameters.Add("@Balance_Quantity", SqlDbType.Int).Value = remain_qty;
                    cmd1.Parameters.Add("@Id", SqlDbType.Int).Value = Item_Id;
                    cmd1.ExecuteNonQuery();

                    sqltr.Commit();
                    conn.Close();
                    MessageBox.Show("Data issued successfully!");
                }
                catch (Exception ee1)
                {
                    MessageBox.Show(ee1.Message);
                    try
                    {
                        sqltr.Rollback();
                    }
                    catch (Exception ee2)
                    {
                        MessageBox.Show(ee2.Message);
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
            conn.Open();
            SqlTransaction sqltr = conn.BeginTransaction();
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.Transaction = sqltr;
            try
            {
                cmd1.CommandText = "insert into Transactions values(@Transaction_Id,@Item_Id,@Transaction_Date,@Department_Id,@Vendor_Id,@Quantity)";
                cmd1.Parameters.Add("@Transaction_Id", SqlDbType.Int).Value = Convert.ToInt32(textBox3.Text);
                cmd1.Parameters.Add("@Item_Id", SqlDbType.Int).Value = Item_Id;
                cmd1.Parameters.Add("@Transaction_Date", SqlDbType.DateTime).Value = dateTimePicker2.Text;
                cmd1.Parameters.Add("@Department_Id", SqlDbType.Int).Value = 0;
                cmd1.Parameters.Add("@Vendor_Id", SqlDbType.Int).Value = Vendor_Id;
                cmd1.Parameters.Add("@Quantity", SqlDbType.Int).Value = Convert.ToInt32(textBox4.Text);
                cmd1.ExecuteNonQuery();

                int after_add_qty = Balance_Quantity + Convert.ToInt32(textBox4.Text);
                cmd1.CommandText = "update Item_master set Balance_Quantity=@Balance_Quantity where Item_Id=@Id";
                cmd1.Parameters.Add("@Balance_Quantity", SqlDbType.Int).Value = after_add_qty;
                cmd1.Parameters.Add("@Id", SqlDbType.Int).Value = Item_Id;
                MessageBox.Show("" + after_add_qty);
                cmd1.ExecuteNonQuery();

                sqltr.Commit();
                conn.Close();
                MessageBox.Show("Data purchased, successfully!");
            }
            catch (Exception ee1)
            {
                MessageBox.Show(ee1.Message);
                try
                {
                    sqltr.Rollback();
                }
                catch (Exception ee2)
                {
                    MessageBox.Show(ee2.Message);
                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                string qr = "select Item_Id,Balance_Quantity from Item_master where Item_Name='" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(qr, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Balance_Quantity = Convert.ToInt32(dr["Balance_Quantity"].ToString());
                    Item_Id = Convert.ToInt32(dr["Item_Id"].ToString());

                }
                dr.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                string qr = "select Department_Id from Department_mast where Department_Name='" + comboBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(qr, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Department_Id = Convert.ToInt32(dr["Department_Id"].ToString());
                }
                dr.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                string qr = "select Item_Id,Balance_Quantity from Item_master where Item_Name='" + comboBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(qr, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Balance_Quantity = Convert.ToInt32(dr["Balance_Quantity"].ToString());
                    Item_Id = Convert.ToInt32(dr["Item_Id"].ToString());


                }
                dr.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                string qr = "select Vendor_Id from Vendor_mast where Vendor_Name='" + comboBox4.Text + "'";
                SqlCommand cmd = new SqlCommand(qr, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Vendor_Id = Convert.ToInt32(dr["Vendor_Id"].ToString());
                }
                dr.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
