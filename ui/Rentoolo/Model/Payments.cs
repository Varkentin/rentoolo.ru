//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payments
    {
        public long Id { get; set; }
        public System.Guid UserIdSender { get; set; }
        public System.Guid UserIdRecepient { get; set; }
        public double Value { get; set; }
        public System.DateTime WhenDate { get; set; }
        public string Comment { get; set; }
    }
}