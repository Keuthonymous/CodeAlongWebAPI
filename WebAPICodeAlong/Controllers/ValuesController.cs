using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPICodeAlong.Models;

namespace WebAPICodeAlong.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<Book> b = new List<Book>()
            {
                    new Book
                {

                    ISBN = 1,
                    Title = "SomeThing",
                    Author = "Someone",
                    Description = "A book",
                    PublishedYear = 0001
                },

                    new Book
                {

                    ISBN = 2,
                    Title = "SomeThing Else",
                    Author = "Someone Else",
                    Description = "Another book",
                    PublishedYear = 0001
                },
                    new Book
                {

                    ISBN = 3,
                    Title = "Another thing",
                    Author = "Someone Different",
                    Description = "That persons book",
                    PublishedYear = 0001
                },
                    new Book
                {

                    ISBN = 4,
                    Title = "The Bible",
                    Author = "Someone imaginary",
                    Description = "Fantasy",
                    PublishedYear = 0001
                }

            };
        // GET api/values
        public IEnumerable<Book> Get()
        {
            return b;
        }

        // GET api/values/5
        public Book Get(int ISBN)
        {
            var query = (from books in b
                         where books.ISBN == ISBN
                         select books).FirstOrDefault();

            return query;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
