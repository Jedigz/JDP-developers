using System.Collections.Generic;
using UCR.App.Dominio;


namespace UCR.App.Persistencia
{
    public interface IRepositorioContagiado
    {
        //Crud
        //AddRehabilitado
        Contagiado AddRehabilitado(Contagiado contagiado);

        //GetRehabilitado
        Rehabilitado GetRehabilitado(int identificacion);
        
        //UpdateRehabilitado
        Rehabilitado UpdateRehabilitado(Rehabilitado rehabilitado);

        //DeleteRehabilitado
        bool DeleteRehabilitado(int identificacion);
        
        //GetAllRehabilitados
        IEnumerable<Rehabilitado> GetAllRehabilitados();
    }
}