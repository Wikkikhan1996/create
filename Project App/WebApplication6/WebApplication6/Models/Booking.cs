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
    
    public partial class Booking
    {
        public Booking()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int Booking_ID { get; set; }
        public int Customer_ID { get; set; }
        public int movi_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}