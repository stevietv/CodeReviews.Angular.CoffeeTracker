﻿// <auto-generated />
using System;
using CoffeeTracker.UgniusFalze.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoffeeTracker.UgniusFalze.Migrations
{
    [DbContext(typeof(CoffeeRecordContext))]
    [Migration("20231228184347_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoffeeTrackerAPI.Models.CoffeeRecord", b =>
                {
                    b.Property<int>("CoffeeRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoffeeRecordId"));

                    b.Property<int>("CupsOfCoffee")
                        .HasColumnType("int");

                    b.Property<DateOnly>("RecordDate")
                        .HasColumnType("date");

                    b.HasKey("CoffeeRecordId");

                    b.ToTable("CoffeeRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
