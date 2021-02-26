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
            var apartments = await _apartmentRepo.GetAllAsync(entityParameters);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(apartments.MetaData));
            return Ok(apartments);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] Apartment apartment)
        {
            if (apartment == null)
                return BadRequest();

            //if (!ModelState.IsValid)
            //{
              
            //}
            await _apartmentRepo.CreateAsync(apartment);

            return Created("", apartment);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var apartment = await _apartmentRepo.GetByIdAsync(id);
            return Ok(apartment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody]Apartment apartment)
        {
            //additional product and model validation checks

            var dbApartment = await _apartmentRepo.GetByIdAsync(id);
            if (dbApartment == null)
                return NotFound();

            await _apartmentRepo.UpdateAsync(apartment, dbApartment);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            

            await _apartmentRepo.DeleteAsync(id);

            return NoContent();
        }
    }
}
