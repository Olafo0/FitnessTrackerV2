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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            CurrentGoalsGP = new GroupBox();
            RemoveGoal = new Button();
            CaloriesDayLB = new Label();
            CaloriesWeekLB = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SetUpGoalGB = new GroupBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            WeeklyPanel = new Panel();
            WeeklyBTNSubmit = new Button();
            label4 = new Label();
            WeekCaloriesTB = new TextBox();
            DailyPanel = new Panel();
            DailyBTNSubmit = new Button();
            label5 = new Label();
            DailyCaloriesTB = new TextBox();
            WeekOrDayCB = new ComboBox();
            groupBox2 = new GroupBox();
            NewPasswordCurrentPanel = new Panel();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            CurrentPasswordTB = new TextBox();
            ChangePasswordTB = new TextBox();
            label12 = new Label();
            label7 = new Label();
            ChangePasswordBTN = new Button();
            label8 = new Label();
            IncPassLB = new Label();
            ForgotPassPanel = new Panel();
            ContinueBTN = new Button();
            EmailCodeTB = new TextBox();
            SendEmailCodeBTN = new Button();
            label17 = new Label();
            ChangePassEmailPanel = new Panel();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            NewPasswordTB2 = new TextBox();
            label16 = new Label();
            label18 = new Label();
            ChangePassBTN = new Button();
            label19 = new Label();
            ChangeCurPassBTN = new Button();
            ForgotPassBTN = new Button();
            groupBox3 = new GroupBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            pictureBox1 = new PictureBox();
            NameTB = new TextBox();
            LastNameTB = new TextBox();
            AgeTB = new TextBox();
            GenderTB = new TextBox();
            label24 = new Label();
            CaloriesBurnedTB = new TextBox();
            CurrentGoalsGP.SuspendLayout();
            SetUpGoalGB.SuspendLayout();
            WeeklyPanel.SuspendLayout();
            DailyPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            NewPasswordCurrentPanel.SuspendLayout();
            ForgotPassPanel.SuspendLayout();
            ChangePassEmailPanel.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            CurrentGoalsGP.Location = new Point(362, 334);
            CurrentGoalsGP.Name = "CurrentGoalsGP";
            CurrentGoalsGP.Size = new Size(233, 261);
            CurrentGoalsGP.TabIndex = 0;
            CurrentGoalsGP.TabStop = false;
            CurrentGoalsGP.Text = " Current Goals ";
            // 
            // RemoveGoal
            // 
            RemoveGoal.FlatStyle = FlatStyle.Flat;
            RemoveGoal.Location = new Point(16, 171);
            RemoveGoal.Name = "RemoveGoal";
            RemoveGoal.Size = new Size(107, 29);
            RemoveGoal.TabIndex = 5;
            RemoveGoal.Text = "Remove Goal";
            RemoveGoal.UseVisualStyleBackColor = true;
            RemoveGoal.Click += RemoveGoal_Click;
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
            SetUpGoalGB.Controls.Add(groupBox1);
            SetUpGoalGB.Controls.Add(WeeklyPanel);
            SetUpGoalGB.Controls.Add(DailyPanel);
            SetUpGoalGB.Controls.Add(WeekOrDayCB);
            SetUpGoalGB.Location = new Point(12, 334);
            SetUpGoalGB.Name = "SetUpGoalGB";
            SetUpGoalGB.Size = new Size(338, 260);
            SetUpGoalGB.TabIndex = 2;
            SetUpGoalGB.TabStop = false;
            SetUpGoalGB.Text = " Set up goal ";
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
            // groupBox1
            // 
            groupBox1.Location = new Point(6, 261);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(110, 316);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(NewPasswordCurrentPanel);
            groupBox2.Controls.Add(ForgotPassPanel);
            groupBox2.Controls.Add(ChangePassEmailPanel);
            groupBox2.Controls.Add(ChangeCurPassBTN);
            groupBox2.Controls.Add(ForgotPassBTN);
            groupBox2.Location = new Point(574, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 316);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = " Change password ";
            // 
            // NewPasswordCurrentPanel
            // 
            NewPasswordCurrentPanel.Controls.Add(label9);
            NewPasswordCurrentPanel.Controls.Add(label11);
            NewPasswordCurrentPanel.Controls.Add(label10);
            NewPasswordCurrentPanel.Controls.Add(CurrentPasswordTB);
            NewPasswordCurrentPanel.Controls.Add(ChangePasswordTB);
            NewPasswordCurrentPanel.Controls.Add(label12);
            NewPasswordCurrentPanel.Controls.Add(label7);
            NewPasswordCurrentPanel.Controls.Add(ChangePasswordBTN);
            NewPasswordCurrentPanel.Controls.Add(label8);
            NewPasswordCurrentPanel.Controls.Add(IncPassLB);
            NewPasswordCurrentPanel.Location = new Point(6, 54);
            NewPasswordCurrentPanel.Name = "NewPasswordCurrentPanel";
            NewPasswordCurrentPanel.Size = new Size(291, 256);
            NewPasswordCurrentPanel.TabIndex = 5;
            NewPasswordCurrentPanel.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 191);
            label9.Name = "label9";
            label9.Size = new Size(161, 15);
            label9.TabIndex = 9;
            label9.Text = "- Be at least 8 characters long";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 161);
            label11.Name = "label11";
            label11.Size = new Size(207, 15);
            label11.TabIndex = 7;
            label11.Text = "- Contain at least one specal character";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 176);
            label10.Name = "label10";
            label10.Size = new Size(163, 15);
            label10.TabIndex = 8;
            label10.Text = "- Contain at least one number";
            // 
            // CurrentPasswordTB
            // 
            CurrentPasswordTB.Location = new Point(94, 53);
            CurrentPasswordTB.Name = "CurrentPasswordTB";
            CurrentPasswordTB.Size = new Size(100, 23);
            CurrentPasswordTB.TabIndex = 0;
            // 
            // ChangePasswordTB
            // 
            ChangePasswordTB.Location = new Point(94, 118);
            ChangePasswordTB.Name = "ChangePasswordTB";
            ChangePasswordTB.Size = new Size(100, 23);
            ChangePasswordTB.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 146);
            label12.Name = "label12";
            label12.Size = new Size(261, 15);
            label12.TabIndex = 6;
            label12.Text = "- Contain at least one Upper and lower character";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, -22);
            label7.Name = "label7";
            label7.Size = new Size(204, 15);
            label7.TabIndex = 2;
            label7.Text = "Please enter in your current password";
            // 
            // ChangePasswordBTN
            // 
            ChangePasswordBTN.FlatStyle = FlatStyle.Popup;
            ChangePasswordBTN.Location = new Point(80, 219);
            ChangePasswordBTN.Name = "ChangePasswordBTN";
            ChangePasswordBTN.Size = new Size(126, 23);
            ChangePasswordBTN.TabIndex = 5;
            ChangePasswordBTN.Text = "Change password";
            ChangePasswordBTN.UseVisualStyleBackColor = true;
            ChangePasswordBTN.Click += ChangePasswordBTN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 100);
            label8.Name = "label8";
            label8.Size = new Size(134, 15);
            label8.TabIndex = 3;
            label8.Text = "Enter in a new password";
            // 
            // IncPassLB
            // 
            IncPassLB.AutoSize = true;
            IncPassLB.BackColor = Color.Transparent;
            IncPassLB.ForeColor = Color.DarkRed;
            IncPassLB.Location = new Point(72, 35);
            IncPassLB.Name = "IncPassLB";
            IncPassLB.Size = new Size(150, 15);
            IncPassLB.TabIndex = 4;
            IncPassLB.Text = "Incorrect password entered";
            IncPassLB.Visible = false;
            // 
            // ForgotPassPanel
            // 
            ForgotPassPanel.Controls.Add(ContinueBTN);
            ForgotPassPanel.Controls.Add(EmailCodeTB);
            ForgotPassPanel.Controls.Add(SendEmailCodeBTN);
            ForgotPassPanel.Controls.Add(label17);
            ForgotPassPanel.Location = new Point(302, 59);
            ForgotPassPanel.Name = "ForgotPassPanel";
            ForgotPassPanel.Size = new Size(291, 259);
            ForgotPassPanel.TabIndex = 10;
            // 
            // ContinueBTN
            // 
            ContinueBTN.Location = new Point(104, 171);
            ContinueBTN.Name = "ContinueBTN";
            ContinueBTN.Size = new Size(75, 23);
            ContinueBTN.TabIndex = 12;
            ContinueBTN.Text = "Continue";
            ContinueBTN.UseVisualStyleBackColor = true;
            ContinueBTN.Click += ContinueBTN_Click;
            // 
            // EmailCodeTB
            // 
            EmailCodeTB.Location = new Point(80, 115);
            EmailCodeTB.Name = "EmailCodeTB";
            EmailCodeTB.Size = new Size(126, 23);
            EmailCodeTB.TabIndex = 11;
            // 
            // SendEmailCodeBTN
            // 
            SendEmailCodeBTN.FlatStyle = FlatStyle.Popup;
            SendEmailCodeBTN.Location = new Point(80, 54);
            SendEmailCodeBTN.Name = "SendEmailCodeBTN";
            SendEmailCodeBTN.Size = new Size(126, 23);
            SendEmailCodeBTN.TabIndex = 10;
            SendEmailCodeBTN.Text = "Send email";
            SendEmailCodeBTN.UseVisualStyleBackColor = true;
            SendEmailCodeBTN.Click += SendEmailCodeBTN_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(28, -22);
            label17.Name = "label17";
            label17.Size = new Size(204, 15);
            label17.TabIndex = 2;
            label17.Text = "Please enter in your current password";
            // 
            // ChangePassEmailPanel
            // 
            ChangePassEmailPanel.Controls.Add(label13);
            ChangePassEmailPanel.Controls.Add(label14);
            ChangePassEmailPanel.Controls.Add(label15);
            ChangePassEmailPanel.Controls.Add(NewPasswordTB2);
            ChangePassEmailPanel.Controls.Add(label16);
            ChangePassEmailPanel.Controls.Add(label18);
            ChangePassEmailPanel.Controls.Add(ChangePassBTN);
            ChangePassEmailPanel.Controls.Add(label19);
            ChangePassEmailPanel.Location = new Point(299, 172);
            ChangePassEmailPanel.Name = "ChangePassEmailPanel";
            ChangePassEmailPanel.Size = new Size(291, 256);
            ChangePassEmailPanel.TabIndex = 10;
            ChangePassEmailPanel.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 141);
            label13.Name = "label13";
            label13.Size = new Size(161, 15);
            label13.TabIndex = 9;
            label13.Text = "- Be at least 8 characters long";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 111);
            label14.Name = "label14";
            label14.Size = new Size(207, 15);
            label14.TabIndex = 7;
            label14.Text = "- Contain at least one specal character";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 126);
            label15.Name = "label15";
            label15.Size = new Size(163, 15);
            label15.TabIndex = 8;
            label15.Text = "- Contain at least one number";
            // 
            // NewPasswordTB2
            // 
            NewPasswordTB2.Location = new Point(94, 68);
            NewPasswordTB2.Name = "NewPasswordTB2";
            NewPasswordTB2.Size = new Size(100, 23);
            NewPasswordTB2.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(29, 96);
            label16.Name = "label16";
            label16.Size = new Size(261, 15);
            label16.TabIndex = 6;
            label16.Text = "- Contain at least one Upper and lower character";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(28, -22);
            label18.Name = "label18";
            label18.Size = new Size(204, 15);
            label18.TabIndex = 2;
            label18.Text = "Please enter in your current password";
            // 
            // ChangePassBTN
            // 
            ChangePassBTN.FlatStyle = FlatStyle.Popup;
            ChangePassBTN.Location = new Point(78, 174);
            ChangePassBTN.Name = "ChangePassBTN";
            ChangePassBTN.Size = new Size(126, 23);
            ChangePassBTN.TabIndex = 5;
            ChangePassBTN.Text = "Change password";
            ChangePassBTN.UseVisualStyleBackColor = true;
            ChangePassBTN.Click += ChangePassBTN_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(78, 50);
            label19.Name = "label19";
            label19.Size = new Size(134, 15);
            label19.TabIndex = 3;
            label19.Text = "Enter in a new password";
            // 
            // ChangeCurPassBTN
            // 
            ChangeCurPassBTN.Cursor = Cursors.Hand;
            ChangeCurPassBTN.FlatStyle = FlatStyle.Flat;
            ChangeCurPassBTN.Location = new Point(157, 22);
            ChangeCurPassBTN.Name = "ChangeCurPassBTN";
            ChangeCurPassBTN.Size = new Size(161, 26);
            ChangeCurPassBTN.TabIndex = 1;
            ChangeCurPassBTN.Text = "Change Current Password";
            ChangeCurPassBTN.UseVisualStyleBackColor = true;
            ChangeCurPassBTN.Click += ChangeCurPassBTN_Click;
            // 
            // ForgotPassBTN
            // 
            ForgotPassBTN.Cursor = Cursors.Hand;
            ForgotPassBTN.FlatStyle = FlatStyle.Flat;
            ForgotPassBTN.Location = new Point(16, 22);
            ForgotPassBTN.Name = "ForgotPassBTN";
            ForgotPassBTN.Size = new Size(119, 26);
            ForgotPassBTN.TabIndex = 0;
            ForgotPassBTN.Text = "Forgot Password";
            ForgotPassBTN.UseVisualStyleBackColor = true;
            ForgotPassBTN.Click += ForgotPassBTN_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CaloriesBurnedTB);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(GenderTB);
            groupBox3.Controls.Add(AgeTB);
            groupBox3.Controls.Add(LastNameTB);
            groupBox3.Controls.Add(NameTB);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(556, 316);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = " My details ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(52, 136);
            label23.Name = "label23";
            label23.Size = new Size(51, 15);
            label23.TabIndex = 3;
            label23.Text = "Gender :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(69, 103);
            label22.Name = "label22";
            label22.Size = new Size(34, 15);
            label22.TabIndex = 2;
            label22.Text = "Age :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(35, 72);
            label21.Name = "label21";
            label21.Size = new Size(68, 15);
            label21.TabIndex = 1;
            label21.Text = "Last Name :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(59, 44);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 0;
            label20.Text = "Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(604, 343);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 251);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(109, 41);
            NameTB.Name = "NameTB";
            NameTB.ReadOnly = true;
            NameTB.Size = new Size(100, 23);
            NameTB.TabIndex = 4;
            // 
            // LastNameTB
            // 
            LastNameTB.Location = new Point(109, 70);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.ReadOnly = true;
            LastNameTB.Size = new Size(100, 23);
            LastNameTB.TabIndex = 5;
            // 
            // AgeTB
            // 
            AgeTB.Location = new Point(109, 100);
            AgeTB.Name = "AgeTB";
            AgeTB.ReadOnly = true;
            AgeTB.Size = new Size(100, 23);
            AgeTB.TabIndex = 6;
            // 
            // GenderTB
            // 
            GenderTB.Location = new Point(137, 133);
            GenderTB.Name = "GenderTB";
            GenderTB.ReadOnly = true;
            GenderTB.Size = new Size(43, 23);
            GenderTB.TabIndex = 7;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(248, 44);
            label24.Name = "label24";
            label24.Size = new Size(123, 15);
            label24.TabIndex = 8;
            label24.Text = "Total Calories Burned :";
            // 
            // CaloriesBurnedTB
            // 
            CaloriesBurnedTB.Location = new Point(378, 41);
            CaloriesBurnedTB.Name = "CaloriesBurnedTB";
            CaloriesBurnedTB.Size = new Size(100, 23);
            CaloriesBurnedTB.TabIndex = 9;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(910, 607);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
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
            groupBox2.ResumeLayout(false);
            NewPasswordCurrentPanel.ResumeLayout(false);
            NewPasswordCurrentPanel.PerformLayout();
            ForgotPassPanel.ResumeLayout(false);
            ForgotPassPanel.PerformLayout();
            ChangePassEmailPanel.ResumeLayout(false);
            ChangePassEmailPanel.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private TextBox ChangePasswordTB;
        private TextBox CurrentPasswordTB;
        private Button ChangePasswordBTN;
        private Label IncPassLB;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel NewPasswordCurrentPanel;
        private Button ChangeCurPassBTN;
        private Button ForgotPassBTN;
        private Panel ForgotPassPanel;
        private Label label17;
        private Button ContinueBTN;
        private TextBox EmailCodeTB;
        private Button SendEmailCodeBTN;
        private Panel ChangePassEmailPanel;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox NewPasswordTB2;
        private Label label16;
        private Label label18;
        private Button ChangePassBTN;
        private Label label19;
        private GroupBox groupBox3;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private PictureBox pictureBox1;
        private Label label24;
        private TextBox GenderTB;
        private TextBox AgeTB;
        private TextBox LastNameTB;
        private TextBox NameTB;
        private TextBox CaloriesBurnedTB;
    }
}