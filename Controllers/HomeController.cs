using Microsoft.AspNetCore.Mvc;
namespace ConsoleApplication.Controllers
{
    public class HomeController : Controller
    {
        //[Route("home/index")]
        //public IActionResult Index()
        //{
        //    //return Content("Hello world from Controller!");
        //    return View();
        //}

        [Route("home/index/{username?}")]
        public IActionResult Index(string username = "you")
        {
            var greeting = new Greeting { UserName = username };
            return View(greeting);
        }
    }
}
