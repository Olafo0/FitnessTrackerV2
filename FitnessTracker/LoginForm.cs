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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }


        // Verifying if the Username and the password is correct. 
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            var _context = new UserDb();
            string UserPassword = PasswordTXT.Text;
            string UserUsername = UsernameTXT.Text;
            try
            {
                var Login = _context.Users.Where(x => x.Username_ == UsernameTXT.Text & x.Password_ == UserPassword).First();
                if (Login.Password_ == UserPassword && Login.Username_ == UserUsername) 
                {
                    UsernameTXT.Text = "";
                    PasswordTXT.Text = "";
                    
                    MainHomePage MainPageLoad = new MainHomePage(Login);
                    MainPageLoad.Show();
                }
                else
                {
                    throw new System.InvalidOperationException();
                }

            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Incorrect Username or Password", "Incorrect Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void MakeAccountLB_Click(object sender, EventArgs e)
        {

        }
    }
}
