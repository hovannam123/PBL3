//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblHoaDonBanHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHoaDonBanHang()
        {
            this.tblChiTietHoaDonBanHangs = new HashSet<tblChiTietHoaDonBanHang>();
        }
    
        public string MaHoaDonBan { get; set; }
        public string MaNhanVien { get; set; }
        public Nullable<System.DateTime> NgayBan { get; set; }
        public string MaKhachHang { get; set; }
        public Nullable<double> SoTien { get; set; }
        public Nullable<double> GiamGia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietHoaDonBanHang> tblChiTietHoaDonBanHangs { get; set; }
        public virtual tblKhachHang tblKhachHang { get; set; }
        public virtual tblNguoiDung tblNguoiDung { get; set; }
    }
}