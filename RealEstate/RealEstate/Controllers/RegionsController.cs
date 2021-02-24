using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Features;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRepositoryBase<Region> _regionRepo;

        public RegionsController(IRepositoryBase<Region> regionRepo)
        {
            _regionRepo = regionRepo;
        }

        //public async Task<IActionResult> Get()
        //{
        //    var regions = await _regionRepo.GetAllAsync();
        //    return Ok(regions);
        //}

        public async Task<IActionResult> Get([FromQuery] EntityParameters entityParameters)
        {
            var regions = await _regionRepo.GetAllAsync(entityParameters);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(regions.MetaData));
            return Ok(regions);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] Region region)
        {
            if (region == null)
                return BadRequest();

            //if (!ModelState.IsValid)
            //{

            //}
            await _regionRepo.CreateAsync(region);

            return Created("", region);
        }
    }
}
