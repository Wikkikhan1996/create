//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food_Court
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int C_ID { get; set; }
    
        public virtual Food_Categary Food_Categary { get; set; }
    }
}