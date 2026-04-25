using G_NET_12_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace G_NET_12_EF02.Configurations
{
    public class AttendeeConfiguration : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.Property(x => x.FullName).IsRequired();

            builder.OwnsOne(x => x.Address);
        }
    }
}
