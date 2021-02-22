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
    public class RegionsController : ControllerBase
    {
        private readonly IRepositoryBase<Region> _regionRepo;

        public RegionsController(IRepositoryBase<Region> regionRepo)
        {
            _regionRepo = regionRepo;
        }

        //public async Task<IActionResult> Get()
        //{
        //    var regions = await _regionRepo.GetAllAsync();
        //    return Ok(regions);
        //}
    }
}
