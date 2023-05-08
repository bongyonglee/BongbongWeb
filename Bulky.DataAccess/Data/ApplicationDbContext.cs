using Bulky.Models;
using Microsoft.EntityFrameworkCore;


namespace BongbongWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ReservationStatus> ReservationStatuses { get; set; }


    }
}
