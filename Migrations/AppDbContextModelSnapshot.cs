﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using apiitens.Context;

#nullable disable

namespace apifuncionario.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("apifuncionario.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FuncionarioId"));

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("SetorId")
                        .HasColumnType("integer");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("SetorId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("apifuncionario.Models.Setor", b =>
                {
                    b.Property<int>("SetorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SetorId"));

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("SetorId");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("apifuncionario.Models.Funcionario", b =>
                {
                    b.HasOne("apifuncionario.Models.Setor", "Setor")
                        .WithMany()
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Setor");
                });
#pragma warning restore 612, 618
        }
    }
}
