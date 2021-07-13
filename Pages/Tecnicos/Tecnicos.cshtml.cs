using System;
using System.Collections.Generic;
using mantencion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace mantencion.Pages{

    public class MecanicosModel : PageModel {

        public List<Mecanico> mecanicos;
        public List<Mantencion> mantencions;
        public List<MantencionMecanico> mantencionMecanicos;

        public void Onget(){
            getData();
        }

        

        public void getData(){
            BaseDatos baseDatos = new BaseDatos();


            mantencions = baseDatos.Mantencions.OrderBy( m => m.id).ToList();
            mecanicos = baseDatos.Mecanicos.OrderBy( m => m.nombre).ToList();
            mantencionMecanicos = baseDatos.MantencionMecanicos.OrderBy( m => m.id).ToList();
        }
    }
}