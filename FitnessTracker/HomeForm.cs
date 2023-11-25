using FitnessTracker;
using LiveChartsCore;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
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


        public HomeForm(tbl_Users importLogin)
        {
            LoggedUser = importLogin;
            InitializeComponent();
        }

        PieChart pieChart;
        PieChart CalorieGauge;
        PieChart MuscleGroupPieChart;

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

                Location = new System.Drawing.Point(20, 32),
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

            CalorieGauge = new PieChart
            {
                Series = viewModel.Series,
                InitialRotation = -90,


                Location = new System.Drawing.Point(120, 32),
                Size = new System.Drawing.Size(220, 150),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom


            };
            panel1.Controls.Add(CalorieGauge);

            if (days == 3)
            {

                string ColourForLabel = viewModel.ColourUsed();
                CaloriesBurnedLB.Text = $"{viewModel.CountOfCalories()} / {LoggedUser.Calorie_Day_Burn_Goal * 3}";
                CaloriesBurnedLB.ForeColor = ColorTranslator.FromHtml(ColourForLabel);
            }
            else if (days == 7)
            {
                string ColourForLabel = viewModel.ColourUsed();
                CaloriesBurnedLB.Text = $"{viewModel.CountOfCalories()} / {LoggedUser.Calorie_Week_Burn_Goal}";
                CaloriesBurnedLB.ForeColor = ColorTranslator.FromHtml(ColourForLabel);
            }
            else if (days == 14)
            {
                string ColourForLabel = viewModel.ColourUsed();
                CaloriesBurnedLB.Text = $"{viewModel.CountOfCalories()} / {LoggedUser.Calorie_Week_Burn_Goal * 2}";
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

                Location = new System.Drawing.Point(300, 32),
                Size = new System.Drawing.Size(220, 150),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };
            panel1.Controls.Add(MuscleGroupPieChart);

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

            DaySelector.SelectedIndex = 1;

            // Building off this at some point.... 
            //var eee = _context.Exercises.Where(x => x.DayOfExercise == DateTime.Now.Date).ToList();
            //DateTime DayOfYesterday = DateTime.Now.AddDays(-1);
            //DateTime DayOfYesterdayF = DayOfYesterday.Date;
            //var eee2 = _context.Exercises.Where(x => x.DayOfExercise == DayOfYesterdayF).ToList();
            // .. .. .. .. .. ..
        }

        private void DaySelector_SelectedValueChanged(object sender, EventArgs e)
        {
            ExerciseTypePieChart(int.Parse(DaySelector.Text));
            CaloriesTotalGauge(int.Parse(DaySelector.Text));
            MuslceGroupPieChart(int.Parse(DaySelector.Text));
        }
    }
}