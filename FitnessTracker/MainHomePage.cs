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
    public partial class MainHomePage : Form
    {
        tbl_Users ImportLogin;

        bool SidebarExpand = false;
        public MainHomePage(tbl_Users login)
        {
            ImportLogin = login;
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






        private void MenuBTN_Click(object sender, EventArgs e)
        {
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            loadform(new HomeForm(ImportLogin));
        }

        private void AddActivityBTN_Click(object sender, EventArgs e)
        {
            loadform(new AddingExercise(ImportLogin.AccountID));
        }

        private void MyProfileBTN_Click(object sender, EventArgs e)
        {
        }

        private void AboutBTN_Click(object sender, EventArgs e)
        {
        }

        private void MainHomePage_Load(object sender, EventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
