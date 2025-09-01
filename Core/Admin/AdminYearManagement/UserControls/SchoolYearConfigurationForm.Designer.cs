namespace Finals.Core.Admin.AdminYearManagement.UserControls
{
    partial class SchoolYearConfigurationForm
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
            panel6 = new Panel();
            SecondaryActiomButton = new Button();
            MainActionButton = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            _termsContainer = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(54, 69, 79);
            panel6.Controls.Add(SecondaryActiomButton);
            panel6.Controls.Add(MainActionButton);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 812);
            panel6.Name = "panel6";
            panel6.Size = new Size(1242, 49);
            panel6.TabIndex = 35;
            // 
            // SecondaryActiomButton
            // 
            SecondaryActiomButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SecondaryActiomButton.BackColor = SystemColors.ControlLight;
            SecondaryActiomButton.FlatStyle = FlatStyle.Flat;
            SecondaryActiomButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecondaryActiomButton.ForeColor = SystemColors.ControlText;
            SecondaryActiomButton.Location = new Point(1064, 8);
            SecondaryActiomButton.Name = "SecondaryActiomButton";
            SecondaryActiomButton.Size = new Size(85, 37);
            SecondaryActiomButton.TabIndex = 20;
            SecondaryActiomButton.Text = "Cancel";
            SecondaryActiomButton.UseVisualStyleBackColor = false;
            SecondaryActiomButton.Click += SecondaryActiomButton_Click;
            // 
            // MainActionButton
            // 
            MainActionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MainActionButton.BackColor = SystemColors.Menu;
            MainActionButton.Enabled = false;
            MainActionButton.FlatStyle = FlatStyle.Flat;
            MainActionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainActionButton.ForeColor = SystemColors.ScrollBar;
            MainActionButton.Location = new Point(1152, 8);
            MainActionButton.Name = "MainActionButton";
            MainActionButton.Size = new Size(85, 37);
            MainActionButton.TabIndex = 19;
            MainActionButton.Text = "Confirm";
            MainActionButton.UseVisualStyleBackColor = false;
            MainActionButton.Click += MainActionButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 36;
            label1.Text = "School Year Configuration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 34);
            label2.Name = "label2";
            label2.Size = new Size(887, 15);
            label2.TabIndex = 37;
            label2.Text = "- Note: This page is for updating how a newly created School Year would behave. Updating this configuration would not reflect the changes to any existing school year.";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 56);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1242, 232);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(_termsContainer);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 288);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(8);
            panel3.Size = new Size(1242, 524);
            panel3.TabIndex = 40;
            // 
            // _termsContainer
            // 
            _termsContainer.BackColor = SystemColors.ControlDark;
            _termsContainer.BorderStyle = BorderStyle.FixedSingle;
            _termsContainer.Dock = DockStyle.Fill;
            _termsContainer.Location = new Point(8, 64);
            _termsContainer.Name = "_termsContainer";
            _termsContainer.Padding = new Padding(8);
            _termsContainer.Size = new Size(1224, 450);
            _termsContainer.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(8, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(1224, 56);
            panel4.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 8);
            label4.Name = "label4";
            label4.Size = new Size(67, 30);
            label4.TabIndex = 36;
            label4.Text = "Terms";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 34);
            label5.Name = "label5";
            label5.Size = new Size(887, 15);
            label5.TabIndex = 37;
            label5.Text = "- Note: This page is for updating how a newly created School Year would behave. Updating this configuration would not reflect the changes to any existing school year.";
            // 
            // SchoolYearConfigurationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 861);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SchoolYearConfigurationForm";
            Text = "SchoolYearConfigurationForm";
            panel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel _termsContainer;
        private Panel panel4;
        private Label label4;
        private Label label5;
    }
}