﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PanasonicConexion : DbContext
    {
        public PanasonicConexion()
            : base("name=PanasonicConexion")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Anno> Anno { get; set; }
        public virtual DbSet<Bateria> Bateria { get; set; }
        public virtual DbSet<Cilindrada> Cilindrada { get; set; }
        public virtual DbSet<Inyeccion> Inyeccion { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<Master_Table> Master_Table { get; set; }
    }
}