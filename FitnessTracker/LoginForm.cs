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

            try
            {
                var Login = _context.Users.Where(x => x.Username_ == UsernameTXT.Text && x.Password_ == PasswordTXT.Text).Single();
                MessageBox.Show("Yes now");
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
