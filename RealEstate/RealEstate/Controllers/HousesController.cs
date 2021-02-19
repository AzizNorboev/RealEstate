using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private readonly IHouseRepository _repo;

        public HousesController(IHouseRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var houses = await _repo.GetHouses();
            return Ok(houses); //TODO: Will use a simpler way of displaying data from codemaze. Generics didnt work
        }
    }
}
