//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tuition
    {
        public int TuitionID { get; set; }
        public Nullable<int> Fee { get; set; }
        public string StatusTuition { get; set; }
        public string TuitionOfMonth { get; set; }
        public Nullable<int> StudentID { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
