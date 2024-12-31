using Microsoft.AspNetCore.Mvc;
using Proekt.Dto;
using Proekt.Services.Interfaces;

namespace Proekt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GaragesController : ControllerBase
    {
        private readonly IGaragesService _garagesService;

        public GaragesController(IGaragesService garagesService)
        {
            _garagesService = garagesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GaragesDto>> GetAllGarages()
        {
            var garages = _garagesService.GetAllGarages();
            return Ok(garages);
        }

        [HttpGet("{id}")]
        public ActionResult<GaragesDto> GetGarageById(int id)
        {
            var garage = _garagesService.GetGarageById(id);
            if (garage == null)
            {
                return NotFound();
            }
            return Ok(garage);
        }

        [HttpGet("city/{city}")]
        public ActionResult<GaragesDto> GetGarageByCity(string city)
        {
            var garage = _garagesService.GetGarageByCity(city);
            if (garage == null)
            {
                return NotFound();
            }
            return Ok(garage);
        }

        [HttpPost]
        public ActionResult AddGarage([FromBody] GaragesDto garage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _garagesService.AddGarage(garage);
            return CreatedAtAction(nameof(GetGarageById), new { id = garage.Id }, garage);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateGarage(int id, [FromBody] GaragesDto garage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != garage.Id)
            {
                return BadRequest("Garage ID mismatch.");
            }

            var existingGarage = _garagesService.GetGarageById(id);
            if (existingGarage == null)
            {
                return NotFound();
            }

            _garagesService.UpdateGarage(garage);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteGarage(int id)
        {
            var existingGarage = _garagesService.GetGarageById(id);
            if (existingGarage == null)
            {
                return NotFound();
            }

            _garagesService.DeleteGarage(id);
            return NoContent();
        }
    }
}
