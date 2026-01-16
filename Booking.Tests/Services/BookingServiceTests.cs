using Booking.Application.DTOs;
using Booking.Application.Services;
using Booking.Tests.Helpers;
using FluentAssertions;

namespace Booking.Tests.Services
{
    public class BookingServiceTests
    {
        [Fact]
        public async Task CreateBooking_ShouldReturnBookingId()
        {
            // Arrange
            var dbContext = DbContextHelper.CreateInMemoryDbContext();
            var bookingService = new BookingService(dbContext);
            var createBookingDto = new CreateBookingDto
            {
                CustomerName = "Test User"
            };

            // Act
            var result = await bookingService.CreateAsync(createBookingDto);

            // Assert
            result.Should().NotBeEmpty();
            dbContext.Bookings.Count().Should().Be(1);
        }

        [Fact]
        public async Task GetAllBookings_ShouldReturnListOfBookings()
        {
            // Arrange
            var dbContext = DbContextHelper.CreateInMemoryDbContext();
            var service = new BookingService(dbContext);
            await service.CreateAsync(new CreateBookingDto
            {
                CustomerName = "User 1"
            });
            await service.CreateAsync(new CreateBookingDto
            {
                CustomerName = "User 2"
            });

            // Act
            var result = await service.GetAllAsync();

            // Assert
            result.Should().HaveCount(2);
            result.Should().Contain(b => b.CustomerName == "User 1");
            result.Should().Contain(b => b.CustomerName == "User 2");
        }
    }
}
