using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Stas", LastName = "Berezin", Id = 1 });
            people.Add(new Person { FirstName = "Michael", LastName = "Holmes", Id = 2 });
            people.Add(new Person { FirstName = "Terra", LastName = "Earth", Id = 3 });
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }


        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
