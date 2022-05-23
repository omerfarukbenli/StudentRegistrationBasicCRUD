﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentRegistration.Data;

#nullable disable

namespace StudentRegistration.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220523091629_three")]
    partial class three
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentRegistration.Entity.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Schools", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lise"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ortaokul"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "İlkokul"
                        });
                });

            modelBuilder.Entity("StudentRegistration.Entity.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirsName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SchooldId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SchooldId");

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5934),
                            FirsName = "ahmet",
                            LastName = "veli",
                            SchooldId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5943),
                            FirsName = "ali",
                            LastName = "erdal",
                            SchooldId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5944),
                            FirsName = "murat",
                            LastName = "vural",
                            SchooldId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5944),
                            FirsName = "volkan",
                            LastName = "arda",
                            SchooldId = 3
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 5, 23, 12, 16, 29, 810, DateTimeKind.Local).AddTicks(5945),
                            FirsName = "atakan",
                            LastName = "dural",
                            SchooldId = 2
                        });
                });

            modelBuilder.Entity("StudentRegistration.Entity.Models.StudentFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 10,
                            Height = 150,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 12,
                            Height = 140,
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("StudentRegistration.Entity.Models.Student", b =>
                {
                    b.HasOne("StudentRegistration.Entity.Models.School", "School")
                        .WithMany("Students")
                        .HasForeignKey("SchooldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("StudentRegistration.Entity.Models.StudentFeature", b =>
                {
                    b.HasOne("StudentRegistration.Entity.Models.Student", "Student")
                        .WithOne("StudentFeature")
                        .HasForeignKey("StudentRegistration.Entity.Models.StudentFeature", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentRegistration.Entity.Models.School", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentRegistration.Entity.Models.Student", b =>
                {
                    b.Navigation("StudentFeature")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
