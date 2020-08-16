using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstituteWebApp.Models
{
    public class ReportViewModel
    {
        public int ID { get; set; }
        public int KankoorID { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string Gender { get; set; }
        public System.DateTime DOB { get; set; }
        public string POB { get; set; }
        public string NativeLanguage { get; set; }
        public string Nationality { get; set; }
        public int NID { get; set; }
        public string CellPhone { get; set; }
        public string ParentCellphone { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
    }
}