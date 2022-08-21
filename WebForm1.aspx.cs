using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            obj.DeleteData(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            obj.UpdateData(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
        }
    }
}