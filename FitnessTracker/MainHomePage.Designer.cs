namespace FitnessTracker
{
    partial class MainHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHomePage));
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            HomeBTN = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            AddActivityBTN = new Button();
            panel4 = new Panel();
            MyProfileBTN = new Button();
            panel5 = new Panel();
            AboutBTN = new Button();
            MainPanel = new Panel();
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.DimGray;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel2);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel5);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(246, 607);
            Sidebar.MinimumSize = new Size(79, 607);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(79, 607);
            Sidebar.TabIndex = 0;
            Sidebar.Paint += Sidebar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(HomeBTN);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(75, 74);
            panel1.TabIndex = 1;
            // 
            // HomeBTN
            // 
            HomeBTN.BackgroundImageLayout = ImageLayout.None;
            HomeBTN.FlatStyle = FlatStyle.Flat;
            HomeBTN.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            HomeBTN.ForeColor = Color.White;
            HomeBTN.Image = Properties.Resources.rrrrrrrrrrrrrrrrr;
            HomeBTN.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBTN.Location = new Point(-9, -10);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Padding = new Padding(15, 0, 0, 0);
            HomeBTN.Size = new Size(108, 99);
            HomeBTN.TabIndex = 2;
            HomeBTN.TextAlign = ContentAlignment.MiddleLeft;
            HomeBTN.UseVisualStyleBackColor = true;
            HomeBTN.Click += HomeBTN_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Location = new Point(3, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(72, 20);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(AddActivityBTN);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 64);
            panel3.TabIndex = 3;
            // 
            // AddActivityBTN
            // 
            AddActivityBTN.BackgroundImageLayout = ImageLayout.None;
            AddActivityBTN.FlatStyle = FlatStyle.Flat;
            AddActivityBTN.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddActivityBTN.ForeColor = Color.White;
            AddActivityBTN.Image = (Image)resources.GetObject("AddActivityBTN.Image");
            AddActivityBTN.ImageAlign = ContentAlignment.MiddleLeft;
            AddActivityBTN.Location = new Point(-3, -3);
            AddActivityBTN.Name = "AddActivityBTN";
            AddActivityBTN.Padding = new Padding(15, 0, 0, 0);
            AddActivityBTN.Size = new Size(243, 73);
            AddActivityBTN.TabIndex = 2;
            AddActivityBTN.Text = "              Add Activity";
            AddActivityBTN.TextAlign = ContentAlignment.MiddleLeft;
            AddActivityBTN.UseVisualStyleBackColor = true;
            AddActivityBTN.Click += AddActivityBTN_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(MyProfileBTN);
            panel4.Location = new Point(3, 179);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 64);
            panel4.TabIndex = 3;
            // 
            // MyProfileBTN
            // 
            MyProfileBTN.BackgroundImageLayout = ImageLayout.None;
            MyProfileBTN.FlatStyle = FlatStyle.Flat;
            MyProfileBTN.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MyProfileBTN.ForeColor = Color.White;
            MyProfileBTN.Image = (Image)resources.GetObject("MyProfileBTN.Image");
            MyProfileBTN.ImageAlign = ContentAlignment.MiddleLeft;
            MyProfileBTN.Location = new Point(-3, -14);
            MyProfileBTN.Name = "MyProfileBTN";
            MyProfileBTN.Padding = new Padding(15, 0, 0, 0);
            MyProfileBTN.Size = new Size(243, 81);
            MyProfileBTN.TabIndex = 2;
            MyProfileBTN.Text = "              My Profile";
            MyProfileBTN.TextAlign = ContentAlignment.MiddleLeft;
            MyProfileBTN.UseVisualStyleBackColor = true;
            MyProfileBTN.Click += MyProfileBTN_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(AboutBTN);
            panel5.Location = new Point(3, 249);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 64);
            panel5.TabIndex = 3;
            // 
            // AboutBTN
            // 
            AboutBTN.BackgroundImageLayout = ImageLayout.None;
            AboutBTN.FlatStyle = FlatStyle.Flat;
            AboutBTN.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AboutBTN.ForeColor = Color.White;
            AboutBTN.Image = (Image)resources.GetObject("AboutBTN.Image");
            AboutBTN.ImageAlign = ContentAlignment.MiddleLeft;
            AboutBTN.Location = new Point(-3, -6);
            AboutBTN.Name = "AboutBTN";
            AboutBTN.Padding = new Padding(15, 0, 0, 0);
            AboutBTN.Size = new Size(243, 78);
            AboutBTN.TabIndex = 2;
            AboutBTN.Text = "              About";
            AboutBTN.TextAlign = ContentAlignment.MiddleLeft;
            AboutBTN.UseVisualStyleBackColor = true;
            AboutBTN.Click += AboutBTN_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Right;
            MainPanel.Location = new Point(84, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(910, 607);
            MainPanel.TabIndex = 1;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // MainHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 607);
            Controls.Add(MainPanel);
            Controls.Add(Sidebar);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainHomePage_Load;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel2;
        private Button HomeBTN;
        private Panel panel3;
        private Button AddActivityBTN;
        private Panel panel4;
        private Button MyProfileBTN;
        private Panel panel5;
        private Button AboutBTN;
        private Panel MainPanel;
        private Panel panel1;
    }
}