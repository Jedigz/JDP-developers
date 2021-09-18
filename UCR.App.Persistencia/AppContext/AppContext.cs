using Microsoft.EntityFrameworCore;
using UCR.App.Dominio;
namespace UCR.App.Persistencia
{
    public class AppContext{
        public DbSet<Persona> Personas{get;set;}
        public DbSet<Estudiante> Estudiantes{get;set;}
        public DbSet<Profesor> Profesores{get;set;}
        public DbSet<PersonalAseo> PersonalDeAseo{get;set;}
        public DbSet<PersonalCocina> PersonalDeConica{get;set;}
        public DbSet<Administrativo> Administrativos{get;set;}
        public DbSet<Mesa> Mesas{get;set;}
        public DbSet<Restaurante> Restaurantes{get;set;}
        public DbSet<AforoActual> AforoActualD{get;set;}
        public DbSet<Contagiado> Contagiados{get;set;}
        public DbSet<NoContagiado> NoContagiados{get;set;}
        public DbSet<Turno> Turnos{get;set;}
        public DbSet<Rehabilitado> Rehabilitados{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        if(!optionsBuilder.IsConfigured){
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = UCParking");
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=UCRestaurant; User=sa; Password=Josefer0511");
            }
        }
    }
}