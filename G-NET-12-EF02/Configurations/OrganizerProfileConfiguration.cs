using G_NET_12_EF02.models;
using G_NET_12_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace G_NET_12_EF02.Configurations
{

    public class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.Property(x => x.Bio).HasMaxLength(500);
        }
    }
}
