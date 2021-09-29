using System.Collections.Generic;
using UCR.App.Dominio;

namespace UCR.App.Persistencia
{
    public interface IRepositorioTurno
    {
        // CRUD
        Turno AddTurno(Turno turno); 
        Turno GetTurno(int identificacionTurno); 
        Turno UpdateTurno(Turno turno);     
        bool DeleteTurno(int identificacionTurno); 
        IEnumerable<Turno> GetAllTurno(); 

    }
}
