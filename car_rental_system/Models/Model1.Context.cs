﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace car_rental_system.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarRentalDBEntities : DbContext
    {
        public CarRentalDBEntities()
            : base("name=CarRentalDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<carreg> carregs { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<rentail> rentails { get; set; }
        public virtual DbSet<returncar> returncars { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
