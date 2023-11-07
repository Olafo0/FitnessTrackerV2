namespace FitnessTracker
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            MainPanel = new Panel();
            NavPanel = new Panel();
            SignInBTN = new Button();
            SignUp = new Button();
            NavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(484, 508);
            MainPanel.TabIndex = 0;
            // 
            // NavPanel
            // 
            NavPanel.BackColor = SystemColors.ButtonShadow;
            NavPanel.Controls.Add(SignInBTN);
            NavPanel.Controls.Add(SignUp);
            NavPanel.Dock = DockStyle.Bottom;
            NavPanel.ForeColor = SystemColors.ControlText;
            NavPanel.Location = new Point(0, 490);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(484, 86);
            NavPanel.TabIndex = 1;
            // 
            // SignInBTN
            // 
            SignInBTN.Location = new Point(49, 35);
            SignInBTN.Name = "SignInBTN";
            SignInBTN.Size = new Size(75, 23);
            SignInBTN.TabIndex = 2;
            SignInBTN.Text = "Sign in";
            SignInBTN.UseVisualStyleBackColor = true;
            SignInBTN.Click += SignInBTN_Click;
            // 
            // SignUp
            // 
            SignUp.Location = new Point(349, 35);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(75, 23);
            SignUp.TabIndex = 0;
            SignUp.Text = "Sign up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 576);
            Controls.Add(NavPanel);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginPage_Load;
            NavPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel NavPanel;
        private Button SignUp;
        private Button SignInBTN;
    }
}