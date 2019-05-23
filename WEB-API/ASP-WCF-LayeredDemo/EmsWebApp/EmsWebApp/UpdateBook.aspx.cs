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
    public partial class UpdateBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "m2", "alert('Please enter ID to Search')", true);
            }
            else
            {
                int searchid = Convert.ToInt32(txtID.Text);
                try
                {
                    Book book = BookBLL.GetBookBLL(searchid);
                    if (book != null)
                    {
                        txtName.Text = book.Name;
                        txtPrice.Text = book.Price.ToString();
                        txtDescription.Text = book.Description;


                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m4", "alert('Book not available')", true);
                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('" + ex.Message + "')", true);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.ID = Convert.ToInt32(txtID.Text);
                book.Name = txtName.Text;
                book.Price = Convert.ToDecimal(txtPrice.Text);
                book.Description = txtDescription.Text;
                bool status = BookBLL.UpdateBookBLL(book);
                if (status)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "m1", "alert('Book Details Updated')", true);
                    txtID.Text = " ";
                    txtName.Text = " ";
                    txtDescription.Text = "";
                    txtPrice.Text = " ";
                }

            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "error5", "alert('" + ex.Message + "')", true);
            }
        }
    }
}
