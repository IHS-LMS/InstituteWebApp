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
    
    public partial class Address
    {
        public int ID { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public int StreetNo { get; set; }
        public int HouseNo { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
