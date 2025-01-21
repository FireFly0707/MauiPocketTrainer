using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MauiPocketTrainer.Model
{
    public class Training
    {
        public int Id { get; set; }

        public int? TrainingPlanId { get; set; }
#nullable enable
        public TrainingPlan? TrainingPlan { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public List<ExerciseTraining> ExerciseTrainings { get; set; }

    }
}
