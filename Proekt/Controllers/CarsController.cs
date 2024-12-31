using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proekt.Dto;
using Proekt.Services.Interfaces;

namespace Proekt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAllCars()
        {
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Client")]
        public IActionResult GetCarById(int id)
        {
            var car = _carService.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddCar([FromBody] CarsDto car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _carService.AddCar(car);
            return CreatedAtAction(nameof(GetCarById), new { id = car.Id }, car);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult UpdateCar(int id, [FromBody] CarsDto car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != car.Id)
            {
                return BadRequest("ID mismatch.");
            }

            var existingCar = _carService.GetCarById(id);
            if (existingCar == null)
            {
                return NotFound();
            }

            _carService.UpdateCar(car);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteCar(int id)
        {
            var existingCar = _carService.GetCarById(id);
            if (existingCar == null)
            {
                return NotFound();
            }

            _carService.DeleteCar(id);
            return NoContent();
        }
    }
}
