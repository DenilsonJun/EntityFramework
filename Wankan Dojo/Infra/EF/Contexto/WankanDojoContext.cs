using Domain.Entity;
using Infra.EF.Mapping;
using System.Data.Entity;

namespace Infra.EF.Contexto
{
    public partial class WankanDojoContext : DbContext
    {
        static WankanDojoContext()
        {
            Database.SetInitializer<WankanDojoContext>(null);
        }
        public WankanDojoContext() : base("name=WankanDojoContext")
        {

        }

        public virtual DbSet<Alunos> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunosMapping());
        }

        public override int SaveChanges()
        {

            return base.SaveChanges();
        }
    }
}