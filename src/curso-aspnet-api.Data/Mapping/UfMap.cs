using curso_aspnet_api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace curso_aspnet_api.Data.Mapping
{
    public class UfMap : IEntityTypeConfiguration<UfEntity>
    {
        public void Configure(EntityTypeBuilder<UfEntity> builder)
        {
            builder.ToTable("Ufs");
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Sigla)
                .IsUnique();
            builder.Property(u => u.Sigla)
                .IsRequired()
                .HasMaxLength(2);
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(45);
        }
    }
}