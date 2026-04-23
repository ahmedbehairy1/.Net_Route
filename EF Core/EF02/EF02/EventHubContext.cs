using EF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    public class EventHubContext:DbContext
    {
        public DbSet<Address>Addresses { get; set; }
        public DbSet<Attendee> attendees { get; set; }
        public DbSet<Organizer> organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Badge> badges { get; set; }
        public DbSet<Event> events { get; set; }    
        public DbSet<Registration> registration { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Attendee>()
                       .OwnsOne(a => a.Address);
        }
    }
}
