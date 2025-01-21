using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPocketTrainer.Model
{
    public class ExerciseTrainingPlan
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int TrainingPlanId { get; set; }
        public TrainingPlan TrainingPlan { get; set; }
        public List<Set> Sets { get; set; }
    }
}
