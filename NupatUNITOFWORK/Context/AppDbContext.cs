using Microsoft.EntityFrameworkCore;
using NupatUNITOFWORK.Model;

namespace NupatUNITOFWORK.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
    }
}
