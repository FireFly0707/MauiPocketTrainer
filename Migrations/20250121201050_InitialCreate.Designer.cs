﻿// <auto-generated />
using System;
using MauiPocketTrainer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MigrationProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250121201050_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("MauiPocketTrainer.Model.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.ExerciseTraining", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrainingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("TrainingId");

                    b.ToTable("ExerciseTrainings");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.ExerciseTrainingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrainingPlanId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("TrainingPlanId");

                    b.ToTable("ExerciseTrainingPlans");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Distance")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ExerciseTrainingId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ExerciseTrainingPlanId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Repetitions")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Time")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseTrainingId");

                    b.HasIndex("ExerciseTrainingPlanId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TrainingPlanId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TrainingPlanId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.TrainingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TrainingPlans");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.Weight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Weights");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.ExerciseTraining", b =>
                {
                    b.HasOne("MauiPocketTrainer.Model.Exercise", "Exercise")
                        .WithMany("ExerciseTrainings")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MauiPocketTrainer.Model.Training", "Training")
                        .WithMany("ExerciseTrainings")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.ExerciseTrainingPlan", b =>
                {
                    b.HasOne("MauiPocketTrainer.Model.Exercise", "Exercise")
                        .WithMany("ExerciseTrainingPlans")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MauiPocketTrainer.Model.TrainingPlan", "TrainingPlan")
                        .WithMany("ExerciseTrainingPlans")
                        .HasForeignKey("TrainingPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.Set", b =>
                {
                    b.HasOne("MauiPocketTrainer.Model.ExerciseTraining", "ExerciseTraining")
                        .WithMany("Sets")
                        .HasForeignKey("ExerciseTrainingId");

                    b.HasOne("MauiPocketTrainer.Model.ExerciseTrainingPlan", "ExerciseTrainingPlan")
                        .WithMany("Sets")
                        .HasForeignKey("ExerciseTrainingPlanId");

                    b.Navigation("ExerciseTraining");

                    b.Navigation("ExerciseTrainingPlan");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.Training", b =>
                {
                    b.HasOne("MauiPocketTrainer.Model.TrainingPlan", "TrainingPlan")
                        .WithMany("Trainings")
                        .HasForeignKey("TrainingPlanId");

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.Exercise", b =>
                {
                    b.Navigation("ExerciseTrainingPlans");

                    b.Navigation("ExerciseTrainings");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.ExerciseTraining", b =>
                {
                    b.Navigation("Sets");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.ExerciseTrainingPlan", b =>
                {
                    b.Navigation("Sets");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.Training", b =>
                {
                    b.Navigation("ExerciseTrainings");
                });

            modelBuilder.Entity("MauiPocketTrainer.Model.TrainingPlan", b =>
                {
                    b.Navigation("ExerciseTrainingPlans");

                    b.Navigation("Trainings");
                });
#pragma warning restore 612, 618
        }
    }
}
