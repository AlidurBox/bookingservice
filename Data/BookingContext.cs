using Microsoft.EntityFrameworkCore;
using bookingservice.Models;

namespace bookingservice.Data
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }
    }
}
