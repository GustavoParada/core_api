using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSoft.Domain.Entitites;

namespace Nextsoft.Infra.Data.Mapping
{
    public class MoradorMap : IEntityTypeConfiguration<Morador>
    {
        public void Configure(EntityTypeBuilder<Morador> builder)
        {
            builder.ToTable("Morador");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id_Familia)
                .IsRequired()
                .HasColumnName("Id_Familia");

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Nome");

            builder.Property(c => c.QuantidadeBichosEstimação)
                .IsRequired()
                .HasColumnName("QuantidadeBichosEstimacao");
        }
    }
}
