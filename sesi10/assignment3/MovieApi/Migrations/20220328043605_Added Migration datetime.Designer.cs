﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApi.Data;

namespace MovieApi.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20220328043605_Added Migration datetime")]
    partial class AddedMigrationdatetime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("MovieApi.Models.ItemData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("duration")
                        .HasColumnType("TEXT");

                    b.Property<string>("genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("releaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
