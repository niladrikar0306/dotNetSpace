using System.Web;
using System.Web.Mvc;

namespace org.niladri.net.web.webapi1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
