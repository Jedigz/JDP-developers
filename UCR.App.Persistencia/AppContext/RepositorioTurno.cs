using System.Collections.Generic;
using System.Linq;
using UCR.App.Dominio;

namespace UCR.App.Persistencia
{
    public class RepositorioTurno:IRepositorioTurno
    {
        private readonly AppContext _appContext;
        public RepositorioTurno(AppContext appContext)
        {
            _appContext=appContext;
        }

        Turno IRepositorioTurno.AddTurno(Turno turno)
        {
            var turnoAdicionada = _appContext.Turnos.Add(turno);
            _appContext.SaveChanges();
            return turnoAdicionada.Entity;
        }
        void IRepositorioTurno.DeleteTurno(int identificacionTurno)
        {
            var turnoEncontrada = _appContext.Turnos.FirstOrDefault(t => t.identificacion == identificacionTurno);
            if(turnoEncontrada==null)
            return;
            _appContext.Turnos.Remove(turnoEncontrada);
            _appContext.SaveChanges(); 
        }
        IEnumerable<Turno> IRepositorioTurno.GetAllTurnos()
        {
            return _appContext.Turnos;
        }
         Turno IRepositorioTurno.GetTurno(int identificacionTurno)
        {
            var turnoEncontrada = _appContext.Turnos.FirstOrDefault(t => t.identificacion == identificacionTurno);
            return turnoEncontrada;
        }
        Turno IRepositorioTurno.UpdateTurno(Turno turno)
        {
            var  turnoEncontrada = _appContext.Turno.FirstOrDefault(t => t.identificacion == turno.identificacion);
            if(turnoEncontrada !=null)
            {
                turnoEncontrada.noContagiados = turno.noContagiados;
                turnoEncontrada.horarioEntrada = turno.horarioEntrada;
                turnoEncontrada.menu = turno.menu;
                turnoEncontrada.mesa = turno.mesa;
                turnoEncontrada.idturno = turno.idturno;
                _appContext.SaveChanges();
            }
            return turnoEncontrada;
        }
        
    }
}
