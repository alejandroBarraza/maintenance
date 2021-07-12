namespace mantencion.Data{

    public class MantencionMaterial{

        public int id{get;set;}     
        public int id_mantencion {get;set;}
        public Mantencion mantencion {get;set;}  
        public int id_material {get;set;}
        public Material material {get;set;}
        public int cantidad{get;set;}
       

    }
   
}