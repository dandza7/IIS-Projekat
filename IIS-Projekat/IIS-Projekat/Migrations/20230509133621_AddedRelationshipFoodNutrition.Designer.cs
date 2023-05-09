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
    [Migration("20230509133621_AddedRelationshipFoodNutrition")]
    partial class AddedRelationshipFoodNutrition
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExerciseTrainingSession", b =>
                {
                    b.Property<long>("ExercisesId")
                        .HasColumnType("bigint");

                    b.Property<long>("TrainingSessionsId")
                        .HasColumnType("bigint");

                    b.HasKey("ExercisesId", "TrainingSessionsId");

                    b.HasIndex("TrainingSessionsId");

                    b.ToTable("ExerciseTrainingSession");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Allergy", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Appointment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Beginning")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ending")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Diagnosis", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Exercise", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHypertrophic")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("IIS_Projekat.Models.ExerciseMuscleGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ExerciseId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrimaryMuscleGroup")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("MuscleGroupId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("ExerciseMuscleGroups");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Food", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("IIS_Projekat.Models.FoodShare", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("FoodId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("RecipeId")
                        .HasColumnType("bigint");

                    b.Property<int>("Share")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("RecipeId");

                    b.ToTable("FoodShares");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Injury", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InjurySeverity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Injuries");
                });

            modelBuilder.Entity("IIS_Projekat.Models.MedicalRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Anamnesis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Therapy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("IIS_Projekat.Models.MuscleGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MuscleGroups");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7550),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7557),
                            Name = "Calves"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7583),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7583),
                            Name = "Quads"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7586),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7587),
                            Name = "Hamstrings"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7588),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7589),
                            Name = "Abductors"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7592),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7592),
                            Name = "Adductors"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7597),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7597),
                            Name = "Gluteus"
                        },
                        new
                        {
                            Id = 7L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7599),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7600),
                            Name = "Core"
                        },
                        new
                        {
                            Id = 8L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7602),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7602),
                            Name = "Abs"
                        },
                        new
                        {
                            Id = 9L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7604),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7605),
                            Name = "Lower Back"
                        },
                        new
                        {
                            Id = 10L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7609),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7609),
                            Name = "Lats"
                        },
                        new
                        {
                            Id = 11L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7613),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7613),
                            Name = "Teres Major"
                        },
                        new
                        {
                            Id = 12L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7616),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7616),
                            Name = "Lower Traps"
                        },
                        new
                        {
                            Id = 13L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7619),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7619),
                            Name = "Traps"
                        },
                        new
                        {
                            Id = 14L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7621),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7621),
                            Name = "Rear Delts"
                        },
                        new
                        {
                            Id = 15L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7636),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7636),
                            Name = "Side Delts"
                        },
                        new
                        {
                            Id = 16L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7639),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7639),
                            Name = "Front Delts"
                        },
                        new
                        {
                            Id = 17L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7771),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7772),
                            Name = "Upper Chest"
                        },
                        new
                        {
                            Id = 18L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7775),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7776),
                            Name = "Lower Chest"
                        },
                        new
                        {
                            Id = 19L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7778),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7778),
                            Name = "Biceps"
                        },
                        new
                        {
                            Id = 20L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7780),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7781),
                            Name = "Triceps"
                        },
                        new
                        {
                            Id = 21L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7782),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7783),
                            Name = "Brachialis"
                        },
                        new
                        {
                            Id = 22L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7785),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7785),
                            Name = "Forearms"
                        });
                });

            modelBuilder.Entity("IIS_Projekat.Models.Nutrition", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nutritions");
                });

            modelBuilder.Entity("IIS_Projekat.Models.NutritionShare", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("FoodId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("NutritionId")
                        .HasColumnType("bigint");

                    b.Property<int>("Share")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("NutritionId");

                    b.ToTable("NutritionShares");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Recipe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Report", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("IIS_Projekat.Models.TrainingPlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SessionsPerWeek")
                        .HasColumnType("int");

                    b.Property<string>("TrainingGoal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("TrainingPlans");
                });

            modelBuilder.Entity("IIS_Projekat.Models.TrainingPlanRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SessionsPerWeek")
                        .HasColumnType("int");

                    b.Property<string>("TrainingGoal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("TrainingPlanRequests");
                });

            modelBuilder.Entity("IIS_Projekat.Models.TrainingSession", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfExercises")
                        .HasColumnType("int");

                    b.Property<long>("TrainingPlanId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TrainingPlanId");

                    b.ToTable("TrainingSessions");
                });

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
                            CreatedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(2988),
                            Email = "admin@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(2992),
                            Password = "392E335497D18ABDEBB5A42353A2BE45EF563AA6191A925B653C3E20E2651B890D3876C1590597618734EA3591D20C8738337C0E69088BE94391EDAD54144229",
                            Role = "ADMIN",
                            Salt = new byte[] { 81, 161, 48, 168, 102, 11, 201, 79, 95, 221, 106, 64, 39, 80, 153, 76, 205, 146, 28, 93, 228, 115, 193, 121, 165, 5, 63, 89, 181, 6, 98, 58, 30, 35, 1, 112, 183, 64, 90, 60, 185, 170, 182, 83, 16, 205, 30, 108, 135, 255, 251, 32, 69, 25, 31, 7, 93, 140, 23, 133, 193, 65, 158, 202 }
                        });
                });

            modelBuilder.Entity("IIS_Projekat.Models.UsersProfile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("ExerciseTrainingSession", b =>
                {
                    b.HasOne("IIS_Projekat.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IIS_Projekat.Models.TrainingSession", null)
                        .WithMany()
                        .HasForeignKey("TrainingSessionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IIS_Projekat.Models.ExerciseMuscleGroup", b =>
                {
                    b.HasOne("IIS_Projekat.Models.Exercise", "Exercise")
                        .WithMany("Exercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IIS_Projekat.Models.MuscleGroup", "MuscleGroup")
                        .WithMany("MuscleGroups")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("MuscleGroup");
                });

            modelBuilder.Entity("IIS_Projekat.Models.FoodShare", b =>
                {
                    b.HasOne("IIS_Projekat.Models.Food", "Food")
                        .WithMany("Participations")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IIS_Projekat.Models.Recipe", "Recipe")
                        .WithMany("FoodShares")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("IIS_Projekat.Models.NutritionShare", b =>
                {
                    b.HasOne("IIS_Projekat.Models.Food", "Food")
                        .WithMany("NutritionShares")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IIS_Projekat.Models.Nutrition", "Nutrition")
                        .WithMany("Participations")
                        .HasForeignKey("NutritionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Nutrition");
                });

            modelBuilder.Entity("IIS_Projekat.Models.TrainingPlan", b =>
                {
                    b.HasOne("IIS_Projekat.Models.User", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("IIS_Projekat.Models.TrainingPlanRequest", b =>
                {
                    b.HasOne("IIS_Projekat.Models.User", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("IIS_Projekat.Models.TrainingSession", b =>
                {
                    b.HasOne("IIS_Projekat.Models.TrainingPlan", "TrainingPlan")
                        .WithMany("TrainingSessions")
                        .HasForeignKey("TrainingPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("IIS_Projekat.Models.UsersProfile", b =>
                {
                    b.HasOne("IIS_Projekat.Models.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("IIS_Projekat.Models.UsersProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Exercise", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Food", b =>
                {
                    b.Navigation("NutritionShares");

                    b.Navigation("Participations");
                });

            modelBuilder.Entity("IIS_Projekat.Models.MuscleGroup", b =>
                {
                    b.Navigation("MuscleGroups");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Nutrition", b =>
                {
                    b.Navigation("Participations");
                });

            modelBuilder.Entity("IIS_Projekat.Models.Recipe", b =>
                {
                    b.Navigation("FoodShares");
                });

            modelBuilder.Entity("IIS_Projekat.Models.TrainingPlan", b =>
                {
                    b.Navigation("TrainingSessions");
                });

            modelBuilder.Entity("IIS_Projekat.Models.User", b =>
                {
                    b.Navigation("Profile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}