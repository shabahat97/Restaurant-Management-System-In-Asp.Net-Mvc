//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_Management_System_MVc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int ItemId { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public Nullable<int> TypeId { get; set; }
    }
}
