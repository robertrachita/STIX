using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Stix_Mongo_API.Models;
using Stix_Mongo_API.Services;

namespace Stix_Mongo_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidentController : ControllerBase
    {
        private readonly IncidentService _incidentService;

        public IncidentController(IncidentService incidentService)
        {
            _incidentService = incidentService;
        }

        [HttpGet]
        public async Task<List<Incident>> Get() =>
            await _incidentService.GetAllIncidents();
            
        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Incident>> Get(string id)
        {
            var incident = await _incidentService.GetIncident(id);

            if (incident is null)
            {
                return NotFound();
            }

            return incident;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Incident incident)
        {
            await _incidentService.CreateIncident(incident);

            return CreatedAtAction(nameof(Get), new { id = incident.Id.ToString() }, incident);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Incident incidentIn)
        {
            var incident = await _incidentService.GetIncident(id);

            if (incident is null)
            {
                return NotFound();
            }

            await _incidentService.UpdateIncident(id, incidentIn);

            return Accepted();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var incident = await _incidentService.GetIncident(id);

            if (incident is null)
            {
                return NotFound();
            }

            await _incidentService.RemoveIncident(id);

            return NoContent();
        }
    }
}
