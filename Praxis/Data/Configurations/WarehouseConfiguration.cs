using Microsoft.EntityFrameworkCore;
using Praxis.Data.Entities.Admin;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Praxis.Data.Configurations
{
    public sealed class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> b)
        {
            b.ToTable("Warehouses", DbSchemas.Admin);
            b.HasKey(e => e.WarehouseRef);
            b.HasIndex(e => e.WarehouseRef).IsUnique();
            b.Property(e => e.WarehouseRef).HasMaxLength(8).IsRequired();
            b.Property(e => e.WarehouseName).HasMaxLength(60).IsRequired();
        }
    }
}
