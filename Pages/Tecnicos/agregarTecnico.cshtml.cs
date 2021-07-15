using System;
using System.Collections.Generic;
using mantencion.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using mantencion.RabbitMQ;

namespace mantencion.Pages.Tecnicos
{
    public class NuevoTecnicoModel : PageModel
    {
        private readonly BaseDatos datos = new BaseDatos();
        public List<Mecanico> Mecanicos; 
        
        

        public void OnPost(String nombre_tecnico, String apellido_tecnico, String rut_tecnico){
            
            Mecanicos = datos.Mecanicos.OrderBy( m => m.nombre).ToList();

            //ingresar datos a la tabla mantencion
            Mecanico mec = new Mecanico();
            mec.nombre = nombre_tecnico;
            mec.rut = rut_tecnico;
            mec.apellido = apellido_tecnico;
            datos.Mecanicos.Add(mec);      
            
            
            datos.SaveChanges();

            // QueueProducer.publicarMantencion(mecanicoEnviar, horasM, fecha.ToString().Substring(0, 10));

        }

    }

    
}