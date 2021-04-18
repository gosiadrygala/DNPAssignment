using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChildrenController : ControllerBase
    {
        
        private IList<Family> families = new List<Family>();
        private IList<Child> children = new List<Child>();
        private FileContext fileContext = new FileContext();

        public ChildrenController()
        {
            families = fileContext.Families;
        }
        
        [HttpGet]
        public async Task<ActionResult<IList<Child>>> GetAllChildren()
        {
            try {
                foreach (var item in families)
                {
                    for (int i = 0; i < item.Children.Count; i++)
                    {
                        children.Add(item.Children[i]);
                    }
               
                }
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