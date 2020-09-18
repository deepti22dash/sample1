using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClasslibraryFact;

namespace WebApplicationFactorial
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Factorial f = new Factorial();
        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1 .Text);
            int res = Convert.ToInt32(TextBox2.Text);
            int result = f.Fact(num);
            TextBox2 .Text = result.ToString();
            Console.ReadKey();           
        }
    }
}