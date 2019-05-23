using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo1.Models;

namespace WebApiDemo1.Controllers
{
    public class EmployController : ApiController
    {
        Employ[] arrEmploy = new Employ[]
        {
            new Employ{Empno=1,Name="Arun",Dept="Dotnet",Desig="Developer",Basic=88924},
            new Employ{Empno=2,Name="Adi",Dept="JAVA",Desig="WebDev",Basic=88324},
            new Employ{Empno=3,Name="Manu",Dept="Sql",Desig="Expert",Basic=88264},
            new Employ{Empno=4,Name="Sagar",Dept="Dotnet",Desig="WebDev",Basic=88224},
            new Employ{Empno=5,Name="Vidhi",Dept="JAVA",Desig="Developer",Basic=88274}
        };

        public IEnumerable<Employ> Get()
        {
            return arrEmploy;
            
        }
        public IHttpActionResult Get(int id)
        {
            var emp = arrEmploy.FirstOrDefault((e) => e.Empno == id);
            if(emp==null)
            {
                return NotFound();
            
            }
            return Ok(emp);
        }
    }
}
