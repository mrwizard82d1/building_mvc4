using System.Web.Mvc;

namespace OdeToFood
{
    public class FilterConfig
    {
        // A global filter is an action filter that applies to **every**
        // request in the entire **application**.
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}