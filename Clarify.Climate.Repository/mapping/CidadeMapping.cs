using Clarify.Climate.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clarify.Climate.Repository.mapping
{
    public class CidadeMapping : EntityTypeConfiguration<Cidade>
    {
        public CidadeMapping()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.EstadoId)
                .IsRequired();

            this.ToTable("Cidade");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EstadoId).HasColumnName("EstadoId");
            this.Property(t => t.Nome).HasColumnName("Nome");

            this.HasRequired(t => t.Estado)
                .WithMany(x => x.CidadeList)
                .HasForeignKey(t => t.EstadoId);
        }
    }
}
