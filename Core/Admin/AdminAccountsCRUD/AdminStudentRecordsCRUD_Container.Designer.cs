namespace Finals.Core.Admin.AdminAccountsCRUD
{
    partial class AdminStudentRecordsCRUD_Container
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
            _recordsButton = new Button();
            _gradesButton = new Button();
            _accountButton = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(_recordsButton);
            panel1.Controls.Add(_gradesButton);
            panel1.Controls.Add(_accountButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 40);
            panel1.TabIndex = 0;
            // 
            // _recordsButton
            // 
            _recordsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _recordsButton.BackColor = SystemColors.ControlLight;
            _recordsButton.FlatAppearance.BorderColor = Color.Black;
            _recordsButton.FlatStyle = FlatStyle.Flat;
            _recordsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _recordsButton.ForeColor = SystemColors.ControlText;
            _recordsButton.Location = new Point(176, 8);
            _recordsButton.Name = "_recordsButton";
            _recordsButton.Size = new Size(85, 24);
            _recordsButton.TabIndex = 34;
            _recordsButton.Text = "Records";
            _recordsButton.UseVisualStyleBackColor = false;
            // 
            // _gradesButton
            // 
            _gradesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _gradesButton.BackColor = SystemColors.Highlight;
            _gradesButton.FlatAppearance.BorderColor = Color.Black;
            _gradesButton.FlatStyle = FlatStyle.Flat;
            _gradesButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _gradesButton.ForeColor = Color.White;
            _gradesButton.Location = new Point(88, 8);
            _gradesButton.Name = "_gradesButton";
            _gradesButton.Size = new Size(85, 24);
            _gradesButton.TabIndex = 35;
            _gradesButton.Text = "Grades";
            _gradesButton.UseVisualStyleBackColor = false;
            // 
            // _accountButton
            // 
            _accountButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _accountButton.BackColor = Color.FromArgb(54, 69, 79);
            _accountButton.FlatAppearance.BorderColor = Color.Black;
            _accountButton.FlatStyle = FlatStyle.Flat;
            _accountButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _accountButton.ForeColor = Color.White;
            _accountButton.Location = new Point(0, 8);
            _accountButton.Name = "_accountButton";
            _accountButton.Size = new Size(85, 24);
            _accountButton.TabIndex = 36;
            _accountButton.Text = "Account";
            _accountButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8);
            panel2.Size = new Size(1059, 667);
            panel2.TabIndex = 1;
            // 
            // AdminStudentRecordsCRUD_Container
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminStudentRecordsCRUD_Container";
            Size = new Size(1059, 707);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button _gradesButton;
        private Button _accountButton;
        private Panel panel2;
        private Button _recordsButton;
    }
}
