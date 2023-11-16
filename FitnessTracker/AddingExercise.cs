using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class AddingExercise : Form
    {
        int ID;

        public AddingExercise(int accountID)
        {
            ID = accountID;
            InitializeComponent();
        }

        private void AddingExercise_Load(object sender, EventArgs e)
        {
            DateTime MinDate = DateTime.Now.AddDays(-10);
            DateTime MaxDate = DateTime.Now.AddDays(10);
            ExerciseDatePickDP.MinDate = MinDate;
            ExerciseDatePickDP.MaxDate = MaxDate;

        }

        private void AddActivityBTN_Click(object sender, EventArgs e)
        {
            var _context = new UserDb();


            if (String.IsNullOrEmpty(TypeOfExerCB.Text) || String.IsNullOrEmpty(ExerciseNameTXT.Text) || String.IsNullOrEmpty(MuscleGroupCB.Text)
                || String.IsNullOrEmpty(CaloriesBrnTXT.Text) || String.IsNullOrEmpty(SessionDuration.Text))
            {
                WarningLabel1.Visible = true;
            }
            else
            {
                WarningLabel1.Visible = false;

                string TypeExercise = TypeOfExerCB.Text;
                string ExeName = ExerciseNameTXT.Text;
                string ExeMuscleGroup = MuscleGroupCB.Text;
                int CalBurned = int.Parse(CaloriesBrnTXT.Text);
                int Duration = int.Parse(SessionDuration.Text);

                DateTime? DateOfExercise = ExerciseDatePickDP.Value.Date;

                var Exercise = new tbl_Exercises { TypeOfExercise = TypeExercise, ExerciseName = ExeName, LengthOfExercise = Duration, Calories = CalBurned, AccountID = ID, DayOfExercise = DateOfExercise, MuscleGroup = ExeMuscleGroup };

                _context.Add(Exercise);
                _context.SaveChanges();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
