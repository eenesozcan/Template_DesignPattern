﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Template_DesignPattern.DAL.Entities;
using Template_DesignPattern.Models;

namespace Template_DesignPattern.Controllers
{
    public class LoginController : Controller
    {

        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
