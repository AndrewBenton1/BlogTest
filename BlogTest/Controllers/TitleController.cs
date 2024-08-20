using BlogTest.FileUitls;
using BlogTest.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitleController : ControllerBase
    {
        // GET: api/<TitleController>
        [HttpGet]
        public List<Title> GetAll()
        {
            List<Title> list = TitleRead.GetTitles();

            return list;
        }

        // GET api/<TitleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TitleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TitleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TitleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
