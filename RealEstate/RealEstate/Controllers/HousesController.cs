﻿using System;
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
        //    return Ok(houses); //TODO: Will use a simpler way of displaying data from codemaze. Generics didnt work
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

            //if (!ModelState.IsValid)
            //{

            //}
            await _houseRepo.CreateAsync(house);

            return Created("", house);
        }
    }
}
