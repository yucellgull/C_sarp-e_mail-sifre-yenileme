﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormOturumAcmaİslemleri.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WindowsFormOturumAcmaİslemleriEntitiesConnectionDB : DbContext
    {
        public WindowsFormOturumAcmaİslemleriEntitiesConnectionDB()
            : base("name=WindowsFormOturumAcmaİslemleriEntitiesConnectionDB")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        
    
        public virtual DbSet<PersonelGisisTablosu> PersonelGisisTablosu { get; set; }
    }
}
