
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
            // Returning JSON is fairly simple but one **must** allow this
            // request to return JSON.
            var encodedName = Server.HtmlEncode(name);
            return Json(new {Message = encodedName, Author = "Lawrence"},
                JsonRequestBehavior.AllowGet);
        }
    }
}
