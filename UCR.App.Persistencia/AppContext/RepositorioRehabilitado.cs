using System.Collections.Generic;
using UCR.App.Dominio;
using System.Linq;

namespace UCR.App.Persistencia
{
    public class RepositorioRehabilitado : IRepositorioRehabilitado
    {
        private readonly AppContext _appContext;

        public RepositorioRehabilitado(AppContext AppContext)
        {
            _appContext = AppContext;
        }

        //CRUD
        //AgregarRehabilitado
        Contagiado IRepositorioRehabilitado.AddRehabilitado(Contagiado contagiado)
        {
            var rehabilitadoAdicionado = _appContext.Rehabilitados.Add(contagiado);
            _appContext.SaveChanges();
            return rehabilitadoAdicionado.Entity;
        }

        //BuscarRehabilitado
        Rehabilitado IRepositorioRehabilitado.GetRehabilitado(int identificacion)
        {
            var rehabilitadoEncontrado = _appContext.Rehabilitados.FirstOrDefault(p => p.identificacion==identificacion);
            return rehabilitadoEncontrado;
        }
        
        //ActualizarRehabilitado
        Rehabilitado IRepositorioRehabilitado.UpdateRehabilitado(Rehabilitado rehabilitado)
        {
            var rehabilitadoEncontrado = _appContext.Rehabilitados.FirstOrDefault(p=> p.identificacion==profesor.identificacion);
            if (rehabilitadoEncontrado!=null)
            {
                
               

                _appContext.SaveChanges();


            }

            return rehabilitadoEncontrado;
        }

        //BorrarRehabilitado
        bool IRepositorioRehabilitado.DeleteRehabilitado(int identificacion)
        {
            var rehabilitadoEncontrado= _appContext.Rehabilitados.FirstOrDefault(p=> p.identificacion==identificacion);

            if (rehabilitadoEncontrado==null)
            {
                return false;
            }
            _appContext.Rehabilitados.Remove(rehabilitadoEncontrado);
            _appContext.SaveChanges();
            return true;
        }
        //BuscarRehabilitados
        IEnumerable<Rehabilitado> IRepositorioRehabilitado.GetAllRehabilitados()
        {
            return _appContext.Rehabilitados;
        }
    }
}