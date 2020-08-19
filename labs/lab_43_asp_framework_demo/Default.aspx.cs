using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_43_asp_framework_demo
{
    public partial class _Default : Page
    {
        static int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            counter++;
            Label1.Text = "hEY - you clicked" + counter + " times";
        }
    }
}