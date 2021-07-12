using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContractModule1.Models;
using ContractModule1.Models.Context;

namespace ContractModule1.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ModuleDbContext _context;

        public ServicesController(ModuleDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var moduleDbContext = _context.Services.Include(s => s.ServiceType);
            return View(await moduleDbContext.ToListAsync());
        }

        public async Task<IActionResult> CreateOrEdit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["IDServiceType"] = new SelectList(_context.ServicesType, "Id", "Name");
                return View(new Service());
            }
            else
            {
                var service = await _context.Services.FindAsync(id);
                ViewData["IDServiceType"] = new SelectList(_context.ServicesType, "Id", "Name", service.IDServiceType);
                return View(_context.Services.Where(x => x.Id.Equals(id)).FirstOrDefault());
            }
        }
    }
}
