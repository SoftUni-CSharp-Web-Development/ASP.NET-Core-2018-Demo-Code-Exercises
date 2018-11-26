﻿using System.Linq;
using Eventures.Models;
using Eventures.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace Eventures.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<EventuresUser> signIn;

        public AccountController(
            SignInManager<EventuresUser> signIn)
        {
            this.signIn = signIn;
        }


        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = this.signIn.UserManager.Users.FirstOrDefault(u => u.UserName == model.Username);
            this.signIn.SignInAsync(user, model.RememberMe).Wait();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            var user = new EventuresUser()
            {
                Email = viewModel.Email,
                UserName = viewModel.Username
            };
            var result = this.signIn.UserManager.CreateAsync(user, viewModel.Password).Result;

            if (result.Succeeded)
            {
                this.signIn.SignInAsync(user, false).Wait();
                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }
    }
}
