﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BikeEntities : DbContext
    {
        public BikeEntities()
            : base("name=BikeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BodyRents> BodyRents { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Rents> Rents { get; set; }
        public virtual DbSet<TypePromotions> TypePromotions { get; set; }
        public virtual DbSet<TypeRents> TypeRents { get; set; }
    }
}
