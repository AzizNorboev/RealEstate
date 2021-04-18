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
    [Route("api/apartments")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly IRepository<Apartment> _apartmentRepo;


        public ApartmentsController(IRepository<Apartment> apartmentRepo)
        {
            _apartmentRepo = apartmentRepo;
        }

        //Using FromQuery coz we use query parameters to define which page
        //and how many entities on a single we are requesting
        public async Task<IActionResult> GetAll([FromQuery] EntityParameters entityParameters)
        {
            var apartments = await _apartmentRepo.GetAll(entityParameters);
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(apartments.MetaData));
            return Ok(apartments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var apartment = await _apartmentRepo.GetById(id);
            return Ok(apartment);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Apartment apartment)
        {
            if (apartment == null)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _apartmentRepo.Create(apartment);
            return Created("", apartment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Apartment apartment)
        {


            var dbApartment = await _apartmentRepo.GetById(id);
            if (dbApartment == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _apartmentRepo.Update(apartment, dbApartment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {


            await _apartmentRepo.Delete(id);

            return NoContent();
        }
    }
}
