﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiBancoNacion.Models;

namespace WebApiBancoNacion.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201102034715_DbInit2")]
    partial class DbInit2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApiBancoNacion.Models.Billete", b =>
                {
                    b.Property<string>("BilleteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.HasKey("BilleteID");

                    b.ToTable("Billete");
                });

            modelBuilder.Entity("WebApiBancoNacion.Models.Cotizacion", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("BilleteId")
                        .IsRequired();

                    b.Property<DateTime>("FechaGuardado");

                    b.Property<DateTime>("FechaObtenido");

                    b.Property<string>("PrecioCompra")
                        .IsRequired();

                    b.Property<string>("PrecioVenta")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Cotizacion");
                });
#pragma warning restore 612, 618
        }
    }
}