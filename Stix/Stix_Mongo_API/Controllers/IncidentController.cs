using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
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

        [HttpGet("GetAllIncidents.{format}"), FormatFilter]
        public async Task<List<Incident>> Get() =>
            await _incidentService.GetAllIncidents();

        //[HttpGet("{id:length(24)}")]
        [HttpGet("GetIncident.{id:length(24)}.{format}"), FormatFilter]
        public async Task<ActionResult<Incident>> Get(string id)
        { 
            var incident = await _incidentService.GetIncident(id);

            if (incident is null)
            {
                return NotFound();
            }

            return incident;
        }
        //write logic for xml
        //[HttpPost("PostIncident.{format}"), FormatFilter]
        [HttpPost("PostIncident")]
        public async Task<IActionResult> Post(Incident incident)
        {
            incident.Pending = true;
            try
            {
                await _incidentService.CreateIncident(incident);
            }
            catch (MongoWriteException e)
            {
                return BadRequest(e.WriteError.Message);
            }

            return CreatedAtAction(nameof(Get), new { id = incident.Id.ToString() }, incident);
        }

        [HttpPost("PostIncidentList")]
        public async Task<IActionResult> PostList(List<Incident> incidents)
        {
            foreach (Incident incident in incidents)
            {
                incident.Pending = true;
                await _incidentService.CreateIncident(incident);
            }

            return Accepted();
            //return CreatedAtAction(nameof(Get), new { id = incident.Id.ToString() }, incident);
        }

        [HttpPut("UpdateIncidents.{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Incident incidentIn)
        {
            var incident = await _incidentService.GetIncident(id);

            if (incident is null)
            {
                return NotFound();
            }

            incidentIn.Pending = true;
            incidentIn.Id = incident.Id;

            await _incidentService.UpdateIncident(id, incidentIn);

            return Accepted();
        }

        [HttpDelete("DeleteIncident.{id:length(24)}")]
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
