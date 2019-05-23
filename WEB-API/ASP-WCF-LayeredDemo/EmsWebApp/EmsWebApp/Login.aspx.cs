using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;
using BMS.DAL.BookServiceReference;

namespace EmsWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["bookconn"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd;
            DataTable dt = new DataTable();
            int id = 0;
            con.Open();
            cmd = new SqlCommand("PrcUserAuthenticate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", Login1.UserName);
            cmd.Parameters.AddWithValue("@passWord", Login1.Password);
            int rc = Convert.ToInt32(cmd.ExecuteScalar());
            if(rc>0)
            {
                S("ViewBooks.aspx");
            }

        }
    }
}