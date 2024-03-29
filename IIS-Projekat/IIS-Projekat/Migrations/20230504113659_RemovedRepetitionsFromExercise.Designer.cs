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
    [Migration("20230504113659_RemovedRepetitionsFromExercise")]
    partial class RemovedRepetitionsFromExercise
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
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(889),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(891),
                            Name = "Calves"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(912),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(912),
                            Name = "Quads"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(915),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(915),
                            Name = "Hamstrings"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(917),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(917),
                            Name = "Abductors"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(920),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(921),
                            Name = "Adductors"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(925),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(925),
                            Name = "Gluteus"
                        },
                        new
                        {
                            Id = 7L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1003),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1003),
                            Name = "Core"
                        },
                        new
                        {
                            Id = 8L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1006),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1007),
                            Name = "Abs"
                        },
                        new
                        {
                            Id = 9L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1009),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1010),
                            Name = "Lower Back"
                        },
                        new
                        {
                            Id = 10L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1013),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1013),
                            Name = "Lats"
                        },
                        new
                        {
                            Id = 11L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1016),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1016),
                            Name = "Teres Major"
                        },
                        new
                        {
                            Id = 12L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1018),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1018),
                            Name = "Lower Traps"
                        },
                        new
                        {
                            Id = 13L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1021),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1022),
                            Name = "Traps"
                        },
                        new
                        {
                            Id = 14L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1024),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1024),
                            Name = "Rear Delts"
                        },
                        new
                        {
                            Id = 15L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1038),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1038),
                            Name = "Side Delts"
                        },
                        new
                        {
                            Id = 16L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1041),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1041),
                            Name = "Front Delts"
                        },
                        new
                        {
                            Id = 17L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1044),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1044),
                            Name = "Upper Chest"
                        },
                        new
                        {
                            Id = 18L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1047),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1048),
                            Name = "Lower Chest"
                        },
                        new
                        {
                            Id = 19L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1050),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1050),
                            Name = "Biceps"
                        },
                        new
                        {
                            Id = 20L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1052),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1053),
                            Name = "Triceps"
                        },
                        new
                        {
                            Id = 21L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1055),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1055),
                            Name = "Brachialis"
                        },
                        new
                        {
                            Id = 22L,
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1058),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1058),
                            Name = "Forearms"
                        });
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
                            CreatedDate = new DateTime(2023, 5, 4, 11, 36, 59, 597, DateTimeKind.Utc).AddTicks(6850),
                            Email = "admin@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 5, 4, 11, 36, 59, 597, DateTimeKind.Utc).AddTicks(6854),
                            Password = "242873F53B6CC6E50067B0046D8A07E99CF4A03E5387FC6AB10A81DC319F3A16BF83498E14CEC412FAB2FFD3BA9918A708EFBA885EFAC5E92775AD53B10DE24F",
                            Role = "ADMIN",
                            Salt = new byte[] { 182, 225, 218, 220, 138, 191, 45, 96, 38, 8, 216, 78, 137, 248, 176, 42, 25, 93, 135, 24, 39, 0, 85, 79, 195, 98, 72, 52, 114, 88, 96, 146, 52, 53, 114, 47, 244, 160, 68, 232, 123, 163, 175, 33, 71, 217, 80, 51, 28, 68, 153, 80, 44, 170, 65, 160, 210, 169, 114, 94, 93, 117, 122, 41 }
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

            modelBuilder.Entity("IIS_Projekat.Models.MuscleGroup", b =>
                {
                    b.Navigation("MuscleGroups");
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
