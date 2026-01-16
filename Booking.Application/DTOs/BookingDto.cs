
namespace Booking.Application.DTOs
{
    public class BookingDto
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public DateTime BookingDate { get; set; }
    }
}
