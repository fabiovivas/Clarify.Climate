using Clarify.Climate.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Clarify.Climate.Repository.mapping
{
    public class EstadoMapping : EntityTypeConfiguration<Estado>
    {
        public EstadoMapping()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.UF)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(200);

            this.ToTable("Estado");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UF).HasColumnName("UF");
            this.Property(t => t.Nome).HasColumnName("Nome");
        }
    }
}
