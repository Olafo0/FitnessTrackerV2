using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class SignUpForm : Form
    {

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void CreateAccountBTN_Click(object sender, EventArgs e)
        {
            Regex ValidatePassword = new Regex("(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[?!@$%^&*-]).{8,}");
            var _context = new UserDb();


            if (String.IsNullOrEmpty(UsernameTB.Text) || String.IsNullOrEmpty(PasswordTB.Text) || String.IsNullOrEmpty(FirstNameTB.Text)
                || String.IsNullOrEmpty(LastNameTB.Text) || String.IsNullOrEmpty(genderCB.Text))
            {
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.Visible = false;

                string Username = UsernameTB.Text;
                string Password = PasswordTB.Text;
                string FirstName_ = FirstNameTB.Text;
                string Lastname_ = LastNameTB.Text;
                string UserEmail = EmailTB.Text;    
                string Gender_ = "";

                if (genderCB.Text == "Male")
                {
                    Gender_ = "M";
                }
                else if (genderCB.Text == "Female")
                {
                    Gender_ = "F";
                }

                //Age 
                TimeSpan TempTimespan = DateTime.Now - birthdatePicker.Value.Date;
                string TempTimeSpanInDays = TempTimespan.Days.ToString();
                int Age_ = int.Parse(TempTimeSpanInDays) / 365;

                // Getting all the Usernames.
                var CurrentUsers = _context.Users.Where(x => x.AccountID >= 0);
                List<string?> TakenUsernames = new List<string?>();
                foreach (var user in CurrentUsers)
                {
                    TakenUsernames.Add(user.Username_);
                }

                if (TakenUsernames.Contains(Username))
                {
                    WarningLabel1.Visible = true;
                }
                else
                {
                    WarningLabel1.Visible = false;
                    // Validating the password by using Regex.
                    if (ValidatePassword.IsMatch(Password) == true)
                    {
                        // Saving the data to the database. 

                        var User = new tbl_Users { Username_ = Username, Password_ = Password, FirstName = FirstName_, LastName = Lastname_, Age = Age_, Gender = Gender_, Email = UserEmail};
                        _context.Add(User);
                        _context.SaveChanges();

                        MessageBox.Show("Thank you for making an account with us. Now you can sign in!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You don't meet the password requirement(s)", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
