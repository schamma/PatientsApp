using Microsoft.EntityFrameworkCore;
using PatientsApp.Server.Entities;
using System.Text.RegularExpressions;

namespace PatientsApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AllergyChecks> AllergyChecks { get; set; }
        public DbSet<FollowUps> FollowUps { get; set; }
        public DbSet<Screenings> Screenings { get; set; }
    }
}
