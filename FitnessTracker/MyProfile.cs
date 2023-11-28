using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.Kernel;

namespace FitnessTracker
{
    public partial class MyProfile : Form
    {
        UserDb _context = new UserDb();
        int AccountID;
        int CodeGenerated;
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

            var CurrentAccountExercise = _context.Exercises.Where(x => x.AccountID == AccountID).ToList();
            int totalCaloriesBurned = CurrentAccountExercise.Sum(x => x.Calories);

            WeekOrDayCB.SelectedIndex = 0;
            WeeklyPanel.Location = new Point(6, 83);
            WeeklyPanel.Visible = true;
            LoadingGoals();

            NameTB.Text = CurrentUser.FirstName;
            LastNameTB.Text = CurrentUser.LastName;
            AgeTB.Text = CurrentUser.Age.ToString();

            if (CurrentUser.Gender == "M")
            {
                GenderTB.Text = "Male";
            }
            else if (CurrentUser.Gender == "F")
            {
                GenderTB.Text = "Female";
            }

            CaloriesBurnedTB.Text = totalCaloriesBurned.ToString();

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

        private void ChangePasswordBTN_Click(object sender, EventArgs e)
        {
            Regex ValidateNewPassword = new Regex("(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[?!@$%^&*-]).{8,}");

            var CurrentUser = _context.Users.Where(x => x.AccountID == AccountID).Single();

            string CurrentPassword = CurrentPasswordTB.Text;
            string NewPassword = ChangePasswordTB.Text;

            if (CurrentUser.Password_ == CurrentPassword)
            {
                if (ValidateNewPassword.IsMatch(NewPassword) == true)
                {
                    IncPassLB.Visible = false;
                    CurrentUser.Password_ = NewPassword;
                    _context.SaveChanges();

                    CurrentPasswordTB.Text = "";
                    ChangePasswordTB.Text = "";

                    MessageBox.Show("Password change has been successful", "New password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Password entered doesn't match your current Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IncPassLB.Visible = true;
                }
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ChangeCurPassBTN_Click(object sender, EventArgs e)
        {
            IncPassLB.Visible = true;
            SendEmailCodeBTN.Visible = true;
            ForgotPassPanel.Visible = false;
            NewPasswordCurrentPanel.Location = new(17, 54);
            NewPasswordCurrentPanel.Visible = true;
        }

        private void SendEmailCodeBTN_Click(object sender, EventArgs e)
        {
            var CurrentUser = _context.Users.Where(x => x.AccountID == AccountID).Single();

            Random RandomCodeForEmail = new Random();
            CodeGenerated = RandomCodeForEmail.Next(100, 1000);

            // Set up the sender's email address and password
            string senderEmail = "x"; // Add your email
            string senderPassword = "x"; // Add your 'APP PASSWORD' - Please search this on google

            // Set up the recipient's email address
            string recipientEmail = CurrentUser.Email;

            // Create a new MailMessage
            MailMessage mail = new MailMessage(senderEmail, recipientEmail);


            mail.Subject = "Your FitnessTracker password reset token";
            mail.Body = CodeGenerated.ToString();

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mail);
                MessageBox.Show("Token sent!", "Password reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SendEmailCodeBTN.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ContinueBTN_Click(object sender, EventArgs e)
        {
            if (CodeGenerated == int.Parse(EmailCodeTB.Text))
            {
                EmailCodeTB.Text = "";
                ForgotPassPanel.Visible = false;
                ChangePassEmailPanel.Location = new(17, 54);
                ChangePassEmailPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("The token you entered was incorrect :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SendEmailCodeBTN.Visible = false;
            }
        }

        private void ForgotPassBTN_Click(object sender, EventArgs e)
        {
            NewPasswordCurrentPanel.Visible = false;
            ForgotPassPanel.Location = new(17, 54);
            ForgotPassPanel.Visible = true;
        }

        private void ChangePassBTN_Click(object sender, EventArgs e)
        {
            var CurrentUser = _context.Users.Where(x => x.AccountID == AccountID).Single();

            Regex ValidateNewPassword = new Regex("(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[?!@$%^&*-]).{8,}");

            string NewPassword = NewPasswordTB2.Text;

            if (ValidateNewPassword.IsMatch(NewPassword) == true)
            {
                IncPassLB.Visible = false;
                CurrentUser.Password_ = NewPassword;
                _context.SaveChanges();

                NewPasswordTB2.Text = "";
                MessageBox.Show("Password change has been successful", "New password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ForgotPassBTN.Visible = false;
            }
            else
            {
                MessageBox.Show("Password is missing requirements", "Password requirements", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
