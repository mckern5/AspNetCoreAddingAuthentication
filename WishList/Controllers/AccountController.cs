using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WishList.Models;
using Microsoft.AspNetCore.Identity;

namespace WishList.Controllers
{   
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        private AccountController(UserManager<ApplicationUser> userMan, SignInManager<ApplicationUser> signMan)
        {
            _userManager = userMan;
            _signInManager = signMan;
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
