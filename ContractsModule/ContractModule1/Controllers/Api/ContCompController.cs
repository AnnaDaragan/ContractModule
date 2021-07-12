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
    [Route("api/ContComp")]
    public class ContCompController : Controller
    {
        private readonly ModuleDbContext _context;

        public ContCompController(ModuleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetComp()
        {
            return Json(new { data = _context.ContractCompany.ToList()});
        }

        [HttpPost]
        public async Task<IActionResult> PostComp([FromBody] ContractCompany contractcompany)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (contractcompany.Id == 0)
            {
                
                _context.ContractCompany.Add(contractcompany);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Добавлена новая запись"});
            }
            else
            {
                _context.ContractCompany.Update(contractcompany);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Запись изменена"});

            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComp([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contractcompany = await _context.ContractCompany
                            .Include(c => c.Company)
                            .FirstOrDefaultAsync(m => m.Id == id);

            if (contractcompany == null)
            {
                return NotFound();
            }

            _context.ContractCompany.Remove(contractcompany);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Запись удалена" });
        }
    }
}
