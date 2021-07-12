using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace mantencion.Data{
    public class BaseDatos: DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer( @"Server=.\SQLEXPRESS;Database=mantencionDB;Integrated Security=True");
        }

        public DbSet<Mantencion> Mantencions { get; set; }
        public DbSet<MantencionMaterial> MantencionMaterials { get; set; }
        public DbSet<MantencionMecanico> MantencionMecanicos { get; set; }
        public DbSet<Material> Matarials { get; set; }
        public DbSet<Mecanico> Mecanicos { get; set; }
      
    }

}