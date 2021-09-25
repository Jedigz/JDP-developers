using System.Collections.Generic;
using System.Linq;
using UCR.App.Dominio;
namespace UCR.App.Persistencia
{
    public class RepositorioRestaurante:IRepositorioRestaurante
    {
        private readonly AppContext _appContext;
        public RepositorioRestaurante(AppContext appContext)
        {
            _appContext=appContext;
        }
        Mesa IRepositorioRestaurante.AddRestaurante(Restaurante restaurante){
            var restauranteAgregado = _appContext.Restaurantes.Add(restaurante);
            retunr restauranteAgregado.Entity;
        }
        void IRepositorioRestaurante.DeleteRestaurante(int idRestaurante)
        {
            var restauranteEncontrado = _appContext.Restaurante.FirstOrDefault(r => r.RestauranteId == idRestaurante);
            if(restauranteEncontrado==null)
            return ;
            _appContext.Restaurantes.Remove(restauranteEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Restaurante> IRepositorioRestaurante.GetAllRestaurantes()
        {
            return _appContext.Restaurantes;
        }
        Restaurante IRepositorioRestaurante.UpdateRestaurante(Restaurante restaurante){
            var restauranteEncontrado = _appContext.Restaurante.FirstOrDefault(r => r.RestauranteId == idRestaurante);
            if(restauranteEncontrado!=null)
            {
                restauranteEncontrado.aforo = restaurante.aforo;
                _appContext.SaveChanges();
            }
        }
    }
}