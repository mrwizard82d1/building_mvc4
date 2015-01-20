
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    // The Authorize attribute causes MVC to require authorization 
    // before accessing **every** action of this controller.
    [Authorize]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        public ActionResult Search(string name = "french")
        {
            // Back to returning simple content.
            var encodedName = Server.HtmlEncode(name);
            return Content(encodedName);
        }
    }
}
