﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleManagement.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class N3KTeamEntities : DbContext
    {
        public N3KTeamEntities()
            : base("name=N3KTeamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblChiTietHoaDonBanHang> tblChiTietHoaDonBanHangs { get; set; }
        public virtual DbSet<tblChiTietHoaDonNhapHang> tblChiTietHoaDonNhapHangs { get; set; }
        public virtual DbSet<tblHangHoa> tblHangHoas { get; set; }
        public virtual DbSet<tblHoaDonBanHang> tblHoaDonBanHangs { get; set; }
        public virtual DbSet<tblHoaDonNhapHang> tblHoaDonNhapHangs { get; set; }
        public virtual DbSet<tblKhachHang> tblKhachHangs { get; set; }
        public virtual DbSet<tblLoaiHangHoa> tblLoaiHangHoas { get; set; }
        public virtual DbSet<tblNhaCungCap> tblNhaCungCaps { get; set; }
        public virtual DbSet<tblNhaSanXuat> tblNhaSanXuats { get; set; }
        public virtual DbSet<sysdiagram1> sysdiagram1 { get; set; }
        public virtual DbSet<tblNguoiDung> tblNguoiDungs { get; set; }
    }
}