using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo2.Models;

namespace Demo2.Controllers
{
    public class ContactController : ApiController
    {
        Contact[] arrContact = new Contact[]
       {
            new Contact{ContactId=1,Name="Arun",Address="Dotnet",City="Darwad",State="Karnataka",Zip="76543",Email="arun@gmail.com"},
            new Contact{ContactId=2,Name="Adi",Address="JAVA",City="Hyd",State="TamilNadu",Zip="76943",Email="Adi@gmail.com"},
            new Contact{ContactId=3,Name="Manu",Address="Sql",City="Banglore",State="Telangana",Zip="86543",Email="Manu@gmail.com"},
            new Contact{ContactId=4,Name="Sagar",Address="Dotnet",City="Hubli",State="Kerala",Zip="46543",Email="sagar@gmail.com"},
            new Contact{ContactId=5,Name="Vidhi",Address="JAVA",City="shimoga",State="Goa",Zip="36543",Email="vidhi@gmail.com"}
       };

        public IEnumerable<Contact> Get()
        {
            return arrContact;

        }
        public IHttpActionResult Get(int id)
        {
            var contact = arrContact.FirstOrDefault((e) => e.ContactId == id);
            if (contact == null)
            {
                return NotFound();

            }
            return Ok(contact);
        }
    }
}
