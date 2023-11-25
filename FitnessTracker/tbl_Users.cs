using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class tbl_Users
    {
        [Key]
        public int AccountID { get; set; }

        public string? Username_ { get; set; }
        public string? Password_ { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public int Age { get; set; }
        public string? Gender { get; set; }
        public int? Calorie_Day_Burn_Goal { get; set; }
        public int? Calorie_Week_Burn_Goal { get; set; }
    }
}
