using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
        private IList<Adult> adults = new List<Adult>();
        private FileContext fileContext = new FileContext();


        public AdultController() {
            adults = fileContext.Adults;
        }


        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAllAdults()
        {
            try {
                List<Adult> adultsCopy = new List<Adult>(adults);
                foreach (var VARIABLE in adults)
                {
                    Console.WriteLine(VARIABLE);
                }
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
                int max = adults.Max(adult => adult.Id);
                adult.Id = (++max);
                adults.Add(adult);
                fileContext.SaveChanges();
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
                Adult adult = adults.First(adult => adult.Id == id);
                adults.Remove(adult);
                fileContext.SaveChanges();
                return Ok(adult.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}