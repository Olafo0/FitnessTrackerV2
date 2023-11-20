using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using System.Collections.Generic;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

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

            // Bad way to do
            //var data = new[] { CardioCount, StrengthCount};
            //Series = data.AsPieSeries((value, series) =>
            //{
            //    series.MaxRadialColumnWidth = 10;
            //});
            Series = new[]
            {
                new PieSeries<int> { Values = new[] { CardioCount },Name = "Cardio",MaxRadialColumnWidth = 10},
                new PieSeries<int> { Values = new[] { StrengthCount }, Name = "Strength",MaxRadialColumnWidth = 10},
            };

        }

        // Gets the amout of exercises you've done in the last week and splits them in the two catagories.
        public int CountOfCardio()
        {
            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == accountID).ToList();
            for (int i = 0; i > -7; i--)
            {
                var ExerciseThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = ExerciseThatDay.Where(x => x.TypeOfExercise == "Cardio").ToList().Count();
                CardioCount += temp;
            }
            return CardioCount;
        }
        public int CountOfStrength()
        {
            var CurrentAccountExercise = _context.Exercises.Where( x => x.AccountID == accountID ).ToList();
            for (int i =  0; i > -7; i--)
            {
                var ExerciseThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = ExerciseThatDay.Where(x => x.TypeOfExercise == "Strength ").ToList().Count();
                StrengthCount += temp;
            }
            return StrengthCount;
        }
    }
}
