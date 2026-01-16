

using Booking.Application.DTOs;

namespace Booking.Application.Interfaces
{
    public interface IBookingService
    {
        Task<Guid> CreateAsync(CreateBookingDto dto);

        Task<List<BookingDto>> GetAllAsync();

    }
}
