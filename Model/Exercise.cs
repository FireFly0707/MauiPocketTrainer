using MauiPocketTrainer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPocketTrainer.Model
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ExerciseCategory Category { get; set; }
        public string? ImagePath { get; set; }
        public List<ExerciseTraining> ExerciseTrainings { get; set; }
        public List<ExerciseTrainingPlan> ExerciseTrainingPlans { get; set; }
    }
}
