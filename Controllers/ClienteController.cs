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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService clienteService;
        public ClienteController()
        {
            clienteService = new ClienteService();
        }
        // GET: api/<Cliente>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(clienteService.GetCliente());
        }

        // GET api/<Cliente>/5
        [HttpGet("{IdCliente}")]
        public IActionResult GetCliente(string IdCliente)
        {
            return Ok(clienteService.GetCliente(IdCliente));
        }

        // POST api/<Cliente>
        [HttpPost]
        public IActionResult Post([FromBody] Cliente entity)
        {
            clienteService.Add(entity);
            return Ok();
        }

        // DELETE api/<Cliente>/5
        [HttpDelete]
        public IActionResult Delete(string idCliente)
        {
            return Ok(clienteService.Desativacao(idCliente));
        }
    }
}
