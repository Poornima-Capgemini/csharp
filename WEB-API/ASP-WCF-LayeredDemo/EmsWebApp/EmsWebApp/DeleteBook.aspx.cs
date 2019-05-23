using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BMS.BLL;
using BMS.DAL.BookServiceReference;

namespace EmsWebApp
{
    public partial class DeleteBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if(txtBookID.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Please enter id')", true);

            }
            else
            {
                try
                {
                    int deleteID = Convert.ToInt32(txtBookID.Text);
                    bool status = BookBLL.DeleteBookBLL(deleteID);
                    if (status)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m3", "alert('Book Details Deleted')", true);

                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m6", "alert('Unable to delete book')", true);
                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error3", "alert(' "+ex.Message+" ')", true);
                }
            }
        }
    }
}