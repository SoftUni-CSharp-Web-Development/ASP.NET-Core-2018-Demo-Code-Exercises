using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Data;
using FDMC.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.Controllers
{
    public class HomeController : Controller
    {
        private FdmcDbContext context;

        public HomeController(FdmcDbContext dbContext)
        {
            this.context = dbContext;
        }

        public IActionResult Index()
        {
          //  context.Users.All(u => u.Nickname == "")
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
