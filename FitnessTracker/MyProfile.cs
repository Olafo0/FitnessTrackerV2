using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class MyProfile : Form
    {
        UserDb _context = new UserDb();
        int AccountID;

        public MyProfile(int accountID)
        {
            AccountID = accountID;
            InitializeComponent();
        }

        public void LoadingGoals()
        {
            var CurrentUser = _context.Users.Where(x => x.AccountID == AccountID).Single();


            if (String.IsNullOrEmpty(CurrentUser.Calorie_Day_Burn_Goal.ToString()) || String.IsNullOrEmpty(CurrentUser.Calorie_Week_Burn_Goal.ToString()))
            {
                CaloriesDayLB.ForeColor = Color.Red;
                CaloriesDayLB.Text = "No goal set";
                CaloriesWeekLB.ForeColor = Color.Red;
                CaloriesWeekLB.Text = "No goal set";
            }
            else if (String.IsNullOrEmpty(CurrentUser.Calorie_Day_Burn_Goal.ToString()))
            {
                CaloriesDayLB.ForeColor = Color.Red;
                CaloriesDayLB.Text = "No goal set";
            }
            else if (String.IsNullOrEmpty(CurrentUser.Calorie_Week_Burn_Goal.ToString()))
            {
                CaloriesWeekLB.ForeColor = Color.Red;
                CaloriesWeekLB.Text = "No goal set";
            }
            else
            {
                CaloriesDayLB.ForeColor = Color.Black;
                CaloriesDayLB.Text = CurrentUser.Calorie_Day_Burn_Goal.ToString();
                CaloriesWeekLB.ForeColor = Color.Black;
                CaloriesWeekLB.Text = CurrentUser.Calorie_Week_Burn_Goal.ToString();
            }
        }
        private void MyProfile_Load(object sender, EventArgs e)
        {
            var CurrentUser = _context.Users.Where(x => x.AccountID == AccountID).Single();


            WeekOrDayCB.SelectedIndex = 0;
            WeeklyPanel.Location = new Point(6, 83);
            WeeklyPanel.Visible = true;
            LoadingGoals();
        }
        private void WeekOrDayCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (WeekOrDayCB.Text == "Week")
            {
                DailyPanel.Visible = false;
                WeeklyPanel.Location = new Point(6, 83);
                WeeklyPanel.Visible = true;
            }
            else if (WeekOrDayCB.Text == "Day")
            {
                WeeklyPanel.Visible = false;
                DailyPanel.Location = new Point(6, 83);
                DailyPanel.Visible = true;
            }
        }

        private void WeeklyBTNSubmit_Click(object sender, EventArgs e)
        {
            int DailyCalo = int.Parse(WeekCaloriesTB.Text) / 7;

            var CurrentUser = _context.Users.Where(x => x.AccountID == AccountID).Single();

            CurrentUser.Calorie_Week_Burn_Goal = int.Parse(WeekCaloriesTB.Text);
            CurrentUser.Calorie_Day_Burn_Goal = DailyCalo;


            _context.SaveChanges();
            LoadingGoals();
            WeekCaloriesTB.Clear();
        }

        private void DailyBTNSubmit_Click(object sender, EventArgs e)
        {
            int WeeklyCalo = int.Parse(DailyCaloriesTB.Text) * 7;


            var CurrentUser = _context.Users.Where(x => x.AccountID == AccountID).Single();

            CurrentUser.Calorie_Day_Burn_Goal = int.Parse(DailyCaloriesTB.Text);
            CurrentUser.Calorie_Week_Burn_Goal = WeeklyCalo;
            _context.SaveChanges();
            LoadingGoals();
            DailyCaloriesTB.Clear();
        }

        private void CaloriesDayLB_Click(object sender, EventArgs e)
        {

        }

        private void CaloriesWeekLB_Click(object sender, EventArgs e)
        {
        }

        private void RemoveGoal_Click(object sender, EventArgs e)
        {
            var CurrentUser = _context.Users.Where(x => x.AccountID == AccountID).Single();
            CurrentUser.Calorie_Week_Burn_Goal = null;
            CurrentUser.Calorie_Day_Burn_Goal = null;
            _context.SaveChanges();
            LoadingGoals();

        }
    }
}
