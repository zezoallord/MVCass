using Microsoft.AspNetCore.Mvc;

namespace MVCass1.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    //ContentResult result = new ContentResult();
        //    //result.Content = "Hello from content controller";
        //    //return result;
        //    return Content("Hello from content controller");
          
        //}
        //public IActionResult aboutus()
        //{
        //    return Redirect("https://www.youtube.com/");

        //}
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult aboutus()
        {
            return View();
        }
        public IActionResult contactus()
        {
            return View();
        }
       
        public IActionResult privacy()
        {
            return View();
        }
    }
}
