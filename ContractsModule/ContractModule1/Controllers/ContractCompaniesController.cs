using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContractModule1.Models;
using ContractModule1.Models.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cloudscribe.Pagination.Models;

namespace ContractModule1.Controllers
{
    public class ContractCompaniesController : Controller
    {
        private readonly ModuleDbContext _context;

        public ContractCompaniesController(ModuleDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var moduleDbContext = _context.ContractCompany.Include(c => c.Company);
            return View(await moduleDbContext.ToListAsync());
        }

        public async Task<IActionResult> CreateOrEdit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["IDCompany"] = new SelectList(_context.Company, "Id", "Name");
                return View(new ContractCompany());
            }
            else
            {
                var contractcompany = await _context.ContractCompany.FindAsync(id);
                ViewData["IDCompany"] = new SelectList(_context.Company, "Id", "Name", contractcompany.IDCompany);
                return View(_context.ContractCompany.Where(x => x.Id.Equals(id)).FirstOrDefault());
            }
        }
    }
}
