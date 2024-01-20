using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DungBachComputer.Models;

namespace DungBachComputer.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly DungBachComputerContext _context;

        public SanPhamController(DungBachComputerContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var DungBachComputerContext = _context.SanPhams.Include(s => s.MaDmNavigation);
            return View(await DungBachComputerContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams
                .Include(s => s.MaDmNavigation)
                .FirstOrDefaultAsync(m => m.MaSp == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

  
    }
}
