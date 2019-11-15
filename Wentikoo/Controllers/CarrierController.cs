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
    public class CarrierController : ControllerBase
    {
        private readonly ICarrierService carrierService;

        public CarrierController(ICarrierService carrierService)
        {
            this.carrierService = carrierService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarrier([FromBody] CarrierRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var carrier = new Carrier
            {
                Name = model.Name
            };

            await carrierService.CreateCarrier(carrier);

            return this.Created();
        }
    }
}