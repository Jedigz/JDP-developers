using System.Collections.Generic;
using UCR.App.Dominio;


namespace UCR.App.Persistencia
{
    public interface IRepositorioContagiado
    {
        //CRUD
        //AddContagiado
        Persona AddContagiado(Persona persona);

        //GetContagiado
        Persona GetContagiado(int identificacion);
        
        //UpdateContagiado
        Persona UpdateContagiado(Persona persona);

        //DeleteContagiado
        bool DeleteContagiado(int identificacion);

        //GetAllContagiados
        IEnumerable<Contagiado> GetAllContagiados();
    }
}
