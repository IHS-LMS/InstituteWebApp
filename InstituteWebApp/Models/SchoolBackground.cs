//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstituteWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SchoolBackground
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLocation { get; set; }
        public System.DateTime GraduationDate { get; set; }
        public byte[] GraduationCertificate { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
