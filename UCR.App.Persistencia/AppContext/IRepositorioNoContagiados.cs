using System.Collections.Generic;
using UCR.App.Dominio;

namespace UCR.App.Persistencia
{
    public interface IRepositorioNoContagiado
    {
        // CRUD
        NoContagiado AddNoContagiado(NoContagiado noContagiado); 
        NoContagiado GetNoContagiado(int identificacionNoContagiado); 
        NoContagiado UpdateNoContagiado(NoContagiado noContagiado);     
        bool DeleteNoContagiado(int identificacionNoContagiado); 
        IEnumerable<NoContagiado> GetAllNoContagiados(); 

    }
}
