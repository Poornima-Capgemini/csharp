using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpClientDemo.ServiceReference1;
namespace EmpClientDemo
{
    public partial class AddEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployServiceClient client = new EmployServiceClient();
            int empno = client.AutoGenerateEmpno();
            txtEmpNo.Text = empno.ToString();
        }

        
        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            EmployServiceClient client = new EmployServiceClient();
            Emp emp = new Emp();
            emp.Empno = Convert.ToInt32(txtEmpNo.Text);
            emp.Name = txtEmployName.Text;
            emp.Dept = txtDepartment.Text;
            emp.Desig = txtDesignation.Text;
            emp.Basic = Convert.ToInt32(txtBasic.Text);
            bool result = client.InsertEmp(emp);
            if (result == true)
            {
                Response.Write("Recorded Insertd");
            }
        }
    }
}