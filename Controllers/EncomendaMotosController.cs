using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Atividade_Almir_Api.Model;
using Microsoft.AspNetCore.Authorization;

namespace Atividade_Almir_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class EncomendaMotosController : ControllerBase
    {
        private readonly Contexto _context;

        public EncomendaMotosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/EncomendaMotos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EncomendaMoto>>> GetEncomendaMotos()
        {
            return await _context.EncomendaMotos.ToListAsync();
        }

        // GET: api/EncomendaMotos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EncomendaMoto>> GetEncomendaMoto(int id)
        {
            var encomendaMoto = await _context.EncomendaMotos.FindAsync(id);

            if (encomendaMoto == null)
            {
                return NotFound();
            }

            return encomendaMoto;
        }

        // PUT: api/EncomendaMotos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEncomendaMoto(int id, EncomendaMoto encomendaMoto)
        {
            if (id != encomendaMoto.Id)
            {
                return BadRequest();
            }

            _context.Entry(encomendaMoto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EncomendaMotoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EncomendaMotos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EncomendaMoto>> PostEncomendaMoto(EncomendaMotoDTO dto)
        {
            var cliente = await _context.Clientes.FindAsync(dto.ClienteId);
            if (cliente == null)
            {
                return BadRequest("Cliente não encontrado.");
            }

            var encomendaMoto = new EncomendaMoto
            {
                Modelo = dto.Modelo,
                Cor = dto.Cor,
                CEP = dto.CEP,
                Logradouro = dto.Logradouro,
                Bairro = dto.Bairro,
                Localidade = dto.Localidade,
                UF = dto.UF,
                ClienteId = dto.ClienteId,
                Cliente = cliente
            };

            _context.EncomendaMotos.Add(encomendaMoto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEncomendaMoto", new { id = encomendaMoto.Id }, encomendaMoto);
        }

        // DELETE: api/EncomendaMotos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEncomendaMoto(int id)
        {
            var encomendaMoto = await _context.EncomendaMotos.FindAsync(id);
            if (encomendaMoto == null)
            {
                return NotFound();
            }

            _context.EncomendaMotos.Remove(encomendaMoto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EncomendaMotoExists(int id)
        {
            return _context.EncomendaMotos.Any(e => e.Id == id);
        }
    }
}
