using System.Collections.Generic;
using UCR.App.Dominio;
using System.Linq;

namespace UCR.App.Persistencia
{
    public class RepositorioContagiado : IRepositorioContagiado
    {
        private readonly AppContext _appContext;

        public RepositorioContagiado(AppContext AppContext)
        {
            _appContext = AppContext;
        }

        //CRUD
        //AgregarContagiado
        Persona IRepositorioContagiado.AddContagiado(Persona persona)
        {
            var contagiadoAdicionado = _appContext.Contagiados.Add(persona);
            _appContext.SaveChanges();
            return contagiadoAdicionado.Entity;
        }

        //BuscarContagiado
        Persona IRepositorioContagiado.GetContagiado(int identificacion)
        {
            var contagiadoEncontrado = _appContext.Contagiados.FirstOrDefault(p => p.identificacion==identificacion);
            return contagiadoEncontrado;
        }
        
        //ActualizarContagiado
        Persona IRepositorioContagiado.UpdateContagiado(Persona persona)
        {
            var contagiadoEncontrado = _appContext.Contagiados.FirstOrDefault(p=> p.identificacion==profesor.identificacion);
            if (contagiadoEncontrado!=null)
            {
                contagiadoEncontrado.sintomas = contagiado.sintomas;
                contagiadoEncontrado.fecha = contagiado.fecha;
                contagiadoEncontrado.limiteAislamiento = contagiado.limiteAislamiento;
               

                _appContext.SaveChanges();


            }

            return contagiadoEncontrado;
        }

        //BorrarContagiado
        bool IRepositorioContagiado.DeleteContagiado(int identificacion)
        {
            var contagiadoEncontrado= _appContext.Contagiados.FirstOrDefault(p=> p.identificacion==identificacion);

            if (contagiadoEncontrado==null)
            {
                return false;
            }
            _appContext.Contagiados.Remove(contagiadoEncontrado);
            _appContext.SaveChanges();
            return true;
        }
        //BuscarContagiados
        IEnumerable<Contagiado> IRepositorioContagiado.GetAllContagiados()
        {
            return _appContext.Contagiados;
        }
    }
}
