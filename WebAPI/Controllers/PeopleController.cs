using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    /// <summary>
    /// this is where u get all of the informatioon about people
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Stas", LastName = "Berezin", Id = 1 });
            people.Add(new Person { FirstName = "Michael", LastName = "Holmes", Id = 2 });
            people.Add(new Person { FirstName = "Terra", LastName = "Earth", Id = 3 });
        }
        /// <summary>
        /// building comments
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        //specifies how to achieve it
        //can also do something like [Route("api/People/getFirstNames/{userId:int}/{age:int}")]
        //but then have to specify those values in function parameters
        [Route("api/People/getFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> getFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach(var person in people)
            {
                output.Add(person.FirstName);
            }
            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            //thats how to find it
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
        }


        // DELETE: api/People/5
        public void Delete(int id)
        {
            
        }
    }
}
