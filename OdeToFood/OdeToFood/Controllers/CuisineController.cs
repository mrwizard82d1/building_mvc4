
using System;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    // [Authorize]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        [Log]
        public ActionResult Search(string name = "french")
        {
            // Throwing an exception with default global filter invokes the
            // standard error handler. Invoking /cuisine then results in the 
            // ASP.NET "yellow screen of death" (but only when invoked from 
            // the same machine which is executing the server). Useful to a 
            // developer but also dangerous because it reveals information 
            // to a bad guy.
            throw  new Exception("Something terrible has happened. Oh, the humanity!");

            var encodedName = Server.HtmlEncode(name);
            return Content(encodedName);
        }
    }
}
