using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
   public IEnumerable <Evento> _evento =  new Evento[] {
        new Evento() {
          EventoId = 1,
          Tema = "Angular 11 e MET 5.0",
          Local = "Belo Horizonte",
          Lote = "1 lote",
          QtdPessoas = 250,
          DataEvento = DateTime.Now.AddDays(2).ToString(),
          ImagemURL = "foto.png"
        },
         new Evento() {
          EventoId = 2,
          Tema = "C#",
          Local = "Indaiatuba",
          Lote = "1 lote",
          QtdPessoas = 250,
          DataEvento = DateTime.Now.AddDays(2).ToString(),
          ImagemURL = "foto.png"
        }


      
      };
    
   public EventoController()
   {
    
   }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _evento;
    }   

    [HttpGet("{id}")]
    
    public IEnumerable<Evento> Get(int id)
    {
        return _evento.Where(c => c.EventoId == id);
    }

    [HttpPost("{id}")]
    public string Post(int id)
    {

      return $"Exemplo de Post = {id}";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
      return $"Exemplo de  Put = {id}";
    }

    [HttpDelete("{id}")]

    public string Delete (int id)
    {
      return $"Exemplo de  Put = {id}";
    }
}
