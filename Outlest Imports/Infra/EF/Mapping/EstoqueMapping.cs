using Domain.EF.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Infra.EF.Mapping
{
    public class EstoqueMapping : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMapping()
        {
            this.ToTable("Estoque", "dbo");

            this.HasKey(t => t.CodigoProduto);

            this.Property(t => t.CodigoProduto).HasDatabaseGeneratedOption(0).IsRequired().HasColumnName("ID");
            this.Property(t => t.QuantidadeProduto).IsRequired().HasColumnName("QtdProdutos");
            this.Property(t => t.Observacao).HasMaxLength(50).HasColumnName("ObsEstoque");
        }
    }
}
