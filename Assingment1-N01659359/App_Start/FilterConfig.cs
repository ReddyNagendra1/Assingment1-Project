using System.Web;
using System.Web.Mvc;

namespace Assingment1_N01659359
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
