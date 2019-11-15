using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hashdji.Software.Core.Entities;
using Hashdji.Software.Core.Interfaces.Services;
using Hashdji.Software.Wentikoo.Extensions;
using Hashdji.Software.Wentikoo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wentikoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly ITripService tripService;

        public TripController(ITripService tripService)
        {
            this.tripService = tripService;
        }

        public async Task<IActionResult> GetTrips()
        {
            var trips = await tripService.GetTrips();

            return Ok(trips.ToList()); 
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrip([FromBody] TripRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var trip = new Trip();
            await tripService.CreateTrip(trip, model.CarrierId);

            return this.Created();
        }

        [HttpPost("{guid}/add_shippings")]
        public async Task<IActionResult> AddShippings(Guid guid, [FromBody] List<Guid> shippinGuids)
        {
            await tripService.AddShippings(guid, shippinGuids);
            return Ok();
        }
    }
}