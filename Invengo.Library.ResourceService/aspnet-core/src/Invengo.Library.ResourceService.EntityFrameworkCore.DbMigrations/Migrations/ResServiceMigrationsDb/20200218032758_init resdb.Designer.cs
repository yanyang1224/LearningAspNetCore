﻿// <auto-generated />
using System;
using Invengo.Library.ResourceService.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Invengo.Library.ResourceService.Migrations.ResServiceMigrationsDb
{
    [DbContext(typeof(ResServiceMigrationsDbContext))]
    [Migration("20200218032758_init resdb")]
    partial class initresdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Invengo.Library.ResourceService.ResNotFoundBook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCrawl")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ResNotFoundBook");
                });
#pragma warning restore 612, 618
        }
    }
}
