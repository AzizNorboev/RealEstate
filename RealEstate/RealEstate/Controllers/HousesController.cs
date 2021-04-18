
using System.Threading.Tasks;
using Entities.Features;
using Entities.Models;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repository;

namespace RealEstate.Controllers
{
    [Route("api/houses")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private readonly IRepository<House> _houseRepo;

        public HousesController(IRepository<House> houseRepo)
        {
            _houseRepo = houseRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] EntityParameters entityParameters)
        {
            var houses = await _houseRepo.GetAll(entityParameters);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(houses.MetaData));
            return Ok(houses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var house = await _houseRepo.GetById(id);
            return Ok(house);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] House house)
        {
            if (house == null)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _houseRepo.Create(house);

            return Created("", house);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] House house)
        {


            var dbHouse = await _houseRepo.GetById(id);
            if (dbHouse == null)
                return NotFound();
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _houseRepo.Update(house, dbHouse);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            await _houseRepo.Delete(id);

            return NoContent();
        }
    }
}
