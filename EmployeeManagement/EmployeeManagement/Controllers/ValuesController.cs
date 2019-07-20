using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // anotation - kung marami ng get or kung ung name ng action is walng get
        [HttpGet]
        // GET api/values
        //way of caching
        // IEnumerable - readonly 
        // IList - 
        // Icollection -  pwdeng iorder
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //get from browser
        // GET api/values/5
        // nagpapasa ka ng 
        public string Get(int id)
        {
            return "value";
        }
        // getting  from 
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
