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
    
    public partial class CHITIETHOADON
    {
        public Nullable<System.DateTime> ThoiGianBD { get; set; }
        public Nullable<System.DateTime> ThoiGianKT { get; set; }
        public int MaHD { get; set; }
        public int MaCaThue { get; set; }
    
        public virtual CATHUE CATHUE { get; set; }
        public virtual HOADON HOADON { get; set; }
    }
}
