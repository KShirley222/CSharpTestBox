using Microsoft.AspNetCore.Mvc;

namespace FirstProject
{
    public class HomeController : Controller 
    {
        [Route("")]
        [HttpGet]
        // Default to HttpGet if not provided
        public ViewResult TestHtml()
        {
            return View();
        }

        [Route("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hi Again!";
        }

        [HttpGet("users/{username};")]

        public string HelloUser(string username)
        {
            return $"Hello, {username}";
        }

    }
}