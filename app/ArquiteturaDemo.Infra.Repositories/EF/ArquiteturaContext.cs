using System.Data.Entity;
using ArquiteturaDemo.Domain.Entities;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class ArquiteturaContext : DbContext
    {
        public ArquiteturaContext()
            :base("ProductConnection")
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
