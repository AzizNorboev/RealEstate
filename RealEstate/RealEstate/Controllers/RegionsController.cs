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
    [Route("api/regions")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRepository<Region> _regionRepo;

        public RegionsController(IRepository<Region> regionRepo)
        {
            _regionRepo = regionRepo;
        }

        public async Task<IActionResult> GetAll([FromQuery] EntityParameters entityParameters)
        {
            var regions = await _regionRepo.GetAll(entityParameters);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(regions.MetaData));
            return Ok(regions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var region = await _regionRepo.GetById(id);
            return Ok(region);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Region region)
        {
            if (region == null)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _regionRepo.Create(region);

            return Created("", region);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Region region)
        {


            var dbRegion = await _regionRepo.GetById(id);
            if (dbRegion == null)
                return NotFound();
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _regionRepo.Update(region, dbRegion);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {


            await _regionRepo.Delete(id);

            return NoContent();
        }
    }
}
