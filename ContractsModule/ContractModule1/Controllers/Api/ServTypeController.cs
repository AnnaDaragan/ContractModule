using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractModule1.Models;
using ContractModule1.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContractModule1.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/ServType")]
    public class ServTypeController : Controller
    {
        private readonly ModuleDbContext _context;
        public ServTypeController(ModuleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetComp()
        {
            return Json(new { data = _context.ServicesType.ToList() });
        }

        [HttpPost]
        public async Task<IActionResult> PostComp([FromBody] ServiceType servicetype)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (servicetype.Id == 0)
            {
                _context.ServicesType.Add(servicetype);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Добавлена новая запись" });
            }
            else
            {
                _context.ServicesType.Update(servicetype);
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

            var servicetype = await _context.ServicesType.SingleOrDefaultAsync(m => m.Id == id);

            if (servicetype == null)
            {
                return NotFound();
            }

            _context.ServicesType.Remove(servicetype);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Запись удалена" });
        }
    }
}
