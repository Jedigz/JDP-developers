using System;
namespace UCR.App.Dominio
{ 
  public class Restaurante
  {
    public int RestauranteId{get;set;}
    public int aforo{get;set;}
    public System.collections.Generic.List<Turno> turnos{get;set;}
    public System.collections.Generic.List<Mesa> mesas{get;set;}
    public void RevisarDisponibilidad()
    
    {
      Console.WriteLine("aun es necesario implementar esta clase");
    }
    public void LlenarMesa()
    {
      Console.WriteLine("aun es necesario implementar esta clase");
    }
    
  
  }
}
