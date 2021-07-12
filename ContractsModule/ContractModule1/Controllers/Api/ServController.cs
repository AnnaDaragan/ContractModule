using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractModule1.Models.Context;
using ContractModule1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContractModule1.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Serv")]
    public class ServController : Controller
    {
        private readonly ModuleDbContext _context;
        public ServController(ModuleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetComp()
        {
            return Json(new { data = _context.Services.ToList() });
        }

        [HttpPost]
        public async Task<IActionResult> PostComp([FromBody] Service services)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (services.Id == 0)
            {
                _context.Services.Add(services);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Добавлена новая запись" });
            }
            else
            {
                _context.Services.Update(services);
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

            var services = await _context.Services
                .Include(s => s.ServiceType)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (services == null)
            {
                return NotFound();
            }

            _context.Services.Remove(services);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Запись удалена" });
        }
    }
}
