using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BMS_Web_MVC_App.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BMS_Web_MVC_App.Controllers
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
        public ActionResult Create(login login1)
        {
            string strcon = ConfigurationManager.ConnectionStrings["bookconn"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd;
            DataTable dt = new DataTable();
            int id = 0;
            con.Open();
            cmd = new SqlCommand("PrcUserAuthenticate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", login1.UserName);
            cmd.Parameters.AddWithValue("@passWord", login1.Password);
            int rc = Convert.ToInt32(cmd.ExecuteScalar());
            if (rc > 0)
            {
                return RedirectToAction("ViewBooks.aspx");
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
