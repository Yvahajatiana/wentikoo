using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hashdji.Software.Core.Entities;
using Hashdji.Software.Core.Interfaces.Services;
using Hashdji.Software.Wentikoo.Models;
using Hashdji.Software.Wentikoo.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hashdji.Software.Core.Enums;

namespace Wentikoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService shippingService;
        private readonly IAddressService addressService;

        public ShippingController(IShippingService shippingService, IAddressService addressService)
        {
            this.shippingService = shippingService;
            this.addressService = addressService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetShippings()
        {
            var shippings = await shippingService.GetShippingsAsync();

            return Ok(shippings.ToDtos());
        }

        [HttpGet("{guid}/details")]
        public async Task<IActionResult> GetShippings(Guid guid)
        {
            var shipping = await shippingService.GetShipping(guid);
            if(shipping == null)
            {
                return NotFound();
            }

            return Ok(shipping);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateShipping([FromBody] ShippingRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var shipping = model.CreateShipping();
            await shippingService.Create(shipping);
            await shippingService.AddAddresses(shipping, model.DepartureAddress, model.DestinationAddress);
            return this.Created();
        }

        [HttpPost("{guid}/start_shipping")]
        public async Task<IActionResult> StartShipping(Guid guid, [FromBody] ShippingStartRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var data = new Shipping
            {
                ShippingDate = model.DepartureDate,
                EstimatedDeliveryDate = model.ArrivalDate
            };

            var update = await shippingService.StartShipping(guid, data);

            return Ok(update);
        }

        [HttpPost("{guid}/delivery_shipping")]
        public async Task<IActionResult> DeliveryShipping(Guid guid)
        {
            var update = await shippingService.DeliveryShipping(guid);

            return Ok(update);
        }
        /*
        [HttpPost("{shippindGuid}/change_address/{destinationGuid}")]
        public async Task<IActionResult> ChangeAddress(Guid shippindGuid, Guid destinationGuid)
        {
            var result = await shippingService.ChangeDestination(shippindGuid, destinationGuid);

            return Ok(result);
        }*/
    }
}