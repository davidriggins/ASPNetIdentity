using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Controllers
{
    public class AccessCheckerController : Controller
    {
        // Access by everyone, even if user is not logged in
        public IActionResult AllAccess()
        {
            return View();
        }


        // Access by logged in user.
        public IActionResult AuthorizedAccess()
        {
            return View();
        }


        // Access by users who have user role
        public IActionResult UserAccess()
        {
            return View();
        }


        // Access by users who have admin role
        public IActionResult AdminAccess()
        {
            return View();
        }


        // Access by Admin users with the claim of create to be true
        public IActionResult Admin_CreateAccess()
        {
            return View();
        }


        // Access by Admin user with claim of Create, Edit and Delete
        public IActionResult Admin_Create_Edit_DeleteAccess()
        {
            return View();
        }

        // Access by Admin user with Create, Edit and Delete, OR if the user is superAdmin
        public IActionResult Admin_Create_Edit_DeleteAccess_SuperAdmin()
        {
            return View();
        }
    }
}
