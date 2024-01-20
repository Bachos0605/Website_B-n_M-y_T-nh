using DungBachComputer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DungBachComputer.Controllers
{
    public class HomeController : Controller
    {
        private readonly DungBachComputerContext _context;

        public HomeController(DungBachComputerContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var DungBachComputerContext = _context.SanPhams.Include(s => s.MaDmNavigation);
            return View(await DungBachComputerContext.ToListAsync());
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
