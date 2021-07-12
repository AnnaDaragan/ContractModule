using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContractModule1.Models.Context;
using ContractModule1.Models;

namespace ContractModule1.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Comp")]
    public class CompController : Controller
    {
        private readonly ModuleDbContext _context;
        public CompController(ModuleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetComp()
        {
            return Json(new { data = _context.Company.ToList() });
        }

        [HttpPost]
        public async Task<IActionResult> PostComp([FromBody] Company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (company.Id == 0)
            {
                _context.Company.Add(company);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Добавлена новая запись" });
            }
            else
            {
                _context.Company.Update(company);
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

            var company = await _context.Company.SingleOrDefaultAsync(m => m.Id == id);

            if (company == null)
            {
                return NotFound();
            }

            _context.Company.Remove(company);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Запись удалена" });
        }
    }
}
