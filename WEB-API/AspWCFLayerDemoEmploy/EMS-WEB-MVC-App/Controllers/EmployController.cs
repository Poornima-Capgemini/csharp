using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMS.BLL;
using EMS.DAL.EmployServiceReference;
using System.Web.Mvc;

namespace EMS_WEB_MVC_App.Controllers
{
    public class EmployController : Controller
    {
        // GET: Employ
        public ActionResult Index()
        {
            List<Employ> elist = EmployBLL.GetEmploysBLL();
            return View(elist);
        }

        // GET: Employ/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employ/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employ/Create
        [HttpPost]
        public ActionResult Create(Employ employ)
        {
            bool status = EmployBLL.AddEmployBLL(employ);
            if (status)
            {
                return RedirectToAction("Index", "Employ");
            }
            return View();
        }

        // GET: Employ/Edit/5
        public ActionResult Edit(int Empno)
        {
            Employ employ = EmployBLL.GetEmployBLL(Empno);
            return View(employ);
        }

        // POST: Book/Edit/5
        [HttpPost]

        public ActionResult Edit(Employ employ)
        {
            bool status = EmployBLL.UpdateEmployBLL(employ);
            if (status)
            {
                return RedirectToAction("Index", "Employ");
            }
            return View();
        }

        // GET: Employ/Delete/5
        public ActionResult Delete(int Empno)
        {
            //bool status = BookBLL.DeleteBookBLL(ID);
            //if(status)
            //{
            //    return RedirectToAction("Index", "Book");
            //}
            //return View();
            Employ employ = EmployBLL.GetEmployBLL(Empno);
            return View(employ);
        }
        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(Employ employ)
        {
            int Empno = Convert.ToInt32(employ.Empno);
            string status = EmployBLL.DeleteEmployBLL(Empno);
            //if (status)
            //{
            //    return RedirectToAction("Index", "Employ");
            //}
            ViewBag.status = status;
            return View("DeleteNew");
        }
    }
}
