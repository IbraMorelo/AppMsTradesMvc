﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MsTradeEntities : DbContext
    {
        public MsTradeEntities()
            : base("name=MsTradeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServicioHost>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ServicioHost");
            });

            modelBuilder.Entity<ServicioComision>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ServicioComision");
            }); 

            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<ServicioComision> ServicioComision { get; set; }
        public DbSet<ServicioHost> ServicioHost { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
