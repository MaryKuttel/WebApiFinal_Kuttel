﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SWProvincias_Kuttel.Data;

namespace SWProvincias_Kuttel.Migrations
{
    [DbContext(typeof(DBPaisFinalContext))]
    [Migration("20230125174536_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SWProvincias_Kuttel.Models.Ciudad", b =>
                {
                    b.Property<int>("IdCiudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("IdCiudad");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("SWProvincias_Kuttel.Models.Provincia", b =>
                {
                    b.Property<int>("IdProvincia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdProvincia");

                    b.ToTable("provincia");
                });

            modelBuilder.Entity("SWProvincias_Kuttel.Models.Ciudad", b =>
                {
                    b.HasOne("SWProvincias_Kuttel.Models.Provincia", "Provincia")
                        .WithMany("Ciudad")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
