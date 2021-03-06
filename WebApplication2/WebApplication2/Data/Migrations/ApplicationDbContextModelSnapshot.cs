﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication2.Data;

namespace WebApplication2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("price");

                    b.Property<string>("releaseDate")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double>("starRating");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WebApplication2.Models.Commande", b =>
                {
                    b.Property<int>("CommandeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CommandeId");

                    b.ToTable("Commandes");
                });
#pragma warning restore 612, 618
        }
    }
}
