﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL_QLSCV
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLSCLEntities3 : DbContext
    {
        public QLSCLEntities3()
            : base("name=QLSCLEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CA> CA { get; set; }
        public virtual DbSet<CATHUE> CATHUE { get; set; }
        public virtual DbSet<CHITIETDATSAN> CHITIETDATSAN { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNG { get; set; }
        public virtual DbSet<PHIEUDATSAN> PHIEUDATSAN { get; set; }
        public virtual DbSet<SAN> SAN { get; set; }
        public virtual DbSet<TINHTRANGSAN> TINHTRANGSAN { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADON { get; set; }
    }
}
