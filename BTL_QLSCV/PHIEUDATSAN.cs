//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PHIEUDATSAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDATSAN()
        {
            this.CHITIETDATSANs = new HashSet<CHITIETDATSAN>();
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public int MaPhieu { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<int> MaKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDATSAN> CHITIETDATSANs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
