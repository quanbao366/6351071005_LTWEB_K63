//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _6351071005_LTWEB_K63.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHAPHANPHOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAPHANPHOI()
        {
            this.XEGANMAYs = new HashSet<XEGANMAY>();
        }
    
        public int MaNPP { get; set; }
        public string TenNPP { get; set; }
        public string Diachi { get; set; }
        public string DienThoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XEGANMAY> XEGANMAYs { get; set; }
    }
}
