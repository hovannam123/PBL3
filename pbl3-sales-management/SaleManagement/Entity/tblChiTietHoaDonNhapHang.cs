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
    
    public partial class tblChiTietHoaDonNhapHang
    {
        public string MaHoaDonNhap { get; set; }
        public string MaHangHoa { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> GiaNhap { get; set; }
        public Nullable<double> TongTien { get; set; }
    
        public virtual tblHangHoa tblHangHoa { get; set; }
        public virtual tblHoaDonNhapHang tblHoaDonNhapHang { get; set; }
    }
}