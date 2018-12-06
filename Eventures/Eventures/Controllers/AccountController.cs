using System.Linq;
using AutoMapper;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EveturesUsers;
using Eventures.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace Eventures.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<EventuresUser> signIn;
        private readonly EventuresUsersService usersService;
        private readonly IMapper mapper;

        public AccountController(
            SignInManager<EventuresUser> signIn,
            EventuresUsersService usersService,
            IMapper mapper)
        {
            this.signIn = signIn;
            this.usersService = usersService;
            this.mapper = mapper;
        }


        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = this.usersService.GetByUsername(model.Username);
            this.signIn.SignInAsync(user, model.RememberMe).Wait();
            return RedirectToAction("Index", "Events", new {area ="Event"});
        }

        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            var user = this.mapper.Map<EventuresUser>(viewModel);
            //var user = new EventuresUser()
            //{
            //    Email = viewModel.Email,
            //    UserName = viewModel.Username
            //};
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
