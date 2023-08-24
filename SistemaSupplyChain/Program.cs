using Microsoft.EntityFrameworkCore;
using SistemaSupplyChain.Data;
using SistemaSupplyChain.Services.Impl;
using SistemaSupplyChain.Services.Interfaces;

namespace SistemaSupplyChain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configura��o para conex�o com banco de dados SQLServer dentro do nosso contexto
            builder.Services.AddEntityFrameworkSqlServer().AddDbContext<SistemaSupplyChainContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database"))
                );

            //Configura��o para sempre que for chamada essa interface ser direcionado para a classe de implementa��o correta
            builder.Services.AddScoped<IProdutoService, ProdutoServiceImpl>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}