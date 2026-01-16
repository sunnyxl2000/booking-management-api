
using Booking.Application.DTOs;
using Booking.Application.Interfaces;
using Booking.Domain.Entities;
using Booking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Booking.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly BookingDbContext _context;
        public BookingService(BookingDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> CreateAsync(CreateBookingDto dto)
        {
            var booking = new Booking.Domain.Entities.Booking
            {
                CustomerName = dto.CustomerName,
                BookingDate = DateTime.UtcNow
            };
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking.Id;
        }
        public async Task<List<BookingDto>> GetAllAsync()
        {
            return await _context.Bookings
                .Select(b => new BookingDto
                {
                    Id = b.Id,
                    CustomerName = b.CustomerName,
                    BookingDate = b.BookingDate
                })
                .ToListAsync();
        }
    }
}
