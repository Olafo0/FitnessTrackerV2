namespace FitnessTracker
{
    partial class LoginForm
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
            UsernameTXT = new TextBox();
            PasswordTXT = new TextBox();
            LoginBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // UsernameTXT
            // 
            UsernameTXT.Location = new Point(161, 203);
            UsernameTXT.Name = "UsernameTXT";
            UsernameTXT.Size = new Size(143, 23);
            UsernameTXT.TabIndex = 0;
            // 
            // PasswordTXT
            // 
            PasswordTXT.Location = new Point(161, 265);
            PasswordTXT.Name = "PasswordTXT";
            PasswordTXT.Size = new Size(143, 23);
            PasswordTXT.TabIndex = 1;
            // 
            // LoginBTN
            // 
            LoginBTN.Location = new Point(195, 319);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(75, 25);
            LoginBTN.TabIndex = 2;
            LoginBTN.Text = "Log In";
            LoginBTN.UseVisualStyleBackColor = true;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 185);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Username ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 247);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 508);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginBTN);
            Controls.Add(PasswordTXT);
            Controls.Add(UsernameTXT);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTXT;
        private TextBox PasswordTXT;
        private Button LoginBTN;
        private Label label1;
        private Label label2;
    }
}