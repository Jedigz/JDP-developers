using System.Collections.Generic;
using UCR.App.Dominio;
namespace UCR.App.Persistencia
{
    public interface IRepositorioMesa
    {
        IEnumerable<Mesa> GetAllMesas();
        Mesa AddMesa(Mesa mesa);
        Mesa UpdateMesa (Mesa mesa); 
        void DeleteMesa(int idMesa); 
        Mesa GetMesa(int idMesa);
    }
         
}