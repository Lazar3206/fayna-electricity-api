﻿// <auto-generated />
using System;
using Electricity.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Electricity.Db.Migrations
{
    [DbContext(typeof(ElectricityDbContext))]
    [Migration("20221211161601_CreateElectricityDb")]
    partial class CreateElectricityDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Electricity.Db.Entities.ElectricitySwitchRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ElectricitySwithRecordKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SwitchType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ElectricitySwitchRecord");
                });
#pragma warning restore 612, 618
        }
    }
}
