using Lab_03_Registration_Continued.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_03_Registration_Continued.Controllers
{
    public class RegController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult RegProcess(Registration reg)
        {
            bool errorFound = false;

            if (string.IsNullOrWhiteSpace(reg.LastName))
            {
                ViewBag.LastNameMsg = "Last Name field must contains at least initial!";
                errorFound = true;
            }
            if (!reg.Email.Contains('@'))
            {
                ViewBag.EmailMsg = "Please, enter a valid email!";
            }
            if (errorFound)
            {
                return View("Registration");
            }
            else
            {
                return View(reg);
            }
        }
    }
}
