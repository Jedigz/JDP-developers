using System.Collections.Generic;
using UCR.App.Dominio;

namespace UCR.App.Persistencia
{
    public interface IRepositorioPersona
    {
        // CRUD
        Persona AddPersona(Persona persona); 
        Persona GetPersona(int identificacionPersona); 
        Persona UpdatePersona(Persona persona);     
        bool DeletePersona(int identificacionPersona); 
        IEnumerable<Persona> GetAllPersonas(); 

    }
}
