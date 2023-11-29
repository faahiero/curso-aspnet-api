using curso_aspnet_api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace curso_aspnet_api.Data.Mapping
{
    public class CepMap : IEntityTypeConfiguration<CepEntity>
    {
        public void Configure(EntityTypeBuilder<CepEntity> builder)
        {
            builder.ToTable("Ceps");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Cep)
                .IsUnique();
            builder.Property(c => c.Cep)
                .IsRequired()
                .HasMaxLength(10);
            builder.Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(10);
            builder.Property(c => c.Cep)
                .IsRequired()
                .HasMaxLength(10);
            builder.HasOne(c => c.Municipio)
                .WithMany(m => m.Ceps);
        }
    }
}