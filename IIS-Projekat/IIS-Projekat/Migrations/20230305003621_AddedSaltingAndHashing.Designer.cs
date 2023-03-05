﻿// <auto-generated />
using System;
using IIS_Projekat.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IISProjekat.Migrations
{
    [DbContext(typeof(IIS_DBContext))]
    [Migration("20230305003621_AddedSaltingAndHashing")]
    partial class AddedSaltingAndHashing
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IIS_Projekat.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2023, 3, 5, 0, 36, 21, 134, DateTimeKind.Utc).AddTicks(4951),
                            Email = "admin@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 3, 5, 0, 36, 21, 134, DateTimeKind.Utc).AddTicks(4954),
                            Password = "D148435D55E9E9B6814119C30FE7DDA7252946936A00C915C3F4E1243F14D0DC6D5AB26AF769BF1ECAD6A6EA7FCADB4267B50A757E9A5ED57585AE32DFF2A73F",
                            Role = "ADMIN",
                            Salt = new byte[] { 225, 233, 29, 77, 110, 33, 136, 239, 112, 190, 168, 208, 201, 106, 51, 161, 123, 232, 137, 124, 94, 150, 172, 196, 86, 229, 180, 21, 120, 117, 42, 35, 60, 142, 249, 140, 139, 162, 122, 203, 36, 255, 20, 119, 94, 3, 175, 86, 1, 245, 212, 228, 254, 186, 86, 188, 214, 32, 101, 57, 32, 244, 191, 59 }
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
