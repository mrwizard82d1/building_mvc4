
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        // Without HTTP verbs, invoking search is ambiguous. (Note that the
        // MVC framework finds the request ambiguous even though R#
        // reports that the version of Search with the optional parameter
        // is **hidden** by the parameterless version.)
        public ActionResult Search(string name = "french")
        {
            // Back to returning simple content.
            var encodedName = Server.HtmlEncode(name);
            return Content(encodedName);
        }

        public ActionResult Search()
        {
            return Content("Search!");
        }

    }
}
