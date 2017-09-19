using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller // This is HelloController extending the base Controller class
    {
        /* Example from Intro to ASP.NET Core MVC: Controllers
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html"); // Optional 2nd parameter to Content method that is content type
        }
        */

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(string name = "World") // Enables method to accept query parameter of "name"
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // POST: /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}", name), "text/html");
        }


        // Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}", name), "text/html");
        }


        // /Hello/Goodbye
        // alter the route to this controller to be: /Hello/Aloha
        [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
