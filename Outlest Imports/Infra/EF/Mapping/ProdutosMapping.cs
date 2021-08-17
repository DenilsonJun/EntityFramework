using Domain.EF.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Infra.EF.Mapping
{
    public class ProdutosMapping : EntityTypeConfiguration<Produtos>
    {
        public ProdutosMapping()
        {
            this.ToTable("Produtos");
            this.HasKey(t => t.Codigo);

            this.Property(t => t.Codigo).IsRequired().HasColumnName("ID");
            this.Property(t => t.Nome).IsRequired().HasMaxLength(50).HasColumnName("Nome");
            this.Property(t => t.Descricao).IsRequired().HasMaxLength(50).HasColumnName("Descricao");
            this.Property(t => t.Compra).IsRequired().HasColumnName("VlrCompra");
            this.Property(t => t.Venda).IsRequired().HasColumnName("VlrVenda");
            this.Property(t => t.Marca).IsRequired().HasMaxLength(50).HasColumnName("Marca");
            this.Property(t => t.Modelo).IsRequired().HasMaxLength(50).HasColumnName("Modelo");
        }
    }
}
