using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpClientDemo.ServiceReference1;

namespace EmpClientDemo
{
    public partial class UpdateEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {

            EmployServiceClient client = new EmployServiceClient();
            Emp emp = new Emp();
            emp.Empno = Convert.ToInt32(txtEmpNo.Text);
            emp.Name = txtEmployName.Text;
            emp.Dept = txtDepartment.Text;
            emp.Desig = txtDesignation.Text;
            emp.Basic = Convert.ToInt32(txtBasic.Text);
            bool result = client.UpdateEmp(emp);
            if (result == true)
            {
                Response.Write("Recorded Updated");
            }
        }

        protected void txtEmpNo_TextChanged(object sender, EventArgs e)
        {
            Emp emp = null;
            EmployServiceClient client = new EmployServiceClient();
            emp = client.SearchEmp(Convert.ToInt32(txtEmpNo.Text));
            if (emp != null)
            {
                txtEmployName.Text = emp.Name;
                txtDepartment.Text = emp.Dept;
                txtDesignation.Text = emp.Desig;
                txtBasic.Text = emp.Basic.ToString();
            }

        }
    }
}