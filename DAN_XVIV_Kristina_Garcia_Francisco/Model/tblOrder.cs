//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAN_XVIV_Kristina_Garcia_Francisco.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrder
    {
        public int ShoppingCartID { get; set; }
        public int TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public System.DateTime OrderCreated { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual tblUser tblUser { get; set; }
    }
}
