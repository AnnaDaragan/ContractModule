using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContractModule1.Models;
using ContractModule1.Models.Context;

namespace ContractModule1.Controllers.Api
{
    public class CompanyServicesController : Controller
    {
        private readonly ModuleDbContext _context;

        public CompanyServicesController(ModuleDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var moduleDbContext = _context.CompanyServices.Include(c => c.Contract).Include(c => c.Service);
            return View(await moduleDbContext.ToListAsync());
        }

        public async Task<IActionResult> CreateOrEdit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["IDContract"] = new SelectList(_context.ContractCompany, "Id", "NumberContract");
                ViewData["IDService"] = new SelectList(_context.Services, "Id", "Name");
                return View(new CompanyServices());
            }
            else
            {
                var companyServices = await _context.CompanyServices.FindAsync(id);
                ViewData["IDContract"] = new SelectList(_context.ContractCompany, "Id", "NumberContract", companyServices.IDContract);
                ViewData["IDService"] = new SelectList(_context.Services, "Id", "Name", companyServices.IDService);
                return View(_context.CompanyServices.Where(x => x.Id.Equals(id)).FirstOrDefault());
            }
        }

    }
}
