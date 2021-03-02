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
    
    public partial class Invoice
    {
        public string ID { get; set; }
        public string PaymentMethod { get; set; }
        public string Contract { get; set; }
        public string ServiceID { get; set; }
        public string ClientID { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public string process { get; set; }
        public Nullable<System.DateTime> RealitySubmitDate { get; set; }
        public string ContentFeedback { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public Nullable<int> Rating { get; set; }
        public string FileReportLocation { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Service Service { get; set; }
    }
}