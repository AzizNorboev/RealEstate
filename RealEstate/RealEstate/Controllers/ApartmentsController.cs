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
    public class ApartmentsController : ControllerBase
    {
        private readonly IRepositoryBase<Apartment> _apartmentRepo;


        public ApartmentsController(IRepositoryBase<Apartment> apartmentRepo)
        {
            _apartmentRepo = apartmentRepo;
        }

        //public async Task<IActionResult> Get()
        //{
        //    var apartments = await _apartmentRepo.GetAllAsync();
        //    return Ok(apartments);
        //}
        public async Task<IActionResult> Get([FromQuery] EntityParameters entityParameters)
        {
            var products = await _apartmentRepo.GetAllAsync(entityParameters);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(products.MetaData));
            return Ok(products);
        }
    }
}