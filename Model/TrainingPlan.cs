using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPocketTrainer.Model
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Note { get; set; }
        public List<Training> Trainings { get; set; }

        public List<ExerciseTrainingPlan> ExerciseTrainingPlans { get; set; }
    }
}
