namespace Finals.Core.Admin.AdminYearManagement.UserControls
{
    partial class SchoolYearPhaseUserControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            SY_Name = new Label();
            SY_Status = new Label();
            panel1 = new Panel();
            SecondaryActiomButton = new Button();
            MainActionButton = new Button();
            SY_ID = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.7571259F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.2428713F));
            tableLayoutPanel1.Controls.Add(SY_Name, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 3);
            tableLayoutPanel1.Controls.Add(SY_ID, 0, 1);
            tableLayoutPanel1.Controls.Add(SY_Status, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(945, 424);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SY_Name
            // 
            SY_Name.Anchor = AnchorStyles.Left;
            SY_Name.AutoSize = true;
            SY_Name.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SY_Name.ForeColor = SystemColors.ControlText;
            SY_Name.Location = new Point(3, 2);
            SY_Name.Name = "SY_Name";
            SY_Name.Size = new Size(256, 50);
            SY_Name.TabIndex = 0;
            SY_Name.Text = "SY 2025-2026";
            // 
            // SY_Status
            // 
            SY_Status.Anchor = AnchorStyles.Left;
            SY_Status.AutoSize = true;
            SY_Status.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SY_Status.ForeColor = SystemColors.ControlText;
            SY_Status.Location = new Point(3, 91);
            SY_Status.Name = "SY_Status";
            SY_Status.Size = new Size(78, 30);
            SY_Status.TabIndex = 1;
            SY_Status.Text = "Locked";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(SecondaryActiomButton);
            panel1.Controls.Add(MainActionButton);
            panel1.Location = new Point(3, 382);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 39);
            panel1.TabIndex = 4;
            // 
            // SecondaryActiomButton
            // 
            SecondaryActiomButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SecondaryActiomButton.BackColor = SystemColors.ControlLight;
            SecondaryActiomButton.FlatStyle = FlatStyle.Flat;
            SecondaryActiomButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecondaryActiomButton.ForeColor = SystemColors.ControlText;
            SecondaryActiomButton.Location = new Point(88, 0);
            SecondaryActiomButton.Name = "SecondaryActiomButton";
            SecondaryActiomButton.Size = new Size(85, 37);
            SecondaryActiomButton.TabIndex = 3;
            SecondaryActiomButton.Text = "Conclude";
            SecondaryActiomButton.UseVisualStyleBackColor = false;
            // 
            // MainActionButton
            // 
            MainActionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MainActionButton.BackColor = SystemColors.Highlight;
            MainActionButton.FlatStyle = FlatStyle.Flat;
            MainActionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainActionButton.ForeColor = SystemColors.HighlightText;
            MainActionButton.Location = new Point(0, 0);
            MainActionButton.Name = "MainActionButton";
            MainActionButton.Size = new Size(85, 37);
            MainActionButton.TabIndex = 2;
            MainActionButton.Text = "Restore";
            MainActionButton.UseVisualStyleBackColor = false;
            // 
            // SY_ID
            // 
            SY_ID.Anchor = AnchorStyles.Left;
            SY_ID.AutoSize = true;
            SY_ID.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SY_ID.ForeColor = SystemColors.ControlText;
            SY_ID.Location = new Point(3, 55);
            SY_ID.Name = "SY_ID";
            SY_ID.Size = new Size(78, 30);
            SY_ID.TabIndex = 5;
            SY_ID.Text = "Locked";
            // 
            // SchoolYearPhaseUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Name = "SchoolYearPhaseUserControl";
            Padding = new Padding(20, 12, 20, 12);
            Size = new Size(985, 448);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label SY_Name;
        private Label SY_Status;
        private Button MainActionButton;
        private Panel panel1;
        private Button SecondaryActiomButton;
        private Label SY_ID;
    }
}
