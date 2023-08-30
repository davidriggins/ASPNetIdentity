using IdentityManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace IdentityManager.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            RegisterViewModel registerViewModel= new RegisterViewModel();
            return View(registerViewModel);
        }
    }
}
