﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DapurBucyn
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bucynEntities : DbContext
    {
        public bucynEntities()
            : base("name=bucynEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bahan> bahans { get; set; }
        public virtual DbSet<bahan_nasi> bahan_nasi { get; set; }
        public virtual DbSet<detail_penggunaan> detail_penggunaan { get; set; }
        public virtual DbSet<detail_penjualan> detail_penjualan { get; set; }
        public virtual DbSet<nasi> nasis { get; set; }
        public virtual DbSet<pembelian_bahan> pembelian_bahan { get; set; }
        public virtual DbSet<penggunaan> penggunaans { get; set; }
        public virtual DbSet<penjualan> penjualans { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
