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
    public class CompaniesController : Controller
    {
        private readonly ModuleDbContext _context;

        public CompaniesController(ModuleDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Company.ToListAsync());
        }

        public IActionResult CreateOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Company());
            }
            else
            {
                return View(_context.Company.Where(x => x.Id.Equals(id)).FirstOrDefault());
            }
        }
    }
}
