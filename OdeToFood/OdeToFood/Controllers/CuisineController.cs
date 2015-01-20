
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        // Adding the http verb as an attribute means this controller is 
        // only reached for that specific verb.
        [HttpGet]
        public ActionResult Search(string name = "french")
        {
            // Back to returning simple content.
            var encodedName = Server.HtmlEncode(name);
            return Content(encodedName);
        }
    }
}
