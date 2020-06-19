using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_Kolokwium_2.Requests;
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



        [HttpGet("{id}")]
        public IActionResult GetArtist(int id)
        {
            try
            {

                 return Ok(_service.GetArtist(id));

            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
            

          
        }


        [HttpPut("{id_art}/events/{id_ev}")]
        public IActionResult GetArtist(int id_art, int id_ev, UpdatePerformenceTimeRequest req)
        {
            try
            {

                return Ok(_service.UpdatePerformenceTime(id_art,id_ev, req));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }



        }


    }
}