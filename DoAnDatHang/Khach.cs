//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnDatHang
{
    using System;
    using System.Collections.Generic;
    
    public partial class Khach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khach()
        {
            this.HDDatHangs = new HashSet<HDDatHang>();
        }
    
        public int MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public decimal SoDu { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public int CMND { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDDatHang> HDDatHangs { get; set; }
        public virtual Login Login { get; set; }
    }
}