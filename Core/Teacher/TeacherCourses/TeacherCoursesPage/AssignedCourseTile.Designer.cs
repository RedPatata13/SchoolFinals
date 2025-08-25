namespace Finals.Core.Teacher.TeacherCoursesPage
{
    partial class AssignedCourseTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            _statusLabel = new Label();
            _schedule = new Label();
            _courseName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(_statusLabel);
            panel1.Controls.Add(_schedule);
            panel1.Controls.Add(_courseName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 246);
            panel1.TabIndex = 0;
            // 
            // _statusLabel
            // 
            _statusLabel.AutoSize = true;
            _statusLabel.Location = new Point(16, 224);
            _statusLabel.Name = "_statusLabel";
            _statusLabel.Size = new Size(54, 15);
            _statusLabel.TabIndex = 4;
            _statusLabel.Text = "Ongoing";
            // 
            // _schedule
            // 
            _schedule.AutoSize = true;
            _schedule.Location = new Point(8, 40);
            _schedule.Name = "_schedule";
            _schedule.Size = new Size(117, 15);
            _schedule.TabIndex = 3;
            _schedule.Text = "Sunday, 14:00 - 17:00";
            // 
            // _courseName
            // 
            _courseName.AutoSize = true;
            _courseName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _courseName.Location = new Point(8, 8);
            _courseName.Name = "_courseName";
            _courseName.Size = new Size(252, 30);
            _courseName.TabIndex = 2;
            _courseName.Text = "Information Management";
            // 
            // AssignedCourseTile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(panel1);
            Name = "AssignedCourseTile";
            Padding = new Padding(2);
            Size = new Size(300, 250);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label _statusLabel;
        private Label _schedule;
        private Label _courseName;
    }
}
