using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class tbl_Exercises
    {
        [Key]
        public int ExerciseID { get; set; }

        public int AccountID { get; set; }
        public string? TypeOfExercise { get; set; }
        public string? ExerciseName { get; set;}
        public int? LengthOfExercise { get; set; }
        public int Calories { get; set; }
        public string? MuscleGroup { get; set; }
        public DateTime? DayOfExercise { get; set; }
    }
}
