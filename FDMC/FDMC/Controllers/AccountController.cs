using System.Diagnostics;
using System.Threading.Tasks;
using FDMC.Data;
using FDMC.Web.ViewModels;
using FDMC.Web.ViewModels.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.Web.Controllers
{
    public class AccountController : Controller
    {
        private FdmcDbContext context;

        public AccountController(FdmcDbContext dbContext)
        {
            this.context = dbContext;
        }

        public IActionResult Login(string returnUrl = null)
        {

            var returnUrlParsed = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            HttpContext.SignOutAsync(IdentityConstants.ExternalScheme).GetAwaiter().GetResult();

            this.TempData["ReturnUrl"] = returnUrlParsed;

            return this.View();
        } 

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var returnUrl = this.TempData["ReturnUrl"]?.ToString();
            return this.Redirect(returnUrl);
        }

        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            var we = this.TempData["ReturnUrl"];
            return null;
        }
    }
}
