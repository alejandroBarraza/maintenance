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

        public void OnPost(DateTime fecha, int id_mecanico){
            BaseDatos datos = new BaseDatos();

            Mantencion mantencion = new Mantencion();
            mantencion.fecha = fecha;
            mantencion.descripcion="hola como estas";
            datos.Mantencions.Add(mantencion);
            datos.SaveChanges();

            Mecanicos = datos.Mecanicos.OrderBy( m => m.nombre).ToList();

        }

    }

    
}