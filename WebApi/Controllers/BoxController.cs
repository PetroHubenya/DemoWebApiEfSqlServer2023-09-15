using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoxController : ControllerBase
    {
        private readonly BoxService _service;

        public BoxController(BoxService service)
        {
            _service = service;
        }

        // GET: api/<BoxController>
        [HttpGet]
        public Task Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BoxController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BoxController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BoxController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BoxController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
