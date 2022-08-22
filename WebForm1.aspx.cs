using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccessLayer;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL obj = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            obj.InsertData(TextBox1.Text,TextBox2.Text,TextBox3.Text,TextBox4.Text);
            GridView1.DataBind();

            Response.Redirect("WebForm1.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if(obj.UpdateData(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text))
            {
                GridView1.DataBind();
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                Response.Write("Can't Update, Try Again");
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            obj.DeleteData(TextBox1.Text);
            GridView1.DataBind();
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = obj.ShowData();
            GridView1.DataBind();
        }
    }
}