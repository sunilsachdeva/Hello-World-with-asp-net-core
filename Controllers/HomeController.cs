using Microsoft.AspNetCore.Mvc;
namespace ConsoleApplication.Controllers
{
    public class HomeController : Controller
    {
        [Route("home/index")]
        public IActionResult Index()
        {
            return Content("Hello world from Controller!");
        }
    }
}
