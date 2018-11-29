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
using Microsoft.EntityFrameworkCore;

namespace Eventures.Controllers
{
    public class HomeController : Controller
    {
        private readonly EventuresDbContext _context;
        private readonly IMapper _mapper;

        public HomeController(EventuresDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var orders = _context.Orders.Include(o => o.Event).FirstOrDefault();
            var viewModel = _mapper.Map<EventureEventViewModel>(orders);
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
