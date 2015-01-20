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
            // HtmlEncode prevents cross-site scripting attack. (Razor will
            // prevent this but a call to Content() assumes you know what
            // you are doing. You have been warned!
            var encodedName = Server.HtmlEncode(name);
            return Content(encodedName);
        }

    }
}
