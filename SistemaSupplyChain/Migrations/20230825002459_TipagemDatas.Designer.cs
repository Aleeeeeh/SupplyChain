﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaSupplyChain.Data;

#nullable disable

namespace SistemaSupplyChain.Migrations
{
    [DbContext(typeof(SistemaSupplyChainContext))]
    [Migration("20230825002459_TipagemDatas")]
    partial class TipagemDatas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaSupplyChain.Models.Entities.Entradas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ProdutoID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoID")
                        .IsUnique();

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("SistemaSupplyChain.Models.Entities.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("NumeroRegistro")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("int");

                    b.Property<string>("TipoProduto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SistemaSupplyChain.Models.Entities.Saidas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ProdutoID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoID")
                        .IsUnique();

                    b.ToTable("Saidas");
                });

            modelBuilder.Entity("SistemaSupplyChain.Models.Entities.Entradas", b =>
                {
                    b.HasOne("SistemaSupplyChain.Models.Entities.Produtos", "Produto")
                        .WithOne()
                        .HasForeignKey("SistemaSupplyChain.Models.Entities.Entradas", "ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("SistemaSupplyChain.Models.Entities.Saidas", b =>
                {
                    b.HasOne("SistemaSupplyChain.Models.Entities.Produtos", "Produto")
                        .WithOne()
                        .HasForeignKey("SistemaSupplyChain.Models.Entities.Saidas", "ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}