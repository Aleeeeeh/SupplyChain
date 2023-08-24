using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaSupplyChain.Models.Entities;

namespace SistemaSupplyChain.Data.Map
{
    public class ProdutosMap : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.NumeroRegistro).IsRequired().HasMaxLength(13);
            builder.Property(x => x.Fabricante).IsRequired().HasMaxLength(255);
            builder.Property(x => x.TipoProduto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1000);
        }
    }
}
