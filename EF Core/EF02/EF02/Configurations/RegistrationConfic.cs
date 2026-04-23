using EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configurations
{
    public class RegistrationConfic : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasKey(r => new { r.AttendeeId, r.EventId });
            builder.Property(r => r.RegisteredAt).HasDefaultValueSql("GETDATE()");

            builder.HasOne(r => r.Attendee)
                .WithMany(a => a.Registrations)
                .HasForeignKey(r => r.AttendeeId);

            builder.HasOne(r => r.Event)
               .WithMany(e => e.Registrations)
               .HasForeignKey(r => r.EventId);

        }
    }
}
