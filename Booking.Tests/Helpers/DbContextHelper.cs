using Booking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Booking.Tests.Helpers
{
    public static class DbContextHelper
    {
        public static BookingDbContext CreateInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<BookingDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new BookingDbContext(options);
        }
    }
}
