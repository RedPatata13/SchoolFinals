namespace Finals.Core.Admin.AdminYearManagement.UserControls
{
    partial class StartSchoolYearDraftDialog
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
            panel1 = new Panel();
            SecondaryActiomButton = new Button();
            MainActionButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(SecondaryActiomButton);
            panel1.Controls.Add(MainActionButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 568);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 49);
            panel1.TabIndex = 10;
            // 
            // SecondaryActiomButton
            // 
            SecondaryActiomButton.BackColor = SystemColors.ControlLight;
            SecondaryActiomButton.FlatStyle = FlatStyle.Flat;
            SecondaryActiomButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecondaryActiomButton.ForeColor = SystemColors.ControlText;
            SecondaryActiomButton.Location = new Point(952, 8);
            SecondaryActiomButton.Name = "SecondaryActiomButton";
            SecondaryActiomButton.Size = new Size(85, 37);
            SecondaryActiomButton.TabIndex = 5;
            SecondaryActiomButton.Text = "Cancel";
            SecondaryActiomButton.UseVisualStyleBackColor = false;
            SecondaryActiomButton.Click += SecondaryActiomButton_Click;
            // 
            // MainActionButton
            // 
            MainActionButton.BackColor = SystemColors.Highlight;
            MainActionButton.FlatStyle = FlatStyle.Flat;
            MainActionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainActionButton.ForeColor = SystemColors.HighlightText;
            MainActionButton.Location = new Point(1040, 8);
            MainActionButton.Name = "MainActionButton";
            MainActionButton.Size = new Size(85, 37);
            MainActionButton.TabIndex = 4;
            MainActionButton.Text = "Confirm";
            MainActionButton.UseVisualStyleBackColor = false;
            MainActionButton.Click += MainActionButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(48, 152);
            label6.Name = "label6";
            label6.Size = new Size(389, 21);
            label6.TabIndex = 16;
            label6.Text = "would reflect to the School Year once it becomes active";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(40, 128);
            label5.Name = "label5";
            label5.Size = new Size(840, 24);
            label5.TabIndex = 15;
            label5.Text = "- The new school year would follow existing Program and Course settings and in this period, \\n any changes to them";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(40, 84);
            label4.Name = "label4";
            label4.Size = new Size(266, 21);
            label4.TabIndex = 14;
            label4.Text = "- Immediately start School Year draft.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(40, 104);
            label3.Name = "label3";
            label3.Size = new Size(849, 21);
            label3.TabIndex = 13;
            label3.Text = "- The newly created draft would not be shown to Students and Teachers. Nor would they be able to enroll or register for it.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 60);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 12;
            label2.Text = "This action would:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 4);
            label1.Name = "label1";
            label1.Size = new Size(722, 45);
            label1.TabIndex = 11;
            label1.Text = "Are you sure you wish to start a new School Year?";
            // 
            // StartSchoolYearDraftDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 617);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StartSchoolYearDraftDialog";
            Text = "Start new School Year";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}