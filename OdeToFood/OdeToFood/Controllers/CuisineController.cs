
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        // Using HTTP verbs allows the framework to resolve the ambiguity.
        [HttpPost]
        public ActionResult Search(string name = "french")
        {
            // Back to returning simple content.
            var encodedName = Server.HtmlEncode(name);
            return Content(encodedName);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return Content("Search!");
        }

    }
}
