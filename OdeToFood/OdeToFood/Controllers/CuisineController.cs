
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        // The Authorize attribute causes MVC to require authorization 
        // before accessing this action. Because of this attribute,
        // the framework automagically redirects the user to the 
        // login page (and, I assume, would redirect back to the 
        // search page after a successful login).
        [Authorize]
        public ActionResult Search(string name = "french")
        {
            // Back to returning simple content.
            var encodedName = Server.HtmlEncode(name);
            return Content(encodedName);
        }
    }
}
