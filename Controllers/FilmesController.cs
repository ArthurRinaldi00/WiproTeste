using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wiproTeste.Model;
using wiproTeste.Service;


namespace wiproTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly IFilmeService FilmeService;
        public FilmesController()
        {
            FilmeService = new FilmeService();
        }

        // GET: api/<Cliente>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(FilmeService.GetFilme());
        }

        // GET api/<filme>/5
        [HttpGet("{Titulo}")]
        public IActionResult GetFilme(string Titulo)
        {
            return Ok(FilmeService.GetFilme(Titulo));
        }

        // POST api/<filme>
        [HttpPost]
        public IActionResult Post([FromBody] Filme entity)
        {
            FilmeService.Add(entity);
            return Ok();
        }

        // PUT api/<filme
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<filme
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
