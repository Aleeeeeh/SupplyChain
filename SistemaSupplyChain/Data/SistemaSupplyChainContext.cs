using Microsoft.EntityFrameworkCore;
using SistemaSupplyChain.Data.Map;
using SistemaSupplyChain.Models.Entities;

namespace SistemaSupplyChain.Data
{
    public class SistemaSupplyChainContext : DbContext
    {
        public SistemaSupplyChainContext(DbContextOptions<SistemaSupplyChainContext> options) : base(options) 
        { 
            
        }

        //Migrando tabelas para o banco de dados
        public DbSet<Produtos>? Produtos { get; set; }
        public DbSet<Entradas>? Entradas { get; set;}
        public DbSet<Saidas>? Saidas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutosMap());
            modelBuilder.ApplyConfiguration(new EntradasMap());
            modelBuilder.ApplyConfiguration(new SaidasMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
