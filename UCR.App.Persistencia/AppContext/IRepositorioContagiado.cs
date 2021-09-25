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
        Contagiado GetContagiado(int identificacion);
        
        //UpdateContagiado
        Contagiado UpdateContagiado(Contagiado contagiado);

        //DeleteContagiado
        bool DeleteContagiado(int identificacion);

        //GetAllContagiados
        IEnumerable<Contagiado> GetAllContagiados();
    }
}