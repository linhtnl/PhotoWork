//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotoWork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class History
    {
        public string ID { get; set; }
        public string PhotographerID { get; set; }
        public byte[] Date { get; set; }
        public decimal MoneyOut { get; set; }
        public decimal Ramain { get; set; }
    
        public virtual Photographer Photographer { get; set; }
    }
}