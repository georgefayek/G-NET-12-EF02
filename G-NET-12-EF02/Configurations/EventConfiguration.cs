using G_NET_12_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_NET_12_EF02.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.Property(x => x.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.HasOne(x => x.ParentEvent)
                   .WithMany(x => x.Sessions)
                   .HasForeignKey(x => x.ParentEventId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}