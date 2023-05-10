using AutoShopAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly AutoContext _context;

        public CarsController(AutoContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllCars()
        {
            return Ok(await _context.Cars.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        [HttpPost]
        public async Task<ActionResult<Car>> AddCar(Car car)
        {
            /*
            if (!ModelState.IsValid) {
                return BadRequest();
            }
            */
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetCar",
                new { id = car.Id },
                car);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Cars.Any(p => p.Id == id))
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<Car>> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return car;
        }
    }
}
