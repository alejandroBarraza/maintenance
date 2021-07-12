using System.Collections.Generic;
namespace mantencion.Data{

    public class Material{

        public int id{get;set;}
        public string nombreMaterial {get;set;}
        public int cantidad {get;set;}
        public List<MantencionMaterial> MantencionMaterials {get;set;}
        
     

    }
   
} 