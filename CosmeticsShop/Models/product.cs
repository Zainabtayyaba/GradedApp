//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CosmeticsShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int prodId { get; set; }
        public int catId { get; set; }
        public string pName { get; set; }
        public string pImage { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
    
        public virtual category category { get; set; }
    }
}
