using _Lab_RazorSyntax.Models;
using Microsoft.AspNetCore.Mvc;

namespace _Lab_RazorSyntax.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            PostViewModel model = new PostViewModel
            { Id = 1, Title = "What is ASP.NET Core",
                Author = "Shailendra Chauhan",
                Body = "ASP.NET Core is an open-source framework for building UI and API..." 
            };
            return View(model);

        }
    }
}
