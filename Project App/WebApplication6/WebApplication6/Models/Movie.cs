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
    
    public partial class Movie
    {
        public Movie()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int ID { get; set; }
        public int C_ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Publisher { get; set; }
        public string Director { get; set; }
        public System.DateTime Date_and_Time { get; set; }
    
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual Movie_Categary Movie_Categary { get; set; }
    }
}
