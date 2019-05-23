using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcWebClient
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSum_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalcServiceClient client =
                new ServiceReference1.CalcServiceClient();
            int a, b, c;
            a = Convert.ToInt32(txtFirstNo.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = client.Sum(a, b);
            txtResult.Text = c.ToString();
        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {

            ServiceReference1.CalcServiceClient client =
                new ServiceReference1.CalcServiceClient();
            int a, b, c;
            a = Convert.ToInt32(txtFirstNo.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = client.Sub(a, b);
            txtResult.Text = c.ToString();
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {

            ServiceReference1.CalcServiceClient client =
                new ServiceReference1.CalcServiceClient();
            int a, b, c;
            a = Convert.ToInt32(txtFirstNo.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = client.Mult(a, b);
            txtResult.Text = c.ToString();
        }
    }
}