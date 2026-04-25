using G_NET_12_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_NET_12_EF02.Configurations
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.Property(x => x.Tier)
                   .HasConversion<string>();

            builder.HasOne(x => x.Attendee)
                   .WithOne(x => x.Badge)
                   .HasForeignKey<Badge>(x => x.AttendeeId);
        }
    }
}