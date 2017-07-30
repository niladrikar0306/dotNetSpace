using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi1.beans;

namespace webapi1.Controllers
{
    public class SellsController : ApiController
    {
        public IEnumerable<Sells> Get()
        {
            var li = new List<Sells>();

            Sells s1 = new Sells();
            s1.CustomerId = "1";
            s1.ProductName = "p1";
            li.Add(s1);


            return li;
        }
    }
}
