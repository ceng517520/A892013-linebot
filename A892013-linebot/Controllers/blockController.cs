using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A892013_linebot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class blockController : ControllerBase
    {
        // GET: api/block
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/block/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/block
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/block/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/block/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
