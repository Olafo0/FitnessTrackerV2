using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            loadform(new LoginForm());
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            loadform(new SignUpForm());
        }

        private void SignInBTN_Click(object sender, EventArgs e)
        {
            loadform(new LoginForm());
        }
    }
}
