using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_Kolokwium_2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Kolokwium_2.Controllers
{
    [Route("api/artists")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IDbService _service;

        public ArtistsController(IDbService service)
        {
            _service = service;
        }



        [HttpGet]
        public IActionResult Test()
        {
            return Ok("TEST COMPETED ALL OK.");

          
        }


    }
}