using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cachingDemo
{
    public partial class CalculatorControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtfno.Text);
            int j = Convert.ToInt32(txtsno.Text);
            int ans = i + j;
            txtans.Text = ans.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtfno.Text);
            int j = Convert.ToInt32(txtsno.Text);
            int ans = i - j;
            txtans.Text = ans.ToString();
        }
    }
}