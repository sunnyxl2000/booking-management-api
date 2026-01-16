using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime BookingDate { get; set; }
        public string CustomerName { get; set; } = string.Empty;
    }
}
