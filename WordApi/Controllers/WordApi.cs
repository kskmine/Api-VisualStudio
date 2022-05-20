using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordApi : ControllerBase
    {
        WordDbContext _context;
        public WordApi(WordDbContext context)
        {
            _context = context;
        }
        // GET: api/<WordApi>
        [HttpGet]
        public IEnumerable<WordDefinition> Get()
        {
            return _context.WordDefinitions.ToList();
        }

        // GET api/<WordApi>/5
        [HttpGet("{id}")]
        public WordDefinition Get(int id)
        {
            return _context.WordDefinitions.First(c => c.Id == id);
        }

        // POST api/<WordApi>
        [HttpPost]
        public void Post([FromBody] WordDefinition entity)
        {
            _context.WordDefinitions.Add(entity);
            _context.SaveChanges();
        }

        // PUT api/<WordApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WordDefinition entity)
        {
            entity.Id = id;
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

        }

        // DELETE api/<WordApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deleted = _context.WordDefinitions.First(c => c.Id == id);
            _context.Remove(deleted);
            _context.SaveChanges();
        }
    }
}
