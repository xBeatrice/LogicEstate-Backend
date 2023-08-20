using System.Web.Mvc;

namespace LogicEstate.Controllers
{
    public class TestController : Controller
    {
        // GET: /Test/SimpleEndpoint
        public ActionResult SimpleEndpoint()
        {
            var responseData = new
            {
                Message = "This is a simple endpoint response.",
                Data = new { Foo = "Bar", Baz = 123 }
            };

            // Return the response as JSON
            return Json(responseData, JsonRequestBehavior.AllowGet);
        }
    }
}
