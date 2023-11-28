using FitnessTracker;
using LiveChartsCore;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class HomeForm : Form
    {
        tbl_Users LoggedUser;
        UserDb _context = new UserDb();

        Boolean ExerciseDoneToday = false;

        public HomeForm(tbl_Users importLogin)
        {
            LoggedUser = importLogin;
            InitializeComponent();
        }

        PieChart pieChart;
        PieChart CalorieGauge;
        PieChart CalorieGauge_Daily;
        PieChart MuscleGroupPieChart;
        PieChart ExerciseType_Day;
        PieChart MinutesActiveGauge_Daily;
        CartesianChart ActMinutesLineChart;

        public void ExerciseTypePieChart(int days)
        {
            if (panel1.Contains(pieChart))
            {
                panel1.Controls.Remove(pieChart);
            }
            Size = new System.Drawing.Size(50, 50);

            var viewModel = new ViewModel(LoggedUser.AccountID, days);

            pieChart = new PieChart
            {
                Series = viewModel.Series,
                TooltipTextSize = 16,

                Location = new System.Drawing.Point(20, 52),
                Size = new System.Drawing.Size(150, 150),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };
            panel1.Controls.Add(pieChart);
        }

        public void CaloriesTotalGauge(int days)
        {
            if (panel1.Contains(CalorieGauge))
            {
                panel1.Controls.Remove(CalorieGauge);
            }

            Size = new System.Drawing.Size(50, 50);

            var viewModel = new CaloriesViewModel(LoggedUser.AccountID, days);

            int CaloriesBurned__ = viewModel.CountOfCalories();

            CalorieGauge = new PieChart
            {
                Series = viewModel.Series,
                InitialRotation = -90,


                Location = new System.Drawing.Point(155, 52),
                Size = new System.Drawing.Size(220, 150),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom


            };
            panel1.Controls.Add(CalorieGauge);

            if (days == 3)
            {

                string ColourForLabel = viewModel.ColourUsed();
                CaloriesBurnedLB.Text = $"{CaloriesBurned__} / {LoggedUser.Calorie_Day_Burn_Goal * 3}";
                CaloriesBurnedLB.ForeColor = ColorTranslator.FromHtml(ColourForLabel);
            }
            else if (days == 7)
            {
                string ColourForLabel = viewModel.ColourUsed();
                CaloriesBurnedLB.Text = $"{CaloriesBurned__} / {LoggedUser.Calorie_Week_Burn_Goal}";
                CaloriesBurnedLB.ForeColor = ColorTranslator.FromHtml(ColourForLabel);
            }
            else if (days == 14)
            {
                string ColourForLabel = viewModel.ColourUsed();
                CaloriesBurnedLB.Text = $"{CaloriesBurned__} / {LoggedUser.Calorie_Week_Burn_Goal * 2}";
                CaloriesBurnedLB.ForeColor = ColorTranslator.FromHtml(ColourForLabel);
            }
        }
        public void MuslceGroupPieChart(int days)
        {
            if (panel1.Controls.Contains(MuscleGroupPieChart))
            {
                panel1.Controls.Remove(MuscleGroupPieChart);
            }


            Size = new System.Drawing.Size(50, 50);
            var viewModel = new MuscleGroupViewModel(LoggedUser.AccountID, days);

            MuscleGroupPieChart = new PieChart
            {
                Series = viewModel.Series,
                InitialRotation = -90,
                TooltipTextSize = 12,

                Location = new System.Drawing.Point(334, 52),
                Size = new System.Drawing.Size(220, 150),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };
            panel1.Controls.Add(MuscleGroupPieChart);
        }

        public void MinutesThroughWeek(int days)
        {
            if (panel1.Controls.Contains(ActMinutesLineChart))
            {
                panel1.Controls.Remove(ActMinutesLineChart);
            }

            Size = new System.Drawing.Size(50, 50);

            var viewModel = new MinutesActViewModel(LoggedUser.AccountID, days);
            ActMinutesLineChart = new CartesianChart
            {
                Series = viewModel.Series,
                TooltipTextSize = 12,

                Location = new System.Drawing.Point(550, 0),
                Size = new System.Drawing.Size(270, 250),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            panel1.Controls.Add(ActMinutesLineChart);
        }

        public void CaloriesTotalGauge_Daily()
        {
            if (panel2.Contains(CalorieGauge_Daily))
            {
                panel2.Controls.Remove(CalorieGauge_Daily);
            }

            Size = new System.Drawing.Size(50, 50);

            var viewModel = new CaloriesViewModel_Daily(LoggedUser.AccountID);

            int CaloriesBurned__ = viewModel.CountOfCalories();



            if (CaloriesBurned__ <= 0)
            {
                DailyCalWarningLB.Text = "No Data\nprovided\ntoday";
                DailyCalWarningLB.Font = new Font("Segoe UI", 14);
                DailyCalWarningLB.Location = new(43, 45);
                DailyCalWarningLB.ForeColor = Color.IndianRed;
                DailyCalWarningLB.Visible = true;
                DailyCalorieLB.Text = $"{CaloriesBurned__} / {LoggedUser.Calorie_Day_Burn_Goal}";
                DailyCalorieLB.Visible = true;
            }
            else
            {
                DailyCalWarningLB.Visible = false;
                ExerciseDoneToday = true;
                CalorieGauge_Daily = new PieChart
                {
                    Series = viewModel.Series,
                    InitialRotation = -90,
                    TooltipTextSize = 12,

                    Location = new System.Drawing.Point(1, 32),
                    Size = new System.Drawing.Size(170, 100),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
                };

                panel2.Controls.Add(CalorieGauge_Daily);
                string ColourForLabel = viewModel.ColourUsed();
                DailyCalorieLB.Text = $"{CaloriesBurned__} / {LoggedUser.Calorie_Day_Burn_Goal}";
                DailyCalorieLB.Location = new(21, 15);
                DailyCalorieLB.ForeColor = ColorTranslator.FromHtml(ColourForLabel);
                DailyCalorieLB.Visible = true;

                if (CaloriesBurned__ >= (LoggedUser.Calorie_Day_Burn_Goal * 115 / 100))
                {
                    CalorieDailyFeedbackLB.Text = "You're a demon! >:)\nkeep going! ";

                    CalorieDailyFeedbackLB.Visible = true;
                }
                else if (CaloriesBurned__ >= (LoggedUser.Calorie_Day_Burn_Goal * 100 / 100))
                {
                    CalorieDailyFeedbackLB.Text = "You've reached your\ndaily goal!";

                    CalorieDailyFeedbackLB.Visible = true;
                }
                else if (CaloriesBurned__ >= (LoggedUser.Calorie_Day_Burn_Goal * 75 / 100))
                {
                    CalorieDailyFeedbackLB.Text = "You're nearly there\nkeep going!";

                    CalorieDailyFeedbackLB.Visible = true;
                }
                else if (CaloriesBurned__ >= (LoggedUser.Calorie_Day_Burn_Goal * 40 / 100))
                {
                    CalorieDailyFeedbackLB.Text = "I was expecting\nmore from you";

                    CalorieDailyFeedbackLB.Visible = true;
                }
                else if (CaloriesBurned__ >= (LoggedUser.Calorie_Day_Burn_Goal * 25 / 100))
                {
                    CalorieDailyFeedbackLB.Text = "Are you even trying?";

                    CalorieDailyFeedbackLB.Visible = true;
                }
                else if (CaloriesBurned__ < (LoggedUser.Calorie_Day_Burn_Goal * 25 / 100))
                {
                    CalorieDailyFeedbackLB.Text = "Don't make me laugh\nYou've only just\nbegan.";

                    CalorieDailyFeedbackLB.Visible = true;
                }
            }
        }

        public void MinutesWorkedOutGauge()
        {
            Size = new System.Drawing.Size(50, 50);
            var viewModel = new MinutesWorkedOutViewModel_Daily(LoggedUser.AccountID);


            if (ExerciseDoneToday == false)
            {
                DailyMinWarningLB.Text = "No Data\nprovided\ntoday";
                DailyMinWarningLB.Font = new Font("Segoe UI", 14);
                DailyMinWarningLB.Location = new(233, 45);
                DailyMinWarningLB.ForeColor = Color.IndianRed;
                DailyMinWarningLB.Visible = true;
                label9.Visible = false;
            }
            else
            {
                label9.Visible = true;
                DailyMinWarningLB.Visible = false;
                MinutesActiveGauge_Daily = new PieChart
                {
                    Series = viewModel.Series,
                    InitialRotation = -90,
                    TooltipTextSize = 12,

                    Location = new System.Drawing.Point(190, 12),
                    Size = new System.Drawing.Size(170, 100),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
                };

                panel2.Controls.Add(MinutesActiveGauge_Daily);
            }
        }

        public void ExerciseType_Daily()
        {

            Size = new System.Drawing.Size(50, 50);
            var viewModel = new ExerciseType_Daily(LoggedUser.AccountID);

            ExerciseType_Day = new PieChart
            {
                Series = viewModel.Series,
                TooltipTextSize = 12,

                Location = new System.Drawing.Point(190, 107),
                Size = new System.Drawing.Size(170, 100),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            panel2.Controls.Add(ExerciseType_Day);
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoginASLB.Text = $"Logged in as {LoggedUser.Username_}";
            TodaySummaryLB.Text = $"{DateTime.Now.Date.ToString("dd/MM/yyyy")} Summary :";
            DaySelector.SelectedIndex = 1;

            // Initiating methods
            CaloriesTotalGauge_Daily();
            MinutesWorkedOutGauge();
            ExerciseType_Daily();
        }

        private void DaySelector_SelectedValueChanged(object sender, EventArgs e)
        {

            var viewModel = new CaloriesViewModel(LoggedUser.AccountID, int.Parse(DaySelector.Text));
            if (viewModel.CountOfCalories() <= 0)
            {
                panel1.Controls.Remove(pieChart);
                panel1.Controls.Remove(CalorieGauge);
                panel1.Controls.Remove(MuscleGroupPieChart);
                panel1.Controls.Remove(ActMinutesLineChart);

                CaloriesBurnedLB.Text = "No Data\nProvided";
                CaloriesBurnedLB.Font = new Font("Segoe UI", 14);
                CaloriesBurnedLB.Location = new(220, 65);
                CaloriesBurnedLB.ForeColor = Color.IndianRed;


                MGULB.Text = "No Data\nProvided";
                MGULB.Font = new Font("Segoe UI", 14);
                MGULB.Location = new(398, 65);
                MGULB.ForeColor = Color.IndianRed;
                MGULB.Visible = true;


                TOE2LB.Text = "No Data\nProvided";
                TOE2LB.Font = new Font("Segoe UI", 14);
                TOE2LB.Location = new(58, 65);
                TOE2LB.ForeColor = Color.IndianRed;
                TOE2LB.Visible = true;

                AddAcLB.Visible = true;

                LineGraphLB.Text = "No Data\nProvided";
                LineGraphLB.Font = new Font("Segoe UI", 14);
                LineGraphLB.Location = new(638, 65);
                LineGraphLB.ForeColor = Color.IndianRed;
                LineGraphLB.Visible = true;
            }
            else
            {
                AddAcLB.Visible = false;
                MGULB.Visible = false;
                TOE2LB.Visible = false;
                LineGraphLB.Visible = false;
                DayLB.Visible = true;

                CaloriesBurnedLB.Location = new(232, 199);
                CaloriesBurnedLB.Font = new Font("Segoe UI", 9);
                ExerciseTypePieChart(int.Parse(DaySelector.Text));
                CaloriesTotalGauge(int.Parse(DaySelector.Text));
                MuslceGroupPieChart(int.Parse(DaySelector.Text));
                MinutesThroughWeek(int.Parse(DaySelector.Text));
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ACEFitnessBTN_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://www.acefitness.org/resources/everyone/exercise-library/")
            {
                UseShellExecute = true,
            };
            Process.Start(ps);
        }
    }
}