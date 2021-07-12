using System;
using System.Collections.Generic;

namespace mantencion.Data
{
    public class Mantencion 
    {
        public int id {get;set;}    
        public DateTime fecha { set; get; }
        public string descripcion {get;set;}
        public List<MantencionMecanico> MantencionMecanicos {get;set;}
        public List<MantencionMaterial> MantencionMaterials {get;set;}


    }

}