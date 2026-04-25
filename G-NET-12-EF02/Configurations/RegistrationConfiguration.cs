using G_NET_12_EF02.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF02.Configurations
{

    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            KeyBuilder keyBuilder = builder.HasKey(x => new { x.AttendeeId, x.EventId });

            builder.HasOne(x => x.Attendee)
                   .WithMany(static x => x.Registrations)
                   .HasForeignKey(x => x.AttendeeId);

            builder.HasOne(x => x.Event)
                   .WithMany(x => x.Registrations)
                   .HasForeignKey(x => x.EventId);
        }
    }
}
