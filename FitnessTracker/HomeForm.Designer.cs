namespace FitnessTracker
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            panel1 = new Panel();
            ToELB = new Label();
            DaySelector = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(ToELB);
            panel1.Location = new Point(12, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 200);
            panel1.TabIndex = 0;
            // 
            // ToELB
            // 
            ToELB.AutoSize = true;
            ToELB.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ToELB.Location = new Point(53, 23);
            ToELB.Name = "ToELB";
            ToELB.Size = new Size(108, 17);
            ToELB.TabIndex = 2;
            ToELB.Text = "Types of exercies";
            // 
            // DaySelector
            // 
            DaySelector.BackColor = SystemColors.Info;
            DaySelector.FlatStyle = FlatStyle.Flat;
            DaySelector.ForeColor = SystemColors.ScrollBar;
            DaySelector.FormattingEnabled = true;
            DaySelector.Items.AddRange(new object[] { "14", "7", "3" });
            DaySelector.Location = new Point(190, 331);
            DaySelector.Name = "DaySelector";
            DaySelector.Size = new Size(56, 23);
            DaySelector.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 332);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 0;
            label1.Text = "Performance in the last ";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 568);
            Controls.Add(panel1);
            Controls.Add(DaySelector);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Panel panel1;
        private Label label1;
        private ComboBox DaySelector;
        private Label ToELB;
    }
}