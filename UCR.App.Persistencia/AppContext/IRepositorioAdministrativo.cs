using System.Collections.Generic;
using UCR.App.Dominio;

namespace UCR.App.Persistencia
{
    public interface IRepositorioAdministrativo
    {
        // CRUD
        Administrativo AddAdministrativo(Administrativo administrativo); 
        Administrativo GetAdministrativo(int identificacionAdministrativo); 
        Administrativo UpdateAdministrativo(Administrativo administrativo);     
        bool DeleteAdministrativo(int identificacionAdministrativo); 
        IEnumerable<Administrativo> GetAllAdministrativos(); 

    }
}
