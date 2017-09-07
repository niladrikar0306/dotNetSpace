
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
        // we can use [FromUri] to get complex query parameter
        // all these input parameters can be resolved from path or query depending upon the situation
        // this is a little strange to see .net as unopinionated 
        [ActionName("index")]
        public IEnumerable<RCGroupConfig> Get(String id = null, String loc=null)
        {
            Console.WriteLine("value of state int i is => " + i++);
            return new RCDataService().GetAllDQGroups();
            
        }

        [HttpGet]
        [ActionName("getaction")]
        public IEnumerable<RCGroupConfig> CustomGet()
        {
            Console.WriteLine("value of state int i is => " + i++);
            return new RCDataService().GetAllDQGroups();

        }


        
    }
}
