using System.Net;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        // Including parameter named "name" causes MVC framework to try to 
        // find a parameter named "name" in ANY of the web request (routing
        // data, query string or posted form data).
        public ActionResult Search(string name = "french")
        {
            // Server.MapPath() converts from virtual path to actual path on 
            // the **server** filesystem. The symbol ~ identifies the 
            // application root (OdeToFood).
            var encodedName = Server.HtmlEncode(name);
            return File(Server.MapPath("~/Content/Site.css"), "text/css");
        }
    }
}
