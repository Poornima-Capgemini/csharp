using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BookException;
using BMS.DAL.BookServiceReference;

namespace BMS.DAL
{
    public class BookDAL
    {
        BookServiceClient client = new BookServiceClient();

        public bool DeleteBookDAL(int BookID)
        {
            bool bookDeleted = false;
            try
            {
                bookDeleted = client.DeleteBook(BookID);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return bookDeleted;

        }
        public bool UpdateBookDAL(Book book)
        {
            bool updateBook = false;
            try
            {
                updateBook = client.UpdateBook(book);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return updateBook;
        }
        public bool AddBookDAL(Book book)
        {
            bool bookAdded = false;
            try
            {
                bookAdded = client.AddBook(book);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return bookAdded;
        }

        public Book GetBookDAL(int id)
        {
            Book book = null;
            try
            {
                book = client.SearchBook(id);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return book;
        }
        public List<Book> GetBooksDAL()
        {
            List<Book> blist = null;
            try
            {
                blist = client.ShowBook().ToList();
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return blist;
        }


    }

}
