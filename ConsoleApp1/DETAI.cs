//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DETAI()
        {
            this.CONGVIECs = new HashSet<CONGVIEC>();
        }
    
        public string MADT { get; set; }
        public string TENDT { get; set; }
        public string CAPQL { get; set; }
        public Nullable<double> KINHPHI { get; set; }
        public Nullable<System.DateTime> NGAYBD { get; set; }
        public Nullable<System.DateTime> NGAYKT { get; set; }
        public string MACD { get; set; }
        public string GVCNDT { get; set; }
    
        public virtual CHUDE CHUDE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGVIEC> CONGVIECs { get; set; }
        public virtual GIAOVIEN GIAOVIEN { get; set; }
    }
}
