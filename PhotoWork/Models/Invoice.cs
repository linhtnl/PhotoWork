﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel;

    public partial class Invoice
    {
        [DisplayName("Mã Hóa Đơn")]
        public string ID { get; set; }
        [DisplayName("Phương Thức Thanh Toán")]
        public string PaymentMethod { get; set; }
        [DisplayName("Hợp Đồng")]
        public string Contract { get; set; }
        [DisplayName("Mã Dịch Vụ")]
        public string ServiceID { get; set; }
        [DisplayName("Email Khách Hàng")]
        public string ClientID { get; set; }
        [DisplayName("Ngày Bắt Đầu Dịch Vụ")]
        public Nullable<System.DateTime> DateEnd { get; set; }
        [DisplayName("Ngày Hoàn Thành Dự Kiến ")]
        public Nullable<System.DateTime> DateStart { get; set; }
        [DisplayName("Trạng Thái Của Hóa Đơn")]
        public string process { get; set; }
        [DisplayName("Ngày Kết Thúc Dịch Vụ")]
        public Nullable<System.DateTime> RealitySubmitDate { get; set; }
        [DisplayName("Lời Đánh Giá")]
        public string ContentFeedback { get; set; }
        [DisplayName("Ngày Tố Cáo")]
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public Nullable<int> Rating { get; set; }
        [DisplayName("File Tố Cáo")]
        public string FileReportLocation { get; set; }
        [DisplayName("Email Photographer")]
        public string PhotographerID { get; set; }
        public virtual Client Client { get; set; }
        public virtual Service Service { get; set; }
    }
}
