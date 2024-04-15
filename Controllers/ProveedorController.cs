using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("/[controller]")]
[ApiController]
public class ProveedoresController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProveedoresController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Proveedores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Proveedor>>> GetProveedores()
    {
        return await _context.Proveedores.OrderBy(p => p.UltimaEdicion).ToListAsync();
    }

    // POST: api/Proveedores
    [HttpPost]
    public async Task<ActionResult<Proveedor>> PostProveedor(Proveedor proveedor)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Proveedores.Add(proveedor);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetProveedor", new { id = proveedor.Id }, proveedor);
    }

    // PUT: api/Proveedores/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutProveedor(int id, Proveedor proveedor)
    {
        if (id != proveedor.Id)
        {
            return BadRequest();
        }

        _context.Entry(proveedor).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ProveedorExists(id))
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

    // DELETE: api/Proveedores/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Proveedor>> DeleteProveedor(int id)
    {
        var proveedor = await _context.Proveedores.FindAsync(id);
        if (proveedor == null)
        {
            return NotFound();
        }

        _context.Proveedores.Remove(proveedor);
        await _context.SaveChangesAsync();

        return proveedor;
    }

    private bool ProveedorExists(int id)
    {
        return _context.Proveedores.Any(e => e.Id == id);
    }
}
