using System;

namespace UCR.App.Dominio 
{
    public class Turno 
    {
        public NoContagiado nocontagiado {get;set;}
        public DateTime horarioentrada  {get;set;}
        public string menu {get;set;}
        public int idmesa {get;set;}
        public int idturno {get;set;} 
    }

}

