using ApiNexti.ViewModels;

namespace ApiNexti.Service
{
    public interface IEvento
    {
        public List<EventoVM> GetAllEventos();
        public ResponseVM SetEvento(EventoVM evento);
        public ResponseVM UpdateEvento(EventoVM evento);
        public ResponseVM DeleteEvento(EventoVM evento);
    }
}
