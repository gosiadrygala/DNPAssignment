using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Mvc;
using Models;
using WebAPI.Repositories.Children;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChildrenController : ControllerBase
    {
        private IChildrenRepo childrenRepo = new ChildrenRepo();
        [HttpGet]
        public async Task<ActionResult<IList<Child>>> GetAllChildren()
        {
            try
            {
                IList<Child> children = new List<Child>();
                children = await childrenRepo.GetAllChildren();
                return Ok(children);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
            
        }
    }
}