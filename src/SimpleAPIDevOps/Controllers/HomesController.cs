using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace SimpleAPIDevOps.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class HomesController : ControllerBase
    {
         List<string> L1 = new List<string>() { "Hello", "world" };
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
               
            return new string[] {"Hello","world"};
        } 
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
              
            return "Hello world";
            
        }

    }
}