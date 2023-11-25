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
using Microsoft.Identity.Client;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker
{
    public class ViewModel
    {
        UserDb _context = new UserDb();

        private int accountID;
        private int DaysToRemove;
        public int CardioCount;
        public int StrengthCount;

        public IEnumerable<ISeries> Series { get; set; }

        // Viewmodel for the 'Exercise type' 
        public ViewModel(int accountID, int days)
        {
            this.accountID = accountID;
            this.DaysToRemove = days + 1;


            CardioCount = CountOfCardio();
            StrengthCount = CountOfStrength();

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
            for (int i = 0; i > -DaysToRemove; i--)
            {
                var ExerciseThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = ExerciseThatDay.Where(x => x.TypeOfExercise == "Cardio").ToList().Count();
                CardioCount += temp;
            }
            return CardioCount;
        }
        public int CountOfStrength()
        {
            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == accountID).ToList();
            for (int i = 0; i > -DaysToRemove; i--)
            {
                var ExerciseThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = ExerciseThatDay.Where(x => x.TypeOfExercise == "Strength ").ToList().Count();
                StrengthCount += temp;
            }
            return StrengthCount;
        }
    }
    public class CaloriesViewModel
    {
        UserDb _context = new UserDb();

        private int accountID;
        private int DaysToRemove;



        public IEnumerable<ISeries> Series { get; set; }

        public CaloriesViewModel(int accountID, int days)
        {
            this.accountID = accountID;
            this.DaysToRemove = days + 1;
            int CaloriesBurned = CountOfCalories();
            var CurrentUser = _context.Users.Where(x => x.AccountID == accountID).Single();

            Series = GaugeGenerator.BuildSolidGauge(
                new GaugeItem(CaloriesBurned,
                series =>
                {
                    series.MaxRadialColumnWidth = 10;
                    series.DataLabelsSize = 25;
                    series.Name = "Calories Burned:";
                    series.IsHoverable = false;

                    // Changes the colour of your Total calories Gaunge depending on your performance during that day
                    if (DaysToRemove == 4)
                    {
                        if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 25) / 100))
                        {
                            if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 40) / 100))
                            {
                                if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 75 / 100)))
                                {
                                    if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 100 / 100)))
                                    {
                                        if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 115 / 100)))
                                        {
                                            // You're a demon
                                            series.Fill = new SolidColorPaint(SKColors.Black);
                                        }
                                        else
                                        {
                                            series.Fill = new SolidColorPaint(SKColors.Green);
                                        }
                                    }
                                    else
                                    {
                                        // You passed for now
                                        series.Fill = new SolidColorPaint(SKColors.Yellow);
                                    }
                                }
                                else
                                {
                                    // You are rewared with a yellow
                                    series.Fill = new SolidColorPaint(SKColors.LightYellow);
                                }
                            }
                            else
                            {
                                // Still dark red
                                series.Fill = new SolidColorPaint(SKColors.IndianRed);
                            }
                        }
                        else
                        {
                            // Bad performance is rewarded with DARK RED
                            series.Fill = new SolidColorPaint(SKColors.DarkRed);
                        }
                    }
                    else if (DaysToRemove == 8)
                    {
                        if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 25) / 100))
                        {
                            if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 40) / 100))
                            {
                                if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 75) / 100))
                                {
                                    if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 100) / 100))
                                    {
                                        if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 130) / 100))
                                        {
                                            // You're a demon
                                            series.Fill = new SolidColorPaint(SKColors.Black);
                                        }
                                        else
                                        {
                                            // Valid you passed
                                            series.Fill = new SolidColorPaint(SKColors.Green);
                                        }
                                    }
                                    else
                                    {
                                        // You are not that cool
                                        series.Fill = new SolidColorPaint(SKColors.Yellow);
                                    }
                                }
                                else
                                {
                                    // You are rewared with a yellow
                                    series.Fill = new SolidColorPaint(SKColors.LightYellow);
                                }
                            }
                            else
                            {
                                // Still dark red
                                series.Fill = new SolidColorPaint(SKColors.DarkRed);
                            }
                        }
                        else
                        {
                            // Bad performance is rewarded with DARK RED
                            series.Fill = new SolidColorPaint(SKColors.DarkRed);
                        }
                    }
                    else if (DaysToRemove == 15)
                    {
                        if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 25) / 100)
                        {
                            if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 40) / 100)
                            {
                                if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 75) / 100)
                                {
                                    if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 100) / 100)
                                    {
                                        if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 130) / 100)
                                        {
                                            // You're a demon
                                            series.Fill = new SolidColorPaint(SKColors.Black);
                                        }
                                        else
                                        {
                                            // Valid you passed
                                            series.Fill = new SolidColorPaint(SKColors.Green);
                                        }
                                    }
                                    else
                                    {
                                        // You are not that cool
                                        series.Fill = new SolidColorPaint(SKColors.Yellow);
                                    }
                                }
                                else
                                {
                                    // You are rewared with a yellow
                                    series.Fill = new SolidColorPaint(SKColors.LightYellow);
                                }
                            }
                            else
                            {
                                // Still dark red
                                series.Fill = new SolidColorPaint(SKColors.DarkRed);
                            }
                        }
                        else
                        {
                            // Bad performance is rewarded with DARK RED
                            series.Fill = new SolidColorPaint(SKColors.DarkRed);
                        }
                    }

                }));
        }

        public int CountOfCalories()
        {
            int CaloriesBurned = 0;

            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == accountID).ToList();
            for (int i = 0; i > -DaysToRemove; i--)
            {
                var ExerciseThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int tempCaloriesBurned = ExerciseThatDay.Sum(x => x.Calories);
                CaloriesBurned += tempCaloriesBurned;
            }
            return CaloriesBurned;
        }

        public string ColourUsed()
        {
            var CurrentUser = _context.Users.Where(x => x.AccountID == accountID).Single();
            int CaloriesBurned = CountOfCalories();
            if (DaysToRemove == 4)
            {
                if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 25) / 100))
                {
                    if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 40) / 100))
                    {
                        if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 75 / 100)))
                        {
                            if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 100 / 100)))
                            {
                                if (CaloriesBurned > (((CurrentUser.Calorie_Day_Burn_Goal * 3) * 115 / 100)))
                                {
                                    // You're a demon
                                    return "Black";
                                }
                                else
                                {
                                    return "Green";
                                }
                            }
                            else
                            {
                                // You passed for now
                                return "Yellow";
                            }
                        }
                        else
                        {
                            // You are rewared with a yellow
                            return "LightYellow";
                        }
                    }
                    else
                    {
                        // Still dark red
                        return "IndianRed";
                    }
                }
                else
                {
                    // Bad performance is rewarded with DARK RED
                    return "DarkRed";
                }
            }
            else if (DaysToRemove == 8)
            {
                if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 25) / 100))
                {
                    if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 40) / 100))
                    {
                        if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 75) / 100))
                        {
                            if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 100) / 100))
                            {
                                if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 130) / 100))
                                {
                                    // You're a demon
                                    return "Black";
                                }
                                else
                                {
                                    // Valid you passed
                                    return "Green";
                                }
                            }
                            else
                            {
                                // You are not that cool
                                return "Yellow";
                            }
                        }
                        else
                        {
                            // You are rewared with a yellow
                            return "LightYellow";
                        }
                    }
                    else
                    {
                        // Still dark red
                        return "DarkRed";
                    }
                }
                else
                {
                    // Bad performance is rewarded with DARK RED
                    return "DarkRed;";
                }
            }
            else if (DaysToRemove == 15)
            {
                if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 25) / 100)
                {
                    if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 40) / 100)
                    {
                        if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 75) / 100)
                        {
                            if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 100) / 100)
                            {
                                if (CaloriesBurned > ((CurrentUser.Calorie_Week_Burn_Goal * 2) * 130) / 100)
                                {
                                    // You're a demon
                                    return "Black";
                                }
                                else
                                {
                                    // Valid you passed
                                    return "Green";
                                }
                            }
                            else
                            {
                                // You are not that cool
                                return "Yellow";
                            }
                        }
                        else
                        {
                            // You are rewared with a yellow
                            return "LightYellow";
                        }
                    }
                    else
                    {
                        // Still dark red
                        return "DarkRed";
                    }
                }
                else
                {
                    // Bad performance is rewarded with DARK RED
                    return "DarkRed";
                }
            }
            return null;
        }
    }
    public class MuscleGroupViewModel
    {
        UserDb _context = new UserDb();

        private int AccountID;
        private int DaysToRemove;

        private int ShoulderCount;
        private int BackCount;
        private int ChestCount;
        private int ArmCount;
        private int AbdominalCount;
        private int LegCount;

        public IEnumerable<ISeries> Series { get; set; }

        public MuscleGroupViewModel(int accountID, int days)
        {
            AccountID = accountID;
            DaysToRemove = days + 1;

            ShoulderCount = CountOfShoulder();
            BackCount = CountOfBack();
            ChestCount = CountOfChest();
            ArmCount = CountOfArm();
            AbdominalCount = CountOfAbdmonial();
            LegCount = CountOfLeg();

            int y = 0;

            int TitleIndex = 0;
            var outer = 0;

            List<int> DataItemsToAdd = new List<int> { ShoulderCount, BackCount, ChestCount, ArmCount, AbdominalCount, LegCount };
            List<string> DataNameToAdd = new List<string> { "Shoulder", "Back", "Chest", "Arm", "Abdominal", "Leg" };

            List<int> dataValues = new List<int> { };
            List<string> dataNames = new List<string> { };

            foreach (var DataValue in DataItemsToAdd)
            {
                if (DataValue == 0)
                {
                    y++;
                }
                else
                {
                    dataValues.Add(DataValue);
                    dataNames.Add(DataNameToAdd[y]);
                    y++;
                }
            }


            Series = dataValues.AsPieSeries((values, series) =>
            {
                series.Name += dataNames[TitleIndex];
                TitleIndex++;
                series.DataLabelsPaint = new SolidColorPaint(SKColors.White)
                {
                    SKTypeface = SKTypeface.FromFamilyName("Arial", SKFontStyle.Bold)
                };

                series.TooltipLabelFormatter =
                point =>
                {
                    var pv = point.Coordinate.PrimaryValue;
                    var sv = point.StackedValue;

                    var TitleOfPie = $"{sv.Share:P2}{Environment.NewLine}{series.Name}";
                    return TitleOfPie;
                };
                series.DataLabelsFormatter =
                point =>
                {
                    var pv = point.Coordinate.PrimaryValue;
                    var sv = point.StackedValue;

                    var TitleOfPie = $"{sv.Share:P2}{Environment.NewLine}{series.Name}";
                    return TitleOfPie;
                };
                series.DataLabelsSize = 10;
            });
        }

        public int CountOfShoulder()
        {
            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == AccountID).ToList();
            for (int i = 0; i > -DaysToRemove; i--)
            {
                var MuscleGroupThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = MuscleGroupThatDay.Where(x => x.MuscleGroup == "Shoulder").ToList().Count();
                ShoulderCount += temp;
            }
            return ShoulderCount;
        }

        public int CountOfBack()
        {
            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == AccountID).ToList();
            for (int i = 0; i > -DaysToRemove; i--)
            {
                var MuscleGroupThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = MuscleGroupThatDay.Where(x => x.MuscleGroup == "Back").ToList().Count();
                BackCount += temp;
            }
            return BackCount;
        }

        public int CountOfChest()
        {
            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == AccountID).ToList();
            for (int i = 0; i > -DaysToRemove; i--)
            {
                var MuscleGroupThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = MuscleGroupThatDay.Where(x => x.MuscleGroup == "Chest").ToList().Count();
                ChestCount += temp;
            }
            return ChestCount;
        }

        public int CountOfArm()
        {
            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == AccountID).ToList();
            for (int i = 0; i > -DaysToRemove; i--)
            {
                var MuscleGroupThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = MuscleGroupThatDay.Where(x => x.MuscleGroup == "Arm").ToList().Count();
                ArmCount += temp;
            }
            return ArmCount;
        }

        public int CountOfAbdmonial()
        {
            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == AccountID).ToList();
            for (int i = 0; i > -DaysToRemove; i--)
            {
                var MuscleGroupThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = MuscleGroupThatDay.Where(x => x.MuscleGroup == "Abdominal").ToList().Count();
                AbdominalCount += temp;
            }
            return AbdominalCount;
        }

        public int CountOfLeg()
        {
            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == AccountID).ToList();
            for (int i = 0; i > -DaysToRemove; i--)
            {
                var MuscleGroupThatDay = CurrentAccountExercise.Where(x => x.DayOfExercise == DateTime.Now.AddDays(i).Date).ToList();
                int temp = MuscleGroupThatDay.Where(x => x.MuscleGroup == "Leg").ToList().Count();
                LegCount += temp;
            }
            return LegCount;
        }



    }
}
