using FitnessTracker;
using LiveChartsCore;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
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
        private void HomeForm_Load(object sender, EventArgs e)
        {
            // Building off this at some point.... 
            //var eee = _context.Exercises.Where(x => x.DayOfExercise == DateTime.Now.Date).ToList();
            //DateTime DayOfYesterday = DateTime.Now.AddDays(-1);
            //DateTime DayOfYesterdayF = DayOfYesterday.Date;
            //var eee2 = _context.Exercises.Where(x => x.DayOfExercise == DayOfYesterdayF).ToList();
            // .. .. .. .. .. ..

            Size = new System.Drawing.Size(50, 50);

            var viewModel = new ViewModel(LoggedUser.AccountID);

            pieChart = new PieChart
            {
                Series = viewModel.Series,
                Location = new System.Drawing.Point(0, 100),
                Size = new System.Drawing.Size(150, 150),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };
            Controls.Add(pieChart);
        }
    }
}