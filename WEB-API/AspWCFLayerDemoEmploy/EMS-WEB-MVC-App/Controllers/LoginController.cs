using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS_WEB_MVC_App.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EMS_WEB_MVC_App.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(Login login)
        {

            SqlConnection cnSqlpractice;
            SqlDataAdapter adapter;
            SqlCommandBuilder cmdBuilder;
            DataSet dt;
            string strcon = ConfigurationManager.ConnectionStrings["employconn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            adapter = new SqlDataAdapter("Select*from Users WHERE UserName=@username AND Password=@password", cnSqlpractice);
            adapter.SelectCommand.Parameters.AddWithValue("@username", login.UserName);
            adapter.SelectCommand.Parameters.AddWithValue("@password", login.Password);
            cmdBuilder = new SqlCommandBuilder(adapter);
            dt = new DataSet();
            adapter.Fill(dt, "EmployDummy");
            int Count = 0;
            Count = dt.Tables["EmployDummy"].Rows.Count;
            if (Count > 0)
            {
                ViewBag.Message = "Login Successful";
                return RedirectToAction("Index", "Employ");

            }
            else
            {
                ViewBag.Message = "Invalid Credentials";
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
