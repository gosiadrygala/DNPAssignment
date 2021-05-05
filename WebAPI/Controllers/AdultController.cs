using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Models;
using WebAPI.Repositories.Adult;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
       
        private IAdultRepo adultRepo = new AdultRepo();
        
        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAllAdults()
        {
            try
            {
                IList<Adult> adultsCopy = await adultRepo.GetAllAdults();
                return Ok(adultsCopy);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
            
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAnAdult([FromBody] Adult adult)
        {
            try
            {
                await adultRepo.AddAnAdult(adult);
                return Created($"/{adult.Id}", adult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]

        public async Task<ActionResult> RemoveAnAdult([FromRoute] int id)
        {
            try
            {
                await adultRepo.RemoveAnAdult(id);
                return Ok(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}