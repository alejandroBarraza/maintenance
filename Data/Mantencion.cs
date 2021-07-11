using System;
using System.Collections.Generic;

namespace mantencion.Data
{
    public class Mantencion 
    {
        public int id {get;set;}    
        public DateTime fecha { set; get; }
        public string descripcion {get;set;}
        public List< Trabaja_en> Trabaja_Ens {get;set;}
        public List< SeUsaEn> SeUsaEns {get;set;}


    }

}