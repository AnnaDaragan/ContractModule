using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractModule1.Models;
using ContractModule1.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ContractModule1.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/CompServ")]
    public class CompServController : Controller
    {
        private readonly ModuleDbContext _context;

        public CompServController(ModuleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetComp()
        {
            return Json(new { data = _context.CompanyServices.ToList() });
        }

        [HttpPost]
        public async Task<IActionResult> PostComp([FromBody] CompanyServices companyservices)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (companyservices.Id == 0)
            {
                _context.CompanyServices.Add(companyservices);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Добавлена новая запись" });
            }
            else
            {
                _context.CompanyServices.Update(companyservices);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Запись изменена" });

            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComp([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var companyservices = await _context.CompanyServices
                            .Include(c => c.Contract)
                            .Include(c => c.Service)
                            .FirstOrDefaultAsync(m => m.Id == id);

            if (companyservices == null)
            {
                return NotFound();
            }

            _context.CompanyServices.Remove(companyservices);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Запись удалена" });
        }
    }
}
