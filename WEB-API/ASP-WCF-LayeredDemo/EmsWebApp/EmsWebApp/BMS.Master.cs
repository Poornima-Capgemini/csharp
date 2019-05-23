using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmsWebApp
{
    public partial class BMS : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnAddBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddWeb.aspx");
        }

        protected void lBtnUpdateBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateBook.aspx");
        }

        protected void lBtnDeleteBook_Click(object sender, EventArgs e)
        {
          Response.Redirect("DeleteBook.aspx");
        }

        protected void lBtnSearchBook_Click(object sender, EventArgs e)
        {
          Response.Redirect("SearchBook.aspx");
        }

        protected void lBtnViewBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBooks.aspx");
        }
    }
}