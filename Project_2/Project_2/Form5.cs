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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false;
                dataGridView1.DataSource = "";
                SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Transaction_Id,Item_Id,Transaction_Date,Department_Id,Quantity from Transactions where Vendor_Id=0 order by Department_Id,Transaction_Date", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Issue_Details");
                dataGridView1.DataSource = ds.Tables["Issue_Details"];
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false;
                dataGridView1.DataSource = "";
                SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Transaction_Id,Item_Id,Transaction_Date,Vendor_Id,Quantity from Transactions where Department_Id=0 order by Vendor_Id,Transaction_Date", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Purchase_Details");
                dataGridView1.DataSource = ds.Tables["Purchase_Details"];
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            panel1.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlFormattedDate1 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                var sqlFormattedDate2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");
                SqlConnection conn = new SqlConnection("server = HP-LAPTOP\\SQLEXPRESS;integrated security=true;database = Project_2");
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Transaction_Id,Item_Id,Transaction_Date,Department_Id,quantity from Transactions where Transaction_Date between '" + sqlFormattedDate1 + "' and '" + sqlFormattedDate2 + "' order by Department_Id,Transaction_Date", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Issue_Details_By_Date");
                dataGridView1.DataSource = ds.Tables["Issue_Details_By_Date"];
                conn.Close();
                //MessageBox.Show(sqlFormattedDate);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
