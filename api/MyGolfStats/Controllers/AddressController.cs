#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGolfStats.Data;
using MyGolfStats.Models;

namespace MyGolfStats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly MyGolfStatsContext _context;

        public AddressController(MyGolfStatsContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllAddresses")]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddress()
        {
            return await _context.Address.ToListAsync();
        }

        [HttpGet("GetAddressByAddressID/{addressID}")]
        public async Task<ActionResult<Address>> GetAddress(int addressID)
        {
            var address = await _context.Address.FindAsync(addressID);
            if (address == null)
            {
                return NotFound();
            }

            return address;
        }

        [HttpPut("UpdateAddressByAddressID/{addressID}")]
        public async Task<IActionResult> PutAddress(int addressID, Address address)
        {
            if (addressID != address.AddressID)
            {
                return BadRequest();
            }

            _context.Entry(address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(addressID))
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

        [HttpPost("InsertAddress")]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            _context.Address.Add(address);
            await _context.SaveChangesAsync();
            return CreatedAtAction("PostAddress", new { addressID = address.AddressID }, address);
        }

        [HttpDelete("DeleteAddressByAddressID/{addressID}")]
        public async Task<IActionResult> DeleteAddress(int addressID)
        {
            var address = await _context.Address.FindAsync(addressID);
            if (address == null)
            {
                return NotFound();
            }

            _context.Address.Remove(address);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool AddressExists(int addressID)
        {
            return _context.Address.Any(e => e.AddressID == addressID);
        }
    }
}
