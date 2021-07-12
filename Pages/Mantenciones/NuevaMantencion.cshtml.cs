using System;
using System.Collections.Generic;
using mantencion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace mantencion.Pages.Mantenciones{
    public class NuevaMantencionModel : PageModel
    {
        public List<Mecanico> Mecanicos; 
        
        public void Onget(){
            BaseDatos datos = new BaseDatos();

             // Se carga la lista con los mecanicos 
            Mecanicos = datos.Mecanicos.OrderBy( m => m.nombre).ToList();
            
        }

        public void OnPost(DateTime fecha, int id_mecanico,string nombre_material,int cantidad_material,string descripcion){
            BaseDatos datos = new BaseDatos();


            //ingresar datos a la tabla mantencion
            Mantencion mantencion = new Mantencion();
            mantencion.fecha = fecha;
            mantencion.descripcion=descripcion;
            datos.Mantencions.Add(mantencion);
            
            //ingresar datos a la tabla materiales 
            Material material = new Material();
            material.nombreMaterial = nombre_material;
            material.cantidad = cantidad_material;
            datos.Matarials.Add(material);
            datos.SaveChanges();


            // // inresar a mantencion material
            // MantencionMaterial manMaterial = new MantencionMaterial();


            // ingresar a mantencion mecanico
            // MantencionMecanico manMecanico = new MantencionMecanico();
            
            
            

            Mecanicos = datos.Mecanicos.OrderBy( m => m.nombre).ToList();

        }

    }

    
}