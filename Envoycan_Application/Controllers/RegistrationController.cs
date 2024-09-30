using Envoycan_Application.Models;
using Envoycan_Application.Repository;
using Microsoft.AspNetCore.Mvc;

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
                ViewData["result"] = result;
            }
            return View();
        }
     
      
    }
}
