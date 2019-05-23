using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpClientDemo.ServiceReference1;

namespace EmpClientDemo
{
    public partial class ShowEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployServiceClient client = new EmployServiceClient();
            List<Emp> lstEmp = client.ShowEmp().ToList();
            grdEmp.DataSource = lstEmp.ToList();
            grdEmp.DataBind();
        }
    }
}