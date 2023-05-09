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
    [Migration("20230509132917_AddedRelationshipFoodRecipe")]
    partial class AddedRelationshipFoodRecipe
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
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7136),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7139),
                            Name = "Calves"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7160),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7160),
                            Name = "Quads"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7163),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7163),
                            Name = "Hamstrings"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7165),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7165),
                            Name = "Abductors"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7167),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7167),
                            Name = "Adductors"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7171),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7171),
                            Name = "Gluteus"
                        },
                        new
                        {
                            Id = 7L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7173),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7173),
                            Name = "Core"
                        },
                        new
                        {
                            Id = 8L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7175),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7175),
                            Name = "Abs"
                        },
                        new
                        {
                            Id = 9L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7176),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7177),
                            Name = "Lower Back"
                        },
                        new
                        {
                            Id = 10L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7180),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7180),
                            Name = "Lats"
                        },
                        new
                        {
                            Id = 11L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7181),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7182),
                            Name = "Teres Major"
                        },
                        new
                        {
                            Id = 12L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7184),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7184),
                            Name = "Lower Traps"
                        },
                        new
                        {
                            Id = 13L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7186),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7186),
                            Name = "Traps"
                        },
                        new
                        {
                            Id = 14L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7188),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7189),
                            Name = "Rear Delts"
                        },
                        new
                        {
                            Id = 15L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7198),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7198),
                            Name = "Side Delts"
                        },
                        new
                        {
                            Id = 16L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7200),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7201),
                            Name = "Front Delts"
                        },
                        new
                        {
                            Id = 17L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7240),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7240),
                            Name = "Upper Chest"
                        },
                        new
                        {
                            Id = 18L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7247),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7247),
                            Name = "Lower Chest"
                        },
                        new
                        {
                            Id = 19L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7249),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7249),
                            Name = "Biceps"
                        },
                        new
                        {
                            Id = 20L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7251),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7251),
                            Name = "Triceps"
                        },
                        new
                        {
                            Id = 21L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7253),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7253),
                            Name = "Brachialis"
                        },
                        new
                        {
                            Id = 22L,
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7255),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7255),
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Share")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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
                            CreatedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(3541),
                            Email = "admin@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(3547),
                            Password = "D8C91A426E2B70B8D9FD3C79D06F736754307FA775B64BE3E8BB3E184DEE7743060CC400AF0BB51864C74E4CB81616A770C80D73B8183F316A27651A0AE3986C",
                            Role = "ADMIN",
                            Salt = new byte[] { 68, 150, 16, 140, 4, 98, 244, 71, 221, 66, 209, 84, 139, 164, 112, 213, 245, 71, 54, 150, 137, 247, 19, 192, 163, 101, 135, 44, 33, 56, 88, 159, 208, 171, 195, 200, 163, 69, 147, 137, 47, 220, 54, 56, 216, 241, 10, 11, 88, 230, 85, 109, 243, 20, 98, 244, 171, 34, 50, 168, 183, 209, 146, 229 }
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
                    b.Navigation("Participations");
                });

            modelBuilder.Entity("IIS_Projekat.Models.MuscleGroup", b =>
                {
                    b.Navigation("MuscleGroups");
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