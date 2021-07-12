
using System.Collections.Generic;

namespace mantencion.Data{

    public class Mecanico{
        public int id {get; set;} 
        public string rut {get;set;}       
        public string nombre {get;set;}
        public string apellido {get;set;}

        public List<MantencionMecanico> MantencionMecanicos {get;set;}
    }
}