using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Here you can implement your authentication logic
                // For example, checking if the provided username and password are valid
                if (model.Username == "admin" && model.Password == "password")
                {
                    // Authentication successful
                    // You can redirect the user to a dashboard or another page
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Authentication failed
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }

            // If the model state is not valid, return the view with validation errors
            return View(model);
        }
    }
}
