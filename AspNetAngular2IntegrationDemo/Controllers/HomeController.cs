using System.Web.Mvc;

namespace AspNetAngular2IntegrationDemo.Controllers
{
    public class HomeController : Controller
    {
        [Route("{*path}")]
        public ActionResult Index()
        {
            return File("~/Content/index.html", "text/html");
        }
    }
}