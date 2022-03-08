using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        private readonly DataContext context;
        public EventoController(DataContext context)
        {
            this.context = context;
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut]
        public string Put(int id)
        {
            return $"Exemplo de post id = {id}";
        }

         [HttpDelete]
        public string Delete(int id)
        {
            return $"Exemplo de delete id = {id}";
        }
    }
}
