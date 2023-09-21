using ApiNexti.Models;
using ApiNexti.ViewModels;

namespace ApiNexti.Service
{
    public class EventoService : IEvento
    {
        private readonly NextiContext _context;
        public EventoService(NextiContext context)
        {
            this._context = context;
        }
        public List<EventoVM> GetAllEventos()
        {
            var lista = new List<EventoVM>();
            var resultado = _context.Eventos.Where(s=>s.Eliminado == false).ToList();
            foreach (var item in resultado)
            {
                EventoVM evento = new EventoVM
                {
                    DescripcionEvento = item.DescripcionEvento,
                    Eliminado = (bool)item.Eliminado,
                    FechaCreacion = (DateTime)item.FechaCreacion,
                    FechaEvento = (DateTime)item.FechaEvento,
                    FechaModificacion = (DateTime)item.FechaModificacion,
                    ID = item.Id,
                    LugarEvento = item.LugarEvento,
                    NumEntradas = (int)item.NumEntradas,
                    Precio = (decimal)item.Precio
                };
                lista.Add(evento);
            }
            return lista;
        }

        public ResponseVM SetEvento(EventoVM eventoVM)
        {
            ResponseVM respuesta = new ResponseVM();
            try
            {
                using (var context = _context.Database.BeginTransaction())
                {
                    Evento evento = new Evento
                    {
                        DescripcionEvento = eventoVM.DescripcionEvento,
                        Eliminado = true,
                        FechaCreacion = DateTime.Now,
                        FechaEvento = eventoVM.FechaEvento,
                        LugarEvento = eventoVM.LugarEvento,
                        NumEntradas = eventoVM.NumEntradas,
                        Precio = eventoVM.Precio,
                        
                    };
                    _context.Eventos.Add(evento);
                    _context.SaveChanges();
                    context.Commit();
                    respuesta.Ejecutado = true;
                }
            }
            catch (Exception ex)
            {

                respuesta.Ejecutado = false;
                respuesta.Mensaje = ex.Message;
            }

            return respuesta;
        }
        public ResponseVM UpdateEvento(EventoVM eventoVM)
        {
            ResponseVM respuesta = new ResponseVM();
            try
            {
                using (var context = _context.Database.BeginTransaction())
                {

                    var evento = _context.Eventos.Where(s=>s.Id == eventoVM.ID).FirstOrDefault();
                    if (evento != null)
                    {
                        evento.FechaEvento = eventoVM.FechaEvento;
                        evento.FechaModificacion = DateTime.Now;
                    }
                   
                      
                    _context.SaveChanges();
                    context.Commit();
                    respuesta.Ejecutado = true;
                }
            }
            catch (Exception ex)
            {

                respuesta.Ejecutado = false;
                respuesta.Mensaje = ex.Message;
            }

            return respuesta;
        }
        public ResponseVM DeleteEvento(EventoVM eventoVM)
        {
            ResponseVM respuesta = new ResponseVM();
            try
            {
                using (var context = _context.Database.BeginTransaction())
                {

                    var evento = _context.Eventos.Where(s => s.Id == eventoVM.ID).FirstOrDefault();
                    if (evento != null)
                    {
                        evento.Eliminado = true;
                        evento.FechaModificacion = DateTime.Now;
                    }


                    _context.SaveChanges();
                    context.Commit();
                    respuesta.Ejecutado = true;
                }
            }
            catch (Exception ex)
            {

                respuesta.Ejecutado = false;
                respuesta.Mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}