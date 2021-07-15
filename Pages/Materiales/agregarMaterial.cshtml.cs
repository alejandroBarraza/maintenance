using System;
using System.Collections.Generic;
using mantencion.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using mantencion.RabbitMQ;

namespace mantencion.Pages.Materiales
{
    public class NuevoMaterialModel : PageModel
    {
        private readonly BaseDatos datos = new BaseDatos();
        public List<Material> Materiales;
        public void OnPost(String nombre_material, int cantidad_material){
            
            Materiales = datos.Matarials.OrderBy( m => m.id).ToList();
           
            
            //ingresar datos a la tabla material
            Material material = new Material();
            material.nombreMaterial = nombre_material;
            material.cantidad=cantidad_material;
            datos.Matarials.Add(material);
            datos.SaveChanges();

          //  QueueProducer.publicarMantencion(mecanicoEnviar, horasM, fecha.ToString().Substring(0, 10));

        }

    }

    
}