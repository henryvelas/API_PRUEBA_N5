using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PRUEBA.Models;
using PRUEBA_API.Data;

namespace PRUEBA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsTypesController : ControllerBase
    {
        private readonly PRUEBA_APIContext _context;

        public PermissionsTypesController(PRUEBA_APIContext context)
        {
            _context = context;
        }

        // GET: api/PermissionsTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PermissionsTypes>>> GetPermissionsTypes()
        {
            return await _context.PermissionsTypes.ToListAsync();
        }

        // GET: api/PermissionsTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PermissionsTypes>> GetPermissionsTypes(int id)
        {
            var permissionsTypes = await _context.PermissionsTypes.FindAsync(id);

            if (permissionsTypes == null)
            {
                return NotFound();
            }

            return permissionsTypes;
        }

        // PUT: api/PermissionsTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPermissionsTypes(int id, PermissionsTypes permissionsTypes)
        {
            if (id != permissionsTypes.Id_permissiontypes)
            {
                return BadRequest();
            }

            _context.Entry(permissionsTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PermissionsTypesExists(id))
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

        // POST: api/PermissionsTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PermissionsTypes>> PostPermissionsTypes(PermissionsTypes permissionsTypes)
        {
            _context.PermissionsTypes.Add(permissionsTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPermissionsTypes", new { id = permissionsTypes.Id_permissiontypes }, permissionsTypes);
        }

        // DELETE: api/PermissionsTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PermissionsTypes>> DeletePermissionsTypes(int id)
        {
            var permissionsTypes = await _context.PermissionsTypes.FindAsync(id);
            if (permissionsTypes == null)
            {
                return NotFound();
            }

            _context.PermissionsTypes.Remove(permissionsTypes);
            await _context.SaveChangesAsync();

            return permissionsTypes;
        }

        private bool PermissionsTypesExists(int id)
        {
            return _context.PermissionsTypes.Any(e => e.Id_permissiontypes == id);
        }
    }
}
