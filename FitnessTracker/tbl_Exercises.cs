using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    [Keyless]
    public class tbl_Exercises
    {
        public string? TypeOfExercise { get; set; }
        public string? ExerciseName { get; set;}
        public string? LengthOfExercise { get; set; }
        public int Calories { get; set; }
        public int AccountID { get; set; }
    }
}
