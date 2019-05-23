using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BMS.BLL;
using BMS.DAL.BookServiceReference;
using System.Web.Mvc;

namespace BMS_Web_MVC_App.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            List<Book> blist = BookBLL.GetBooksBLL();
            return View(blist);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create

        public ActionResult Create()
        {
            return View();
        }

      
        // GET: Book/Edit/5

            [HttpPost]
            public ActionResult Create(Book book)
        {
            bool status = BookBLL.AddBookBLL(book);
            if(status)
            {
                return RedirectToAction("Index","Book");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            Book book = BookBLL.GetBookBLL(id);
            return View(book);
        }

        // POST: Book/Edit/5
      [HttpPost]
     
        public ActionResult Edit(Book book)
        {
            bool status = BookBLL.UpdateBookBLL(book);
            if(status)
            {
                return RedirectToAction("Index", "Book");
            }
            return View();
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            //bool status = BookBLL.DeleteBookBLL(ID);
            //if(status)
            //{
            //    return RedirectToAction("Index", "Book");
            //}
            //return View();
            Book book = BookBLL.GetBookBLL(id);
            return View(book);
        }
        // POST: Book/Delete/5
        [HttpPost]
       public ActionResult Delete(Book book)
        {
            int id = Convert.ToInt32(book.ID);
            bool status = BookBLL.DeleteBookBLL(id);
            if(status)
            {
                return RedirectToAction("Index", "Book");
            }
            return View();
        }
    }
}
