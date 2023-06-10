using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PROJECT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=HP-LAPTOP\\SQLEXPRESS;integrated security=true;database=PROJECT_MASTER");
        SqlCommand cmd = null;
        string qr = null;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                qr = "insert into Category_Master values(@CategoryId,@CategoryName)";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
                cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = TextBox2.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Label1.Text = "Record added successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();
            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                qr = "update Category_Master set CategoryName=@CategoryName where CategoryId=@CategoryId";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = TextBox2.Text;
                cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Label1.Text = "Record update successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();
            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                qr = "delete from Category_Master where CategoryId=@CategoryId";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Label1.Text = "Record delete successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();
            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                qr = "select * from Category_Master where CategoryId=@CategoryId";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
                conn.Open();
                int flag = 0;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    flag = 1;
                    TextBox2.Text = reader["CategoryName"].ToString();
                    Label1.Text = "Record search successfully";
                }
                if (flag == 0)
                {
                    Label1.Text = "No record found";
                    TextBox2.Text = "";
                    TextBox1.Focus();
                    
                }
                reader.Close();
                conn.Close();
                
            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
        }
    }
}