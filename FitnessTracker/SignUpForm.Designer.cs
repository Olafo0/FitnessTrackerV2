namespace FitnessTracker
{
    partial class SignUpForm
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
            label1 = new Label();
            CreateAccountBTN = new Button();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            PasswordTB = new TextBox();
            groupBox2 = new GroupBox();
            WarningLabel1 = new Label();
            UsernameTB = new TextBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            birthdatePicker = new DateTimePicker();
            genderCB = new ComboBox();
            LastNameTB = new TextBox();
            FirstNameTB = new TextBox();
            WarningLabel = new Label();
            EmailTB = new TextBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Sign up!";
            // 
            // CreateAccountBTN
            // 
            CreateAccountBTN.Cursor = Cursors.Hand;
            CreateAccountBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreateAccountBTN.Location = new Point(320, 458);
            CreateAccountBTN.Name = "CreateAccountBTN";
            CreateAccountBTN.Size = new Size(152, 23);
            CreateAccountBTN.TabIndex = 1;
            CreateAccountBTN.Text = "Create Account";
            CreateAccountBTN.UseVisualStyleBackColor = true;
            CreateAccountBTN.Click += CreateAccountBTN_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(PasswordTB);
            groupBox1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 330);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 122);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 97);
            label9.Name = "label9";
            label9.Size = new Size(161, 15);
            label9.TabIndex = 5;
            label9.Text = "- Be at least 8 characters long";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 82);
            label8.Name = "label8";
            label8.Size = new Size(163, 15);
            label8.TabIndex = 4;
            label8.Text = "- Contain at least one number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 67);
            label7.Name = "label7";
            label7.Size = new Size(207, 15);
            label7.TabIndex = 3;
            label7.Text = "- Contain at least one specal character";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 52);
            label6.Name = "label6";
            label6.Size = new Size(261, 15);
            label6.TabIndex = 2;
            label6.Text = "- Contain at least one Upper and lower character";
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(136, 22);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(176, 23);
            PasswordTB.TabIndex = 1;
            PasswordTB.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(WarningLabel1);
            groupBox2.Controls.Add(UsernameTB);
            groupBox2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 95);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Make a username";
            // 
            // WarningLabel1
            // 
            WarningLabel1.AutoSize = true;
            WarningLabel1.ForeColor = Color.Red;
            WarningLabel1.Location = new Point(137, 57);
            WarningLabel1.Name = "WarningLabel1";
            WarningLabel1.Size = new Size(174, 15);
            WarningLabel1.TabIndex = 1;
            WarningLabel1.Text = "* This username is already taken";
            WarningLabel1.Visible = false;
            // 
            // UsernameTB
            // 
            UsernameTB.Location = new Point(157, 22);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(140, 23);
            UsernameTB.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(EmailTB);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(birthdatePicker);
            groupBox3.Controls.Add(genderCB);
            groupBox3.Controls.Add(LastNameTB);
            groupBox3.Controls.Add(FirstNameTB);
            groupBox3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(460, 178);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(206, 41);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 7;
            label5.Text = "Birth Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 125);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Gender :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 79);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Last Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 41);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "First Name :";
            // 
            // birthdatePicker
            // 
            birthdatePicker.Location = new Point(277, 38);
            birthdatePicker.Name = "birthdatePicker";
            birthdatePicker.Size = new Size(129, 23);
            birthdatePicker.TabIndex = 3;
            // 
            // genderCB
            // 
            genderCB.DropDownStyle = ComboBoxStyle.DropDownList;
            genderCB.FormattingEnabled = true;
            genderCB.Items.AddRange(new object[] { "Male", "Female" });
            genderCB.Location = new Point(89, 122);
            genderCB.Name = "genderCB";
            genderCB.Size = new Size(100, 23);
            genderCB.TabIndex = 2;
            // 
            // LastNameTB
            // 
            LastNameTB.Location = new Point(89, 76);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.Size = new Size(100, 23);
            LastNameTB.TabIndex = 1;
            // 
            // FirstNameTB
            // 
            FirstNameTB.Location = new Point(89, 38);
            FirstNameTB.Name = "FirstNameTB";
            FirstNameTB.Size = new Size(100, 23);
            FirstNameTB.TabIndex = 0;
            // 
            // WarningLabel
            // 
            WarningLabel.AutoSize = true;
            WarningLabel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WarningLabel.ForeColor = Color.Red;
            WarningLabel.Location = new Point(89, 462);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(170, 15);
            WarningLabel.TabIndex = 5;
            WarningLabel.Text = "* One or more fields are empty!";
            WarningLabel.Visible = false;
            // 
            // EmailTB
            // 
            EmailTB.Location = new Point(277, 71);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(100, 23);
            EmailTB.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(229, 76);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 9;
            label10.Text = "Email :";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 508);
            Controls.Add(WarningLabel);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(CreateAccountBTN);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CreateAccountBTN;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker birthdatePicker;
        private ComboBox genderCB;
        private TextBox LastNameTB;
        private TextBox FirstNameTB;
        private TextBox PasswordTB;
        private TextBox UsernameTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label WarningLabel;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label WarningLabel1;
        private Label label10;
        private TextBox EmailTB;
    }
}