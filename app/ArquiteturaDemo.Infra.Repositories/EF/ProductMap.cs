using System.Data.Entity.ModelConfiguration;
using ArquiteturaDemo.Domain.Entities;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Price)
                .IsRequired()
                .HasPrecision(10, 2);
        }
    }
}
