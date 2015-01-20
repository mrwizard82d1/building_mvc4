using System.Web.Mvc;

namespace OdeToFood
{
    public class FilterConfig
    {
        // A global filter is an action filter that applies to **every**
        // request in the entire **application**.
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Removing this line causes an error page to be displayed
            // (although the details seen by the user are now different 
            // because we have specified <customErrors mode="On"/>).
            // filters.Add(new HandleErrorAttribute());
        }
    }
}