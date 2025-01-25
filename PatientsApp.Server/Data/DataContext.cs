using Microsoft.EntityFrameworkCore;
using PatientsApp.Server.Entities;

namespace PatientsApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
