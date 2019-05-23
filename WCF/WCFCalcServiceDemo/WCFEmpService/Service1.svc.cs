﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WCFEmpService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployService.svc or EmployService.svc.cs at the Solution Explorer and start debugging.
    public class EmployService : IEmployService
    {
        SqlConnection connection;
        SqlCommand cmdSql;
        SqlDataReader dataReader;
        public int AutoGenerateEmpno()
        {
            string strcon = ConfigurationManager.
            ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpAutoGen", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            int empno = Convert.ToInt32(cmdSql.ExecuteScalar());
            return empno;
        }
        public List<Emp> ShowEmp()
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpShow", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            dataReader = cmdSql.ExecuteReader();
            List<Emp> lstEmp = null;
            lstEmp = new List<Emp>();
            while (dataReader.Read())
            {
                
                Emp emp = new Emp();
                emp.Empno = Convert.ToInt32(dataReader["empno"]);
                emp.Name = dataReader["nam"].ToString();
                emp.Dept = dataReader["dept"].ToString();
                emp.Desig = dataReader["desig"].ToString();
                emp.Basic = Convert.ToInt32(dataReader["basic"]);
                lstEmp.Add(emp);
            }
            return lstEmp;
        }

        public bool InsertEmp(Emp objEmp)
        {
            string strcon = ConfigurationManager.
          ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpInsert", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.Parameters.AddWithValue("@empno", objEmp.Empno);
            cmdSql.Parameters.AddWithValue("@name", objEmp.Name);
            cmdSql.Parameters.AddWithValue("@dept", objEmp.Dept);
            cmdSql.Parameters.AddWithValue("@desig", objEmp.Desig);
            cmdSql.Parameters.AddWithValue("@basic", objEmp.Basic);
            cmdSql.ExecuteNonQuery();
            return true;
        }
        public Emp SearchEmp(int empno)
        {
            string strcon = ConfigurationManager.
             ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpSearch", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.Parameters.AddWithValue("@empno", empno);
            dataReader = cmdSql.ExecuteReader();
            Emp emp = null;
            if (dataReader.Read())
            {
                emp = new Emp();
                emp.Name = dataReader["nam"].ToString();
                emp.Dept = dataReader["dept"].ToString();
                emp.Desig = dataReader["desig"].ToString();
                emp.Basic = Convert.ToInt32(dataReader["basic"]);
            }
            return emp;
        }
        public bool UpdateEmp(Emp objEmp)
        {
            string strcon = ConfigurationManager.
            ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmdSql = new SqlCommand("prcEmpUpdate", connection);
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.Parameters.AddWithValue("@empno", objEmp.Empno);
            cmdSql.Parameters.AddWithValue("@nam", objEmp.Name);
            cmdSql.Parameters.AddWithValue("@dept", objEmp.Dept);
            cmdSql.Parameters.AddWithValue("@desig", objEmp.Desig);
            cmdSql.Parameters.AddWithValue("@basic", objEmp.Basic);
            cmdSql.ExecuteNonQuery();
            return true;
        }
    }
}
    

