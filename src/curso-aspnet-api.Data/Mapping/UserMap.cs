using curso_aspnet_api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace curso_aspnet_api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            // builder.ToTable("User");
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Email)
                .IsUnique();
            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(u => u.Email)
                .HasMaxLength(100);
        }
    }
}