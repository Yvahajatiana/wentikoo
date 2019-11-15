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
    public class AddressController : ControllerBase
    {
        private readonly IAddressService addressService;

        public AddressController(IAddressService addressService)
        {
            this.addressService = addressService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await addressService.GetAddressesAsync();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddressRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await addressService.Create(model.ToEntity());

            return this.Created();
        }
    }
}