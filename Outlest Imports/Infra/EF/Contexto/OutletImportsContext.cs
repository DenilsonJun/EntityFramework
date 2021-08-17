using Domain.EF.Entity;
using Infra.EF.Mapping;
using System.Data.Entity;

namespace Infra.EF.Contexto
{
    public partial class OutletImportsContext : DbContext
    {
        static OutletImportsContext()
        {
            Database.SetInitializer<OutletImportsContext>(null);
        }
        public OutletImportsContext() : base("name=OutletImportsContext")
        {

        }

        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutosMapping());
            modelBuilder.Configurations.Add(new EstoqueMapping());
        }

        public override int SaveChanges()
        {

            return base.SaveChanges();
        }
    }
}