﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using server.Data;

#nullable disable

namespace server.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("server.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("MoviesModelid")
                        .HasColumnType("integer");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MoviesModelid");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("server.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("MoviesModelid")
                        .HasColumnType("integer");

                    b.Property<string>("image_description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image_path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MoviesModelid");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("server.Models.MoviesModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("year")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("server.Models.Actor", b =>
                {
                    b.HasOne("server.Models.MoviesModel", null)
                        .WithMany("actors")
                        .HasForeignKey("MoviesModelid");
                });

            modelBuilder.Entity("server.Models.Image", b =>
                {
                    b.HasOne("server.Models.MoviesModel", null)
                        .WithMany("images")
                        .HasForeignKey("MoviesModelid");
                });

            modelBuilder.Entity("server.Models.MoviesModel", b =>
                {
                    b.Navigation("actors");

                    b.Navigation("images");
                });
#pragma warning restore 612, 618
        }
    }
}
