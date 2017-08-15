
using Org.Niladri.Net.DAL.Bean;
using Org.Niladri.Net.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace org.niladri.net.web.webapi1.Controllers
{
    public class RCGroupController : ApiController
    {
        int i = 0;  
        // GET: api/RCGroup
        public IEnumerable<RCGroupConfig> Get()
        {
            Console.WriteLine("value of state int i is => " + i++);
            return new RCDataService().GetAllDQGroups();
            
        }

        // GET: api/RCGroup/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RCGroup
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RCGroup/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RCGroup/5
        public void Delete(int id)
        {
        }
    }
}
