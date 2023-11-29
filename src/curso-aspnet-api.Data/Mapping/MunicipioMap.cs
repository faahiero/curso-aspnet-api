using curso_aspnet_api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace curso_aspnet_api.Data.Mapping
{
    public class MunicipioMap : IEntityTypeConfiguration<MunicipioEntity>
    {
        public void Configure(EntityTypeBuilder<MunicipioEntity> builder)
        {
            builder.ToTable("Municipios");
            builder.HasKey(m => m.Id);
            builder.HasIndex(m => m.CodIBGE);
            builder.HasOne(m => m.Uf)
                .WithMany(u => u.Municipios);
            builder.Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}