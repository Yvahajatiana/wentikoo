using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hashdji.Software.Core.Interfaces.Services;
using Hashdji.Software.Wentikoo.Extensions;
using Hashdji.Software.Wentikoo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wentikoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService offerService;

        public OfferController(IOfferService offerService)
        {
            this.offerService = offerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOffers()
        {
            var offers = await offerService.GetOffersForAdmin();

            return Ok(offers);
        }

        [HttpGet("byid/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var offer = await offerService.GetOffersDetailsAsync(id);

            return Ok(offer);
        }

        [HttpGet("details/{guid}")]
        public async Task<IActionResult> Details(Guid guid)
        {
            var offer = await offerService.GetOffersDetailsAsync(guid);

            return Ok(offer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] OfferRequest offer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await offerService.UpdateOffer(id, offer.ToEntity());

            return this.Updated();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await offerService.DeleteOffer(id);

            return this.Deleted();
        }
    }
}