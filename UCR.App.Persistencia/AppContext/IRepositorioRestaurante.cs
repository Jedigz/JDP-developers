using System.Collections.Generic;
using UCR.App.Dominio;
namespace UCR.App.Persistencia
{
    public interface IRepositorioRestaurante
    {
        IEnumerable<Restaurante> GetAllRestaurantes();
        Restaurante AddRestaurante(Restaurante restaurante);
        Restaurante UpdateRestaurante(Restaurante restaurante );
        void DeleteRestaurante(int idRestaurante);
        Restaurante GetMesa(int idRestaurante);
    }
}