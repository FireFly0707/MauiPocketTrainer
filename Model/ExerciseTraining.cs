using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPocketTrainer.Model
{
    public class ExerciseTraining
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int TrainingId { get; set; }
        public Training Training { get; set; }
        public List<Set> Sets { get; set; }
    }
}
