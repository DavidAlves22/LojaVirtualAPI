using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using LojaVirtualAPI.Context;
using Microsoft.EntityFrameworkCore;
using LojaVirtualAPI.Domain;

namespace LojaVirtualAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : Controller
    {
        private readonly LojaVirtualContext _context;

        public VendasController(LojaVirtualContext context)
        {
            _context = context;
        }

        // GET: api/Vendas
        [HttpGet]
        public async Task<IActionResult> GetVendas()
        {
            var vendas = await _context.Vendas.AsNoTracking().Include(x => x.Cliente).Include(x => x.ItensVenda).ThenInclude(p=>p.Produto).ToListAsync();
            return Ok(vendas);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetVendaPorId(int id)
        {
            var venda = await _context.Vendas.FindAsync(id);
            if (venda == null)
            {
                return NotFound();
            }
            return Ok(venda);
        }

        // POST: api/Vendas
        [HttpPost]
        public async Task<IActionResult> PostVenda([FromBody] Venda venda)
        {
            if (venda == null)
            {
                return BadRequest("Venda não pode ser nula.");
            }
            _context.Vendas.Add(venda);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVendaPorId), new { id = venda.Id }, venda);
        }

        // PUT: api/Vendas/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutVenda([FromBody] Venda venda)
        {
            if (venda == null)
            {
                return BadRequest("Venda não pode ser nula.");
            }

            if (venda.Id <= 0)
            {
                return BadRequest("ID da venda não corresponde ao ID fornecido.");
            }

            _context.Entry(venda).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
