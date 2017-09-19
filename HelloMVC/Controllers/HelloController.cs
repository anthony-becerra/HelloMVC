using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller // This is HelloController extending the base Controller class
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html"); // Optional 2nd parameter to Content method that is content type
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
