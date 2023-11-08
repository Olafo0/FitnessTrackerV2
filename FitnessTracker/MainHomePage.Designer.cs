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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHomePage));
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBTN = new PictureBox();
            panel2 = new Panel();
            HomeBTN = new Button();
            panel3 = new Panel();
            AddActivityBTN = new Button();
            panel4 = new Panel();
            MyProfileBTN = new Button();
            panel5 = new Panel();
            AboutBTN = new Button();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBTN).BeginInit();
            panel2.SuspendLayout();
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
            Sidebar.Size = new Size(246, 607);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuBTN);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 103);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // MenuBTN
            // 
            MenuBTN.Cursor = Cursors.Hand;
            MenuBTN.Image = (Image)resources.GetObject("MenuBTN.Image");
            MenuBTN.Location = new Point(23, 34);
            MenuBTN.Name = "MenuBTN";
            MenuBTN.Size = new Size(34, 32);
            MenuBTN.TabIndex = 0;
            MenuBTN.TabStop = false;
            MenuBTN.Click += MenuBTN_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(HomeBTN);
            panel2.Location = new Point(3, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 64);
            panel2.TabIndex = 2;
            // 
            // HomeBTN
            // 
            HomeBTN.BackgroundImageLayout = ImageLayout.None;
            HomeBTN.FlatStyle = FlatStyle.Flat;
            HomeBTN.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            HomeBTN.ForeColor = Color.White;
            HomeBTN.Image = Properties.Resources.rrrrrrrrrrrrrrrrr;
            HomeBTN.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBTN.Location = new Point(3, 3);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Padding = new Padding(15, 0, 0, 0);
            HomeBTN.Size = new Size(237, 58);
            HomeBTN.TabIndex = 2;
            HomeBTN.Text = "              Home";
            HomeBTN.TextAlign = ContentAlignment.MiddleLeft;
            HomeBTN.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(AddActivityBTN);
            panel3.Location = new Point(3, 182);
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
            AddActivityBTN.Location = new Point(3, 3);
            AddActivityBTN.Name = "AddActivityBTN";
            AddActivityBTN.Padding = new Padding(15, 0, 0, 0);
            AddActivityBTN.Size = new Size(237, 58);
            AddActivityBTN.TabIndex = 2;
            AddActivityBTN.Text = "              Add Activity";
            AddActivityBTN.TextAlign = ContentAlignment.MiddleLeft;
            AddActivityBTN.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(MyProfileBTN);
            panel4.Location = new Point(3, 252);
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
            MyProfileBTN.Location = new Point(3, 3);
            MyProfileBTN.Name = "MyProfileBTN";
            MyProfileBTN.Padding = new Padding(15, 0, 0, 0);
            MyProfileBTN.Size = new Size(237, 58);
            MyProfileBTN.TabIndex = 2;
            MyProfileBTN.Text = "              My Profile";
            MyProfileBTN.TextAlign = ContentAlignment.MiddleLeft;
            MyProfileBTN.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(AboutBTN);
            panel5.Location = new Point(3, 322);
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
            AboutBTN.Location = new Point(3, 3);
            AboutBTN.Name = "AboutBTN";
            AboutBTN.Padding = new Padding(15, 0, 0, 0);
            AboutBTN.Size = new Size(237, 58);
            AboutBTN.TabIndex = 2;
            AboutBTN.Text = "              About";
            AboutBTN.TextAlign = ContentAlignment.MiddleLeft;
            AboutBTN.UseVisualStyleBackColor = true;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 5;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // MainHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 607);
            Controls.Add(Sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBTN).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button HomeBTN;
        private Panel panel3;
        private Button AddActivityBTN;
        private Panel panel4;
        private Button MyProfileBTN;
        private Panel panel5;
        private Button AboutBTN;
        private Label label1;
        private PictureBox MenuBTN;
        private System.Windows.Forms.Timer SidebarTimer;
    }
}