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
    
    public partial class Ticket
    {
        public int Ticket_ID { get; set; }
        public int Ticket_No { get; set; }
        public int Th_ID { get; set; }
        public int B_ID { get; set; }
        public int Seat_ID { get; set; }
        public int Seat_No { get; set; }
        public System.DateTime Show_Date { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Seat Seat { get; set; }
    }
}
