using System.Collections.Generic;
using System.Linq;
using UCP.App.Dominio;

namespace UCP.App.Persistencia
{
    public class RepositorioAdministrativo:IRepositorioAdministrativo
    {
        private readonly AppContext _appContext;
        public RepositorioAdministrativo(AppContext appContext)
        {
            _appContext=appContext;
        }

        Administrativo IRepositorioAdministrativo.AddAdministrativo(Administrativo administrativo)
        {
            var administrativoAdicionada = _appContext.Administrativo.Add(administrativo);
            _appContext.SaveChanges();
            return administrativoAdicionada.Entity;
        }
        void IRepositorioAdministrativo.DeleteAdministrativo(int identificacionAdministrativo)
        {
            var administrativoEncontrada = _appContext.Administrativo.FirstOrDefault(a => a.identificacion == identificacionAdministrativo);
            if(administrativoEncontrada==null)
            return;
            _appContext.Administrativo.Remove(administrativoEncontrada);
            _appContext.SaveChanges(); 
        }
        IEnumerable<Administrativo> IRepositorioAdministrativo.GetAllAdministrativos()
        {
            return _appContext.Administrativos;
        }
         Administrativo IRepositorioAdministrativo.GetAdministrativo(int identificacionAdministrativo)
        {
            var administrativoEncontrada = _appContext.Administrativo.FirstOrDefault(a => a.identificacion == identificacionAdministrativo);
            return administrativoEncontrada;
        }
        Administrativo IRepositorioAdministrativo.UpdateAdministrativo(Administrativo administrativo)
        {
            var  administrativoEncontrada = _appContext.Administrativo.FirstOrDefault(a => a.identificacion == administrativo.identificacion);
            if(administrativoEncontrada !=null)
            {
                administrativoEncontrada.dependencia = administrativo.dependencia;
                administrativoEncontrada.oficina = administrativo.oficina;
                
                _appContext.SaveChanges();
            }
            return administrativoEncontrada;
        }
        
    }
}
