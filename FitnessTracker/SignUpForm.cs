using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
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
            string Username = UsernameTB.Text;
            string Password = PasswordTB.Text;
            string FirstName_ = FirstNameTB.Text;
            string Lastname_ = LastNameTB.Text;
            string Gender_ = "";


            if (genderCB.Text == "Male")
            {
                Gender_ = "M";
            }
            else if (genderCB.Text == "Female")
            {
                Gender_ = "F";
            }

            MessageBox.Show(Gender_);

            //Age 
            TimeSpan TempTimespan = DateTime.Now - birthdatePicker.Value.Date;
            string TempTimeSpanInDays = TempTimespan.Days.ToString();
            int Age_ = int.Parse(TempTimeSpanInDays) / 365;

            if (String.IsNullOrEmpty(UsernameTB.Text) || String.IsNullOrEmpty(PasswordTB.Text) || String.IsNullOrEmpty(FirstNameTB.Text)
                || String.IsNullOrEmpty(LastNameTB.Text) || String.IsNullOrEmpty(genderCB.Text))
            {
                WarningLabel.Visible = true; 
            }
            else
            {
                WarningLabel.Visible = false;

                // Saving the data to the database. 
                var _context = new UserDb();
                var User = new tbl_Users { Username_ = Username, Password_ = Password, FirstName = FirstName_, LastName = Lastname_, Age = Age_, Gender = Gender_ };
                _context.Add(User);
                _context.SaveChanges();

                MessageBox.Show("Thank you for making an account with us. Now you can sign in!","Thank you!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }
    }
}
