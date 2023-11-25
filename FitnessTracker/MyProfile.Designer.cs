namespace FitnessTracker
{
    partial class MyProfile
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
            CurrentGoalsGP = new GroupBox();
            CaloriesDayLB = new Label();
            CaloriesWeekLB = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SetUpGoalGB = new GroupBox();
            label6 = new Label();
            WeeklyPanel = new Panel();
            WeeklyBTNSubmit = new Button();
            label4 = new Label();
            WeekCaloriesTB = new TextBox();
            DailyPanel = new Panel();
            DailyBTNSubmit = new Button();
            label5 = new Label();
            DailyCaloriesTB = new TextBox();
            WeekOrDayCB = new ComboBox();
            RemoveGoal = new Button();
            CurrentGoalsGP.SuspendLayout();
            SetUpGoalGB.SuspendLayout();
            WeeklyPanel.SuspendLayout();
            DailyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CurrentGoalsGP
            // 
            CurrentGoalsGP.Controls.Add(RemoveGoal);
            CurrentGoalsGP.Controls.Add(CaloriesDayLB);
            CurrentGoalsGP.Controls.Add(CaloriesWeekLB);
            CurrentGoalsGP.Controls.Add(label3);
            CurrentGoalsGP.Controls.Add(label2);
            CurrentGoalsGP.Controls.Add(label1);
            CurrentGoalsGP.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentGoalsGP.Location = new Point(369, 12);
            CurrentGoalsGP.Name = "CurrentGoalsGP";
            CurrentGoalsGP.Size = new Size(529, 261);
            CurrentGoalsGP.TabIndex = 0;
            CurrentGoalsGP.TabStop = false;
            CurrentGoalsGP.Text = "Current Goals";
            // 
            // CaloriesDayLB
            // 
            CaloriesDayLB.AutoSize = true;
            CaloriesDayLB.Location = new Point(140, 85);
            CaloriesDayLB.Name = "CaloriesDayLB";
            CaloriesDayLB.Size = new Size(0, 17);
            CaloriesDayLB.TabIndex = 4;
            CaloriesDayLB.Click += CaloriesDayLB_Click;
            // 
            // CaloriesWeekLB
            // 
            CaloriesWeekLB.AutoSize = true;
            CaloriesWeekLB.Location = new Point(140, 60);
            CaloriesWeekLB.Name = "CaloriesWeekLB";
            CaloriesWeekLB.Size = new Size(0, 17);
            CaloriesWeekLB.TabIndex = 3;
            CaloriesWeekLB.Click += CaloriesWeekLB_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 85);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 2;
            label3.Text = "Daily -- >";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 60);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 1;
            label2.Text = "Weekly -- > ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 0;
            label1.Text = "Calories to burn:";
            // 
            // SetUpGoalGB
            // 
            SetUpGoalGB.Controls.Add(label6);
            SetUpGoalGB.Controls.Add(WeeklyPanel);
            SetUpGoalGB.Controls.Add(DailyPanel);
            SetUpGoalGB.Controls.Add(WeekOrDayCB);
            SetUpGoalGB.Location = new Point(12, 12);
            SetUpGoalGB.Name = "SetUpGoalGB";
            SetUpGoalGB.Size = new Size(300, 261);
            SetUpGoalGB.TabIndex = 2;
            SetUpGoalGB.TabStop = false;
            SetUpGoalGB.Text = "Set up goal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 36);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 3;
            label6.Text = "Select your preference";
            // 
            // WeeklyPanel
            // 
            WeeklyPanel.Controls.Add(WeeklyBTNSubmit);
            WeeklyPanel.Controls.Add(label4);
            WeeklyPanel.Controls.Add(WeekCaloriesTB);
            WeeklyPanel.ForeColor = SystemColors.ControlText;
            WeeklyPanel.Location = new Point(268, 119);
            WeeklyPanel.Name = "WeeklyPanel";
            WeeklyPanel.Size = new Size(256, 136);
            WeeklyPanel.TabIndex = 1;
            WeeklyPanel.Visible = false;
            // 
            // WeeklyBTNSubmit
            // 
            WeeklyBTNSubmit.FlatStyle = FlatStyle.Flat;
            WeeklyBTNSubmit.Location = new Point(89, 86);
            WeeklyBTNSubmit.Name = "WeeklyBTNSubmit";
            WeeklyBTNSubmit.Size = new Size(75, 23);
            WeeklyBTNSubmit.TabIndex = 2;
            WeeklyBTNSubmit.Text = "Enter";
            WeeklyBTNSubmit.UseVisualStyleBackColor = true;
            WeeklyBTNSubmit.Click += WeeklyBTNSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 16);
            label4.Name = "label4";
            label4.Size = new Size(192, 15);
            label4.TabIndex = 1;
            label4.Text = "Calories per week you want to burn";
            // 
            // WeekCaloriesTB
            // 
            WeekCaloriesTB.Location = new Point(72, 46);
            WeekCaloriesTB.Name = "WeekCaloriesTB";
            WeekCaloriesTB.Size = new Size(114, 23);
            WeekCaloriesTB.TabIndex = 0;
            // 
            // DailyPanel
            // 
            DailyPanel.Controls.Add(DailyBTNSubmit);
            DailyPanel.Controls.Add(label5);
            DailyPanel.Controls.Add(DailyCaloriesTB);
            DailyPanel.ForeColor = SystemColors.ControlText;
            DailyPanel.Location = new Point(6, 119);
            DailyPanel.Name = "DailyPanel";
            DailyPanel.Size = new Size(256, 136);
            DailyPanel.TabIndex = 2;
            DailyPanel.Visible = false;
            // 
            // DailyBTNSubmit
            // 
            DailyBTNSubmit.FlatStyle = FlatStyle.Flat;
            DailyBTNSubmit.Location = new Point(89, 86);
            DailyBTNSubmit.Name = "DailyBTNSubmit";
            DailyBTNSubmit.Size = new Size(75, 23);
            DailyBTNSubmit.TabIndex = 2;
            DailyBTNSubmit.Text = "Enter";
            DailyBTNSubmit.UseVisualStyleBackColor = true;
            DailyBTNSubmit.Click += DailyBTNSubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 16);
            label5.Name = "label5";
            label5.Size = new Size(184, 15);
            label5.TabIndex = 1;
            label5.Text = "Calories per day you want to burn";
            // 
            // DailyCaloriesTB
            // 
            DailyCaloriesTB.Location = new Point(72, 46);
            DailyCaloriesTB.Name = "DailyCaloriesTB";
            DailyCaloriesTB.Size = new Size(114, 23);
            DailyCaloriesTB.TabIndex = 0;
            // 
            // WeekOrDayCB
            // 
            WeekOrDayCB.FormattingEnabled = true;
            WeekOrDayCB.Items.AddRange(new object[] { "Week", "Day" });
            WeekOrDayCB.Location = new Point(95, 54);
            WeekOrDayCB.Name = "WeekOrDayCB";
            WeekOrDayCB.Size = new Size(76, 23);
            WeekOrDayCB.TabIndex = 0;
            WeekOrDayCB.SelectedValueChanged += WeekOrDayCB_SelectedValueChanged;
            // 
            // RemoveGoal
            // 
            RemoveGoal.FlatStyle = FlatStyle.Flat;
            RemoveGoal.Location = new Point(16, 214);
            RemoveGoal.Name = "RemoveGoal";
            RemoveGoal.Size = new Size(107, 29);
            RemoveGoal.TabIndex = 5;
            RemoveGoal.Text = "Remove Goal";
            RemoveGoal.UseVisualStyleBackColor = true;
            RemoveGoal.Click += RemoveGoal_Click;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 607);
            Controls.Add(SetUpGoalGB);
            Controls.Add(CurrentGoalsGP);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyProfile";
            Text = "MyProfile";
            Load += MyProfile_Load;
            CurrentGoalsGP.ResumeLayout(false);
            CurrentGoalsGP.PerformLayout();
            SetUpGoalGB.ResumeLayout(false);
            SetUpGoalGB.PerformLayout();
            WeeklyPanel.ResumeLayout(false);
            WeeklyPanel.PerformLayout();
            DailyPanel.ResumeLayout(false);
            DailyPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CurrentGoalsGP;
        private Label CaloriesWeekLB;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label CaloriesDayLB;
        private GroupBox SetUpGoalGB;
        private ComboBox WeekOrDayCB;
        private Panel WeeklyPanel;
        private Button WeeklyBTNSubmit;
        private Label label4;
        private TextBox WeekCaloriesTB;
        private Panel DailyPanel;
        private Button DailyBTNSubmit;
        private Label label5;
        private TextBox DailyCaloriesTB;
        private Label label6;
        private Button RemoveGoal;
    }
}