using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using System.Collections.Generic;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView;

namespace FitnessTracker
{
    public class ViewModel
    {

        UserDb _context = new UserDb();

        private int accountID;
        public int CardioCount;
        public int StrengthCount;

        public IEnumerable<ISeries> Series { get; set; }

        public ViewModel(int accountID)
        {
            this.accountID = accountID;
            CardioCount = CountOfCardio();
            StrengthCount = CountOfStrength();

            Series = new[]
            {
                new PieSeries<int> { Values = new[] { CardioCount },Name = "Cardio" },
                new PieSeries<int> { Values = new[] { StrengthCount }, Name = "Strength" },
            };
        }

        public int CountOfCardio()
        {
            var UsersExercises = _context.Exercises.Where(x => x.AccountID == accountID).ToList();
            int CountCardio = UsersExercises.Where(x => x.TypeOfExercise == "Cardio").Count();
            return CountCardio;
        }
        public int CountOfStrength()
        {
            var UsersExercises = _context.Exercises.Where(x => x.AccountID == accountID).ToList();
            int CountStrength = UsersExercises.Where(x => x.TypeOfExercise == "Strength ").Count();
            MessageBox.Show(CountStrength.ToString());
            return CountStrength;
        }


    }
}
