
using System.Collections.Generic;
using System.Linq;
using UCR.App.Dominio;

namespace UCR.App.Persistencia
{
    public class RepositorioMesa:IRepositorioMesa
    {
        private readonly AppContext _appContext;
        public RepositorioMesa(AppContext appContext)
        {
            _appContext=appContext;
        }
        Mesa IRepositorioMesa.AddMesa(Mesa mesa){
            var mesaAgregada = _appContext.Mesas.Add(mesa);
            return mesaAgregada.Entity;
        }
        void IRepositorioMesa.DeleteMesa(int idMesa ){
            var mesaEncontrada = _appContext.Mesas.FirstOrDefault(m => m.MesaId == idMesa);
            if(mesaEncontrada==null)
            return;
            _appContext.Mesas.Remove(mesaEncontrada);
            _appContext.SaveChanges();
        }
        IEnumerable<Mesa> IRepositorioMesa.GetAllMesas()
        {
            return _appContext.Mesas;
        }
        Mesa IRepositorioMesa.GetMesa(int idMesa){
            var mesaEncontrada = _appContext.Mesas.FirstOrDefault(m => m.MesaId == idMesa);
            return mesaEncontrada;
        }
        Mesa IRepositorioMesa.UpdateMesa(Mesa mesa){
            var mesaEncontrada = _appContext.Mesas.FirstOrDefault(m => m.MesaId == idMesa);
            if(mesaEncontrada!=null)
            {
                mesaEncontrada.cantidadSillas = mesa.cantidadSillas;
                mesaEncontrada.disponibilidad = mesa.disponibilidad;
                mesaEncontrada.IdTurno = mesa.IdTurno;
                _appContext.SaveChanges();
            }
        }

        
    }
}