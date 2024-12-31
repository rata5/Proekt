using Microsoft.AspNetCore.Mvc;
using Proekt.Data.Dto;
using Proekt.Dto;
using Proekt.Services.Interfaces;

namespace Proekt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaintenanceController : ControllerBase
    {
        private readonly IMaintenanceService _maintenanceService;

        public MaintenanceController(IMaintenanceService maintenanceService)
        {
            _maintenanceService = maintenanceService;
        }

        [HttpGet]
        public IActionResult GetAllMaintenances()
        {
            var maintenances = _maintenanceService.GetAllMaintenances();
            return Ok(maintenances);
        }

        [HttpGet("{id}")]
        public IActionResult GetMaintenanceById(int id)
        {
            var maintenance = _maintenanceService.GetMaintenanceById(id);
            if (maintenance == null)
            {
                return NotFound();
            }
            return Ok(maintenance);
        }

        [HttpPost]
        public IActionResult AddMaintenance([FromBody] MaintenanceDto maintenanceDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _maintenanceService.AddMaintenance(maintenanceDto);
            return CreatedAtAction(nameof(GetMaintenanceById), new { id = maintenanceDto.Id }, maintenanceDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMaintenance(int id, [FromBody] MaintenanceDto maintenanceDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != maintenanceDto.Id)
            {
                return BadRequest("ID mismatch.");
            }

            var existingMaintenance = _maintenanceService.GetMaintenanceById(id);
            if (existingMaintenance == null)
            {
                return NotFound();
            }

            _maintenanceService.UpdateMaintenance(maintenanceDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMaintenance(int id)
        {
            var existingMaintenance = _maintenanceService.GetMaintenanceById(id);
            if (existingMaintenance == null)
            {
                return NotFound();
            }

            _maintenanceService.DeleteMaintenance(id);
            return NoContent();
        }
    }
}
