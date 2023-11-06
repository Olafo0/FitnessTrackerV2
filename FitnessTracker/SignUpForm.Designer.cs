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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            genderCB = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Sign up!";
            // 
            // CreateAccountBTN
            // 
            CreateAccountBTN.Cursor = Cursors.Hand;
            CreateAccountBTN.Location = new Point(166, 452);
            CreateAccountBTN.Name = "CreateAccountBTN";
            CreateAccountBTN.Size = new Size(152, 23);
            CreateAccountBTN.TabIndex = 1;
            CreateAccountBTN.Text = "Create Account";
            CreateAccountBTN.UseVisualStyleBackColor = true;
            CreateAccountBTN.Click += CreateAccountBTN_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(12, 330);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 88);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Password";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(12, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 95);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Make a username";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(genderCB);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(12, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(460, 178);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Details";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(277, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(129, 23);
            dateTimePicker1.TabIndex = 3;
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
            // textBox2
            // 
            textBox2.Location = new Point(89, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(175, 36);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 41);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 79);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Last Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 125);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 41);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 7;
            label5.Text = "Birth Date :";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 508);
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
        private DateTimePicker dateTimePicker1;
        private ComboBox genderCB;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}