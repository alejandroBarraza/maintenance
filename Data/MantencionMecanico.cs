namespace mantencion.Data{

    public class MantencionMecanico{

        public int id {get;set;}
        public int id_mantencion {get;set;}
        public Mantencion mantencion{get;set;}
        public int id_mecanico {get;set;}
        public Mecanico mecanico {get;set;}
        public float horas {get;set;}
       

    }
   
} 