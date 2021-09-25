using System.Collections.Generic;
using UCR.App.Dominio;


namespace UCR.App.Persistencia
{
    public interface IRepositorioRehabilitado
    {
        //Crud
        //AddRehabilitado
        Persona AddRehabilitado(Persona persona);

        //GetRehabilitado
        Persona GetRehabilitado(int identificacion);
        
        //UpdateRehabilitado
        Persona UpdateRehabilitado(Persona persona);

        //DeleteRehabilitado
        bool DeleteRehabilitado(int identificacion);
        
        //GetAllRehabilitados
        IEnumerable<Rehabilitado> GetAllRehabilitados();
    }
}
