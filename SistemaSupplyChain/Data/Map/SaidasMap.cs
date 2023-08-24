using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaSupplyChain.Models.Entities;

namespace SistemaSupplyChain.Data.Map
{
    public class SaidasMap : IEntityTypeConfiguration<Saidas>
    {
        public void Configure(EntityTypeBuilder<Saidas> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantidade).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Local).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Data).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Hora).IsRequired().HasMaxLength(20);
            builder.HasOne(x => x.IdProduto).WithMany().IsRequired();
        }
    }
}
