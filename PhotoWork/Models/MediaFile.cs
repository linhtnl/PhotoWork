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
    
    public partial class MediaFile
    {
        public string ID { get; set; }
        public string Location { get; set; }
        public string ServiceID { get; set; }
    
        public virtual Service Service { get; set; }
    }
}
