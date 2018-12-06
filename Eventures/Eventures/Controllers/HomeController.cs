using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Eventures.Areas.Event.ViewModels;
using Eventures.Data;
using Microsoft.AspNetCore.Mvc;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresOrders.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Eventures.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventuresOrdersService ordersService;
        private readonly IMapper mapper;

        public HomeController(
            IEventuresOrdersService ordersService,
           IMapper mapper)
        {
            this.mapper = mapper;
            this.ordersService = ordersService;
        }
        public IActionResult Index()
        {
            var orders = this.ordersService.AllWithEvents().FirstOrDefault();
          //  var viewModel = mapper.Map<EventureEventViewModel>(orders);
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
