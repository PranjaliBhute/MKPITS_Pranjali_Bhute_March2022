using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_Que1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            n1 = Convert.ToInt32(TextBox1.Text);
            n2 = Convert.ToInt32(TextBox2.Text);
            n3 = Convert.ToInt32(TextBox3.Text);
            int Total = n1 + n2 + n3;
            Label1.Text = "Total = " + Total;
            float per = (Total / 300.0f) * 100;
            Label2.Text = "Percentage = " + per;
            if (per >= 75)
            {
                Label3.Text = "Grade = Distinction";
            }
            else if (per >= 60 && per < 75)
            {
                Label3.Text = "Grade = First Division";
            }
            else if (per >= 40 && per < 60)
            {
                Label3.Text = "Grade = Second Division";
            }
            else
            {
                Label3.Text = "Grade = Fail";
            }
            

        }
    }
}