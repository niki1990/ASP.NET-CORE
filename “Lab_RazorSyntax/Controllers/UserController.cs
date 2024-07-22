using Microsoft.AspNetCore.Mvc;
using _Lab_RazorSyntax.Models;

namespace _Lab_RazorSyntax.Controllers
{
    public class UserController : Controller
    {

        //Initialize it outside the method to persist the data in next request
        private static  List<UserModel> Users = new List<UserModel>(); 
        public IActionResult Index()
        {
            return View(Users);
        }
        public IActionResult Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
           
                    UserModel user = new UserModel { UserId =model.UserId, Name =model.Name, Email =model.Email };
                    Users.Add(user);
            }
            return RedirectToAction("Index");
        }
    }
}
