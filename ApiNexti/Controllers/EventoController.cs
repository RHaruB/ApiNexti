using ApiNexti.Service;
using ApiNexti.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ApiNexti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : Controller
    {
        private readonly IEvento _evento;

        public EventoController(IEvento evento)
        {
            this._evento = evento;
        }

        [HttpPost("SetEvento")]
        public IActionResult SetEvento(EventoVM evento)
        {
            try
            {
                var result = _evento.SetEvento(evento);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }

        }

        [HttpPost("UpdateEvento")]
        public IActionResult UpdateEvento(EventoVM evento)
        {
            try
            {
                var result = _evento.UpdateEvento(evento);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }

        }
        [HttpPost("DeleteEvento")]
        public IActionResult DeleteEvento(EventoVM evento)
        {
            try
            {
                var result = _evento.DeleteEvento(evento);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }

        }

        [HttpGet("GetAllEventos")]
        public IActionResult GetAllEventos()
        {
            var result = _evento.GetAllEventos();
            return new JsonResult(result);
        }

    }
}
