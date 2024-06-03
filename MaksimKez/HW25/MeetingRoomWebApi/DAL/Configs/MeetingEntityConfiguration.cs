using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    internal class MeetingEntityConfiguration : IEntityTypeConfiguration<MeetingEntity>
    {
        public void Configure(EntityTypeBuilder<MeetingEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .HasMaxLength(255);

            builder.Property(p => p.StartTime);

            builder.Property(p => p.EndTime);

            builder.HasOne(p => p.MeetingRoom)
                .WithMany()
                .HasForeignKey(p => p.MeetingRoomId);
        }
    }
}
