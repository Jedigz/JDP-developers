using System.Collections.Generic;
using UCR.App.Dominio;
using System.Linq;

namespace UCR.App.Persistencia
{
    public class RepositorioPersona:IRepositorioPersona
    {
        private readonly AppContext _appContext;
        public RepositorioPersona(AppContext appContext)
        {
            _appContext=appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionada = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionada.Entity;
        }
        void IRepositorioPersona.DeletePersona(int identificacionPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.identificacion == identificacionPersona);
            if(personaEncontrada==null)
            return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges(); 
        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }
         Persona IRepositorioPersona.GetPersona(int identificacionPersona)
        {
            
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.identificacion == identificacionPersona);
            return personaEncontrada;
        }
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var  personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.identificacion == persona.identificacion);
            if(personaEncontrada !=null)
            {
                personaEncontrada.nombre = persona.nombre;
                personaEncontrada.apellidos = persona.apellidos;
                personaEncontrada.identificacion = persona.identificacion;
                personaEncontrada.edad = persona.edad;
                personaEncontrada.estadoCovid= persona.estadoCovid;
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
        
    }
}
