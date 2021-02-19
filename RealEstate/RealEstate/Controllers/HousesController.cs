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
        private readonly IRepositoryBase<House> _houseRepo;

        public HousesController(IRepositoryBase<House> houseRepo)
        {
            _houseRepo = houseRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var houses = await _houseRepo.GetAllAsync();
            return Ok(houses); //TODO: Will use a simpler way of displaying data from codemaze. Generics didnt work
        }
    }
}
