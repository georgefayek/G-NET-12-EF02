using G_NET_12_EF02.models;
using G_NET_12_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_NET_12_EF02.Configurations
{

    public class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            builder.HasOne(x => x.OrganizerProfile)
                   .WithOne(x => x.Organizer)
                   .HasForeignKey<OrganizerProfile>(x => x.OrganizerId);

            builder.HasMany(x => x.Events)
                   .WithOne(x => x.Organizer)
                   .HasForeignKey(x => x.OrganizerId);
        }
    }
}
