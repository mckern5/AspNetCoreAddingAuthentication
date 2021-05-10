using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WishList.Models;
using Microsoft.AspNetCore.Identity;
using WishList.Models.AccountViewModels;


namespace WishList.Controllers
{   
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userMan, SignInManager<ApplicationUser> signMan)
        {
            _userManager = userMan;
            _signInManager = signMan;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegisterViewModel rvm)

        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("HomeController.Index");
            }
            else
            {
                return View(rvm);
            }
        }

        

        public IActionResult Index()
        {
            return View();
        }
    }
}
