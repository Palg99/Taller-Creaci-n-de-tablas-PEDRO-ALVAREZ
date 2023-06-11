﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerPedroAlvarez.Models;

#nullable disable

namespace Taller_Creación_de_tablas_PEDRO_ALVAREZ.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TallerPedroAlvarez.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("TallerPedroAlvarez.Models.HistorialAcceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("HistorialAcceso");
                });

            modelBuilder.Entity("TallerPedroAlvarez.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("varcahar(10)");

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasColumnType("varcahar(10)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("TallerPedroAlvarez.Models.HistorialAcceso", b =>
                {
                    b.HasOne("TallerPedroAlvarez.Models.Usuario", "Usuario")
                        .WithMany("ListHistorialAcceso")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TallerPedroAlvarez.Models.Usuario", b =>
                {
                    b.HasOne("TallerPedroAlvarez.Models.Genero", "genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("genero");
                });

            modelBuilder.Entity("TallerPedroAlvarez.Models.Usuario", b =>
                {
                    b.Navigation("ListHistorialAcceso");
                });
#pragma warning restore 612, 618
        }
    }
}
