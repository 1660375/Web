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
    
    public partial class NGUOITHAN
    {
        public string MAGV { get; set; }
        public string TEN { get; set; }
        public Nullable<System.DateTime> NGSINH { get; set; }
        public string PHAI { get; set; }
    
        public virtual GIAOVIEN GIAOVIEN { get; set; }
    }
}
