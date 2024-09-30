using Envoycan_Application.Models;
using Envoycan_Application.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;

namespace Envoycan_Application.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly Registration_Repository registration_Repository;
        public RegistrationController(Registration_Repository _Repository)
        {
            registration_Repository = _Repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]  
        public  async Task<IActionResult> Index(UserRegistration_Model userRegistration_Model)
        {
            if (ModelState.IsValid)
            {
                int result =await registration_Repository.Registration(userRegistration_Model);
                if(result > 0)
                {
                    ViewData["SuccessMessage"] = "User Registered Successfully";
                }
                else
                {

                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                    foreach(var error in errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                    ViewData["ErrorMessage"] = "Invalid Input Data";
                }
                ViewData["result"] = result;
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ExportToCsv()
        {
            var Users = await registration_Repository.GetAllUsers();
            var csvBuilder = new StringBuilder();
            csvBuilder.AppendLine("UserId,FirstName,LastName,Email,Phone");
            foreach(var user in Users)
            {
                csvBuilder.AppendLine($"{user.UserID}, {user.UserLastName}, {user.UserLastName}, {user.Email}, {user.Phone}");
            }
            var fileName = $"Users_{DateTime.Now:yyyy/MM/dd/HH:mm:ss}.csv";
            return File(Encoding.UTF8.GetBytes(csvBuilder.ToString()), "text/csv", fileName);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            if(User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserRegistration_Model userRegistration_Model)
        {
            var user = await registration_Repository.GetUserByEmail(userRegistration_Model.Email, userRegistration_Model.Password);
            if (user == null)
            {
                ViewData["ErrorMessage"] = "Please provide valid credentials.";
                return View(userRegistration_Model);
            }
            else
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name , user.UserFirstName),
                    new Claim(ClaimTypes.Email , user.Email),
                    new Claim("UserId" , user.UserID.ToString()),
                    new Claim(ClaimTypes.Role , user.Roles)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                var principle = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost ]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("SignIn", "Registration");
        }
    }
}
