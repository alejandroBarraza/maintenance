using System;
using System.Collections.Generic;
using mantencion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace mantencion.Pages{

    public class MaterialesModel : PageModel {

        public List<Material> materiales;
        public List<Mantencion> mantenciones;
        public List<MantencionMaterial> mantencionMaterial;

        public void Onget(){
            getData();
        }



        public void getData(){
            BaseDatos baseDatos = new BaseDatos();


            mantenciones = baseDatos.Mantencions.OrderBy( m => m.id).ToList();
            materiales = baseDatos.Matarials.OrderBy( m => m.nombreMaterial).ToList();
            mantencionMaterial = baseDatos.MantencionMaterials.OrderBy( m => m.id).ToList();

        }
    }
}