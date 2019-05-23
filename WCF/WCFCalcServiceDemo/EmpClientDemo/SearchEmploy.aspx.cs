using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpClientDemo.ServiceReference1;

namespace EmpClientDemo
{
    public partial class SearchEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            Emp emp = null;
            EmployServiceClient client = new EmployServiceClient();
            emp = client.SearchEmp(Convert.ToInt32(txtEmpNo.Text));
            if(emp!=null)
            {
                txtEmployName.Text = emp.Name;
                txtDepartment.Text = emp.Dept;
                txtDesignation.Text = emp.Desig;
                txtBasic.Text = emp.ToString();
            }
                  

        }
    }
}