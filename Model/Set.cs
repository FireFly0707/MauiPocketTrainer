using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPocketTrainer.Model
{
    public class Set
    {
        public int Id { get; set; }
        public int? Repetitions { get; set; }
        public int? Weight { get; set; }
        public int? Time { get; set; } // in seconds
        public int? Distance { get; set; } // in meters

        public int? ExerciseTrainingId { get; set; }
        public ExerciseTraining ExerciseTraining { get; set; }
        public int? ExerciseTrainingPlanId { get; set; }
        public ExerciseTrainingPlan ExerciseTrainingPlan { get; set; }

    }
}
