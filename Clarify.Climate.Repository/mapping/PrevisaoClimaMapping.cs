using Clarify.Climate.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Clarify.Climate.Repository.mapping
{
    public class PrevisaoClimaMapping : EntityTypeConfiguration<PrevisaoClima>
    {
        public PrevisaoClimaMapping()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.CidadeId)
                .IsRequired();

            this.Property(t => t.DataPrevisao)
                .IsRequired();

            this.Property(t => t.Clima)
                .HasMaxLength(15)
                .IsRequired();

            this.Property(t => t.TemperaturaMinima)
                .HasPrecision(2, 2)
                .IsRequired();

            this.Property(t => t.TemperaturaMaxima)
                .HasPrecision(2, 2)
                .IsRequired();

            this.ToTable("PrevisaoClima");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CidadeId).HasColumnName("CidadeId");
            this.Property(t => t.DataPrevisao).HasColumnName("DataPrevisao");
            this.Property(t => t.Clima).HasColumnName("Clima");
            this.Property(t => t.TemperaturaMinima).HasColumnName("TemperaturaMinima");
            this.Property(t => t.TemperaturaMaxima).HasColumnName("TemperaturaMaxima");

            this.HasRequired(t => t.Cidade)
                .WithMany(t => t.PrevisaoClimaList)
                .HasForeignKey(t => t.CidadeId);
        }
    }
}
