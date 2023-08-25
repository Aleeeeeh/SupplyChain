using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaSupplyChain.Models.Entities;

namespace SistemaSupplyChain.Data.Map
{
    public class EntradasMap : IEntityTypeConfiguration<Entradas>
    {
        public void Configure(EntityTypeBuilder<Entradas> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantidade).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Local).IsRequired().HasMaxLength(255);
            builder.Property(x => x.DataEHora).IsRequired();
            builder.Property(x => x.ProdutoID).IsRequired();
            builder.HasOne(x => x.Produto).WithMany().IsRequired();
        }
    }
}
