using MauiPocketTrainer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MauiPocketTrainer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseTraining> ExerciseTrainings { get; set; }
        public DbSet<ExerciseTrainingPlan> ExerciseTrainingPlans { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Weight> Weights { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define relationships
            modelBuilder.Entity<ExerciseTraining>()
                .HasKey(et => new { et.ExerciseId, et.TrainingId });

            modelBuilder.Entity<ExerciseTraining>()
                .HasOne(et => et.Exercise)
                .WithMany(e => e.ExerciseTrainings)
                .HasForeignKey(et => et.ExerciseId);

            modelBuilder.Entity<ExerciseTraining>()
                .HasOne(et => et.Training)
                .WithMany(t => t.ExerciseTrainings)
                .HasForeignKey(et => et.TrainingId);

            modelBuilder.Entity<ExerciseTrainingPlan>()
                .HasKey(etp => new { etp.ExerciseId, etp.TrainingPlanId });

            modelBuilder.Entity<ExerciseTrainingPlan>()
                .HasOne(etp => etp.Exercise)
                .WithMany(e => e.ExerciseTrainingPlans)
                .HasForeignKey(etp => etp.ExerciseId);

            modelBuilder.Entity<ExerciseTrainingPlan>()
                .HasOne(etp => etp.TrainingPlan)
                .WithMany(tp => tp.ExerciseTrainingPlans)
                .HasForeignKey(etp => etp.TrainingPlanId);

            modelBuilder.Entity<Set>()
                .HasOne(s => s.ExerciseTraining)
                .WithMany(et => et.Sets)
                .HasForeignKey(s => s.ExerciseTrainingId);

            modelBuilder.Entity<Set>()
                .HasOne(s => s.ExerciseTrainingPlan)
                .WithMany(etp => etp.Sets)
                .HasForeignKey(s => s.ExerciseTrainingPlanId);
        }
    }
}

