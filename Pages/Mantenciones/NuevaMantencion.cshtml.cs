using System;
using System.Collections.Generic;
using mantencion.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using mantencion.RabbitMQ;

namespace mantencion.Pages
{
    public class NuevaMantencionModel : PageModel
    {
        private readonly BaseDatos datos = new BaseDatos();
        public List<Mecanico> Mecanicos; 
        public List<Material> Materiales;
        
        public void Onget(){

            // Se carga la lista con los mecanicos 
            Mecanicos = datos.Mecanicos.OrderBy( m => m.nombre).ToList();
            Materiales = datos.Matarials.OrderBy( m => m.nombreMaterial).ToList();
        }

        public void OnPost(DateTime fecha, int id_mecanico,int cantidad_material,string descripcion, int horasM, int id_material){
            
            Mecanicos = datos.Mecanicos.OrderBy( m => m.nombre).ToList();
            Materiales = datos.Matarials.OrderBy( m => m.nombreMaterial).ToList();
           
            Mecanico mecanicoEnviar = Mecanicos.Find( x => x.id == id_mecanico);
            
            //ingresar datos a la tabla mantencion
            Mantencion mantencion = new Mantencion();
            mantencion.fecha = fecha;
            mantencion.descripcion=descripcion;
            datos.Mantencions.Add(mantencion);

            // Actualizar cantidad de material

            Material resultado = datos.Matarials.FirstOrDefault(x => x.id == id_material);
            if(resultado != null){
                resultado.cantidad = resultado.cantidad - cantidad_material;
                datos.SaveChanges();
            }

            // // inresar a mantencion material
            MantencionMaterial manMaterial = new MantencionMaterial();
            manMaterial.id_mantencion = mantencion.id;
            manMaterial.id_material = id_material;
            manMaterial.cantidad = cantidad_material;
            datos.MantencionMaterials.Add(manMaterial);



            // ingresar a mantencion mecanico
            MantencionMecanico manMecanico = new MantencionMecanico();
            manMecanico.id_mantencion = mantencion.id;
            manMecanico.id_mecanico = id_mecanico;
            manMecanico.horas = horasM;
            datos.MantencionMecanicos.Add(manMecanico);         
            
            
            datos.SaveChanges();

            QueueProducer.publicarMantencion(mecanicoEnviar, horasM, fecha.ToString().Substring(0, 10));

        }

    }

    
}