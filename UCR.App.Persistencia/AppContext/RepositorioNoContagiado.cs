using System.Collections.Generic;
using System.Linq;
using UCR.App.Dominio;

namespace UCR.App.Persistencia
{
    public class RepositorioNoContagiado:IRepositorioNoContagiado
    {
        private readonly AppContext _appContext;
        public RepositorioNoContagiado(AppContext appContext)
        {
            _appContext=appContext;
        }

        NoContagiado IRepositorioNoContagiado.AddNoContagiado(NoContagiado noContagiado)
        {
            var noContagiadoAdicionada = _appContext.NoContagiado.Add(noContagiado;
            _appContext.SaveChanges();
            return noContagiadoAdicionada.Entity;
        }
        void IRepositorioNoContagiado.DeleteNoContagiado(int identificacioNoContagiado)
        {
            var noContagiadoEncontrada = _appContext.NoContagiado.FirstOrDefault(n => n.identificacion == identificacionNoContagiado);
            if(noContagiadoEncontrada==null)
            return;
            _appContext.NoContagiado.Remove(noContagiadoEncontrada);
            _appContext.SaveChanges(); 
        }
        IEnumerable<NoContagiado> IRepositorioNoContagiado.GetAllNoContagiados()
        {
            return _appContext.NoContagiados;
        }
         NoContagiado IRepositorioNoContagiado.GetNoContagiado(int identificacionNoContagiado)
        {
            var noContagiadoEncontrada = _appContext.NoContagiados.FirstOrDefault(n => n.identificacion == identificacionNoContagiado);
            return noContagiadoEncontrada;
        }
        NoContagiado IRepositorioNoContagiado.UpdateNoContagiado(NoContagiado noContagiado)
        {
            var  noContagiadoEncontrada = _appContext.NoContagiado.FirstOrDefault(n => n.identificacion == noContagiado.identificacion);
            if(noContagiadoEncontrada !=null)
            {
                noContagiadoEncontrada.persona =noContagiado.persona;
                noContagiadoEncontrada.rehabilitados = noContagiado.rehabilitados;
                _appContext.SaveChanges();
            }
            return noContagiadoEncontrada;
        }
        
    }
}
