using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    internal class MeetingRoomEntityConfiguration : IEntityTypeConfiguration<MeetingRoomEntity>
    {
        public void Configure(EntityTypeBuilder<MeetingRoomEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Capacity);

            builder.Property(p => p.Name)
                .HasMaxLength(127);
        }
    }
}
