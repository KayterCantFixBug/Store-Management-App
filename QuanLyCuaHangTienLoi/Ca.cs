//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCuaHangTienLoi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ca()
        {
            this.PhanCongs = new HashSet<PhanCong>();
        }
    
        public string MaCa { get; set; }
        public int LoaiCa { get; set; }
        public System.TimeSpan GioBatDau { get; set; }
        public System.TimeSpan GioKetThuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCong> PhanCongs { get; set; }
    }
}