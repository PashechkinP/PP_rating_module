﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PP_rating_module;

#nullable disable

namespace PP_rating_module.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231024162553_DB_Context_creation")]
    partial class DB_Context_creation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PP_rating_module.UserStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("Sector")
                        .HasColumnType("integer");

                    b.Property<int?>("children")
                        .HasColumnType("integer");

                    b.Property<bool?>("dangerouseDisease")
                        .HasColumnType("boolean");

                    b.Property<bool?>("highDegree")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("UsersStats");
                });
#pragma warning restore 612, 618
        }
    }
}
