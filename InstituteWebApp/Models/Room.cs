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
    
    public partial class Room
    {
        public int ID { get; set; }
        public int HostelID { get; set; }
        public int ToolsID { get; set; }
        public int FloorNo { get; set; }
    
        public virtual Hostel Hostel { get; set; }
        public virtual Tool Tool { get; set; }
    }
}
