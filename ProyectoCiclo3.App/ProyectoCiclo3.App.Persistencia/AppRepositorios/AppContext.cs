using System;
using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio.Entidades;


namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Estacion> Estaciones { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DBTransportes");
            }
        }
         
    }
    
}
