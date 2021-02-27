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
    public class HousesController : ControllerBase
    {
        private readonly IRepositoryBase<House> _houseRepo;

        public HousesController(IRepositoryBase<House> houseRepo)
        {
            _houseRepo = houseRepo;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var houses = await _houseRepo.GetAllAsync();
        //    return Ok(houses); //TODO: Will use a simpler way of displaying data. Generics didnt work
        //}

        public async Task<IActionResult> Get([FromQuery] EntityParameters entityParameters)
        {
            var houses = await _houseRepo.GetAllAsync(entityParameters);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(houses.MetaData));
            return Ok(houses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] House house)
        {
            if (house == null)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _houseRepo.CreateAsync(house);

            return Created("", house);
        }
     
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var house = await _houseRepo.GetByIdAsync(id);
            return Ok(house);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] House house)
        {
            

            var dbHouse = await _houseRepo.GetByIdAsync(id);
            if (dbHouse == null)
                return NotFound();
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _houseRepo.UpdateAsync(house, dbHouse);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            
            await _houseRepo.DeleteAsync(id);

            return NoContent();
        }
    }
}
