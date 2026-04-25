using G_NET_12_EF02.Configurations;
using G_NET_12_EF02.models;
using G_NET_12_EF02.Models;
using Microsoft.EntityFrameworkCore;

namespace G_NET_12_EF02.Data
{
    public class EventHubDbContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=EventHubDb;Trusted_Connection=True;TrustServerCertificate=True"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrganizerConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizerProfileConfiguration());
            ModelBuilder modelBuilder1 = modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new AttendeeConfiguration());
            modelBuilder.ApplyConfiguration(new BadgeConfiguration());
            modelBuilder.ApplyConfiguration(new RegistrationConfiguration());
        }
    }
}