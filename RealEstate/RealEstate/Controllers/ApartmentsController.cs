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
    public class ApartmentsController : ControllerBase
    {
        private readonly IRepositoryBase<Apartment> _apartmentRepo;


        public ApartmentsController(IRepositoryBase<Apartment> apartmentRepo)
        {
            _apartmentRepo = apartmentRepo;
        }

        public async Task<IActionResult> Get()
        {
            var apartments = await _apartmentRepo.GetAllAsync();
            return Ok(apartments);
        }
    }
}
