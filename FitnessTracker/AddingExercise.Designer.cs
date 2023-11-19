namespace FitnessTracker
{
    partial class AddingExercise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingExercise));
            groupBox1 = new GroupBox();
            TypeOfExerCB = new ComboBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            SessionDuration = new TextBox();
            label5 = new Label();
            label3 = new Label();
            CaloriesBrnTXT = new TextBox();
            MuscleGroupCB = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            ExerciseNameTXT = new TextBox();
            ExerciseDatePickDP = new DateTimePicker();
            label4 = new Label();
            AddActivityBTN = new Button();
            WarningLabel1 = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TypeOfExerCB);
            groupBox1.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(314, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type of workout";
            // 
            // TypeOfExerCB
            // 
            TypeOfExerCB.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeOfExerCB.FormattingEnabled = true;
            TypeOfExerCB.Items.AddRange(new object[] { "Cardio", "Strength " });
            TypeOfExerCB.Location = new Point(86, 33);
            TypeOfExerCB.Name = "TypeOfExerCB";
            TypeOfExerCB.Size = new Size(99, 25);
            TypeOfExerCB.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(SessionDuration);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(CaloriesBrnTXT);
            groupBox2.Controls.Add(MuscleGroupCB);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(ExerciseNameTXT);
            groupBox2.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(314, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 194);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Exercise Details";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(15, 165);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 6;
            label6.Text = "* Minutes";
            // 
            // SessionDuration
            // 
            SessionDuration.Location = new Point(130, 142);
            SessionDuration.Name = "SessionDuration";
            SessionDuration.Size = new Size(103, 25);
            SessionDuration.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 145);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 4;
            label5.Text = "Session duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 109);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 2;
            label3.Text = "Calories burned";
            // 
            // CaloriesBrnTXT
            // 
            CaloriesBrnTXT.Location = new Point(130, 106);
            CaloriesBrnTXT.Name = "CaloriesBrnTXT";
            CaloriesBrnTXT.Size = new Size(103, 25);
            CaloriesBrnTXT.TabIndex = 2;
            // 
            // MuscleGroupCB
            // 
            MuscleGroupCB.DropDownStyle = ComboBoxStyle.DropDownList;
            MuscleGroupCB.FormattingEnabled = true;
            MuscleGroupCB.Items.AddRange(new object[] { "Shoulder", "Back", "Chest", "Arm", "Abdominal", "Leg", "" });
            MuscleGroupCB.Location = new Point(130, 67);
            MuscleGroupCB.Name = "MuscleGroupCB";
            MuscleGroupCB.Size = new Size(103, 25);
            MuscleGroupCB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 70);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 3;
            label2.Text = "Muscle Group";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(94, 17);
            label1.TabIndex = 2;
            label1.Text = "Exercise Name";
            // 
            // ExerciseNameTXT
            // 
            ExerciseNameTXT.Location = new Point(130, 30);
            ExerciseNameTXT.Name = "ExerciseNameTXT";
            ExerciseNameTXT.Size = new Size(103, 25);
            ExerciseNameTXT.TabIndex = 2;
            // 
            // ExerciseDatePickDP
            // 
            ExerciseDatePickDP.CalendarTitleBackColor = SystemColors.ActiveBorder;
            ExerciseDatePickDP.Cursor = Cursors.Hand;
            ExerciseDatePickDP.Font = new Font("Arimo", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ExerciseDatePickDP.Location = new Point(38, 35);
            ExerciseDatePickDP.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            ExerciseDatePickDP.Name = "ExerciseDatePickDP";
            ExerciseDatePickDP.RightToLeft = RightToLeft.No;
            ExerciseDatePickDP.Size = new Size(167, 21);
            ExerciseDatePickDP.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(38, 15);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 2;
            label4.Text = "( Optional * )";
            // 
            // AddActivityBTN
            // 
            AddActivityBTN.FlatStyle = FlatStyle.Flat;
            AddActivityBTN.Location = new Point(400, 477);
            AddActivityBTN.Name = "AddActivityBTN";
            AddActivityBTN.Size = new Size(91, 23);
            AddActivityBTN.TabIndex = 2;
            AddActivityBTN.Text = "Add Activity";
            AddActivityBTN.UseVisualStyleBackColor = true;
            AddActivityBTN.Click += AddActivityBTN_Click;
            // 
            // WarningLabel1
            // 
            WarningLabel1.AutoSize = true;
            WarningLabel1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            WarningLabel1.ForeColor = Color.Red;
            WarningLabel1.Location = new Point(285, 513);
            WarningLabel1.Name = "WarningLabel1";
            WarningLabel1.Size = new Size(328, 30);
            WarningLabel1.TabIndex = 3;
            WarningLabel1.Text = "You have one or more field empty";
            WarningLabel1.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ExerciseDatePickDP);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(314, 388);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(261, 71);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Date Of Exercise";
            // 
            // AddingExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 607);
            Controls.Add(groupBox3);
            Controls.Add(WarningLabel1);
            Controls.Add(AddActivityBTN);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddingExercise";
            Text = "AddingExercise";
            Load += AddingExercise_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox TypeOfExerCB;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox ExerciseNameTXT;
        private ComboBox MuscleGroupCB;
        private Label label2;
        private TextBox CaloriesBrnTXT;
        private DateTimePicker ExerciseDatePickDP;
        private Label label4;
        private Label label3;
        private Button AddActivityBTN;
        private Label WarningLabel1;
        private Label label5;
        private TextBox SessionDuration;
        private Label label6;
        private GroupBox groupBox3;
    }
}