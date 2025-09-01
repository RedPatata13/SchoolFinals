namespace Finals.Forms.UserControls
{
    partial class SemesterTemplateUC
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
            _header = new Panel();
            _termName = new Label();
            label1 = new Label();
            _termNameDetails = new Label();
            _editProgramName = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button5 = new Button();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            _extraTermsContainer = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            button2 = new Button();
            _extraSemestersLabel = new Label();
            button1 = new Button();
            _header.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            _extraTermsContainer.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // _header
            // 
            _header.Controls.Add(_termName);
            _header.Dock = DockStyle.Top;
            _header.Location = new Point(0, 0);
            _header.Name = "_header";
            _header.Size = new Size(906, 48);
            _header.TabIndex = 0;
            // 
            // _termName
            // 
            _termName.AutoSize = true;
            _termName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _termName.Location = new Point(8, 8);
            _termName.Name = "_termName";
            _termName.Size = new Size(319, 30);
            _termName.TabIndex = 1;
            _termName.Text = "[Semester's Name] Configuration";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 1;
            label1.Text = "Term Name";
            // 
            // _termNameDetails
            // 
            _termNameDetails.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            _termNameDetails.AutoSize = true;
            _termNameDetails.Font = new Font("Segoe UI", 12F);
            _termNameDetails.Location = new Point(174, 10);
            _termNameDetails.Name = "_termNameDetails";
            _termNameDetails.Size = new Size(623, 21);
            _termNameDetails.TabIndex = 16;
            _termNameDetails.Text = "_termName";
            // 
            // _editProgramName
            // 
            _editProgramName.Anchor = AnchorStyles.Left;
            _editProgramName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _editProgramName.BackColor = SystemColors.WindowFrame;
            _editProgramName.FlatAppearance.BorderColor = Color.Black;
            _editProgramName.FlatStyle = FlatStyle.Flat;
            _editProgramName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _editProgramName.ForeColor = Color.White;
            _editProgramName.Location = new Point(804, 9);
            _editProgramName.Name = "_editProgramName";
            _editProgramName.Size = new Size(85, 24);
            _editProgramName.TabIndex = 25;
            _editProgramName.Text = "Edit";
            _editProgramName.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.Controls.Add(_editProgramName, 2, 0);
            tableLayoutPanel1.Controls.Add(_termNameDetails, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(16, 0, 8, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(906, 80);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.FromArgb(229, 57, 73);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(804, 48);
            button5.Name = "button5";
            button5.Size = new Size(85, 24);
            button5.TabIndex = 31;
            button5.Text = "Remove";
            button5.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 50);
            label6.Name = "label6";
            label6.Size = new Size(133, 21);
            label6.TabIndex = 30;
            label6.Text = "Remove this term";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 230);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(_extraTermsContainer);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16, 0, 8, 8);
            panel2.Size = new Size(906, 182);
            panel2.TabIndex = 8;
            // 
            // _extraTermsContainer
            // 
            _extraTermsContainer.BackColor = SystemColors.ControlDark;
            _extraTermsContainer.BorderStyle = BorderStyle.FixedSingle;
            _extraTermsContainer.Controls.Add(tabControl1);
            _extraTermsContainer.Dock = DockStyle.Fill;
            _extraTermsContainer.Location = new Point(16, 0);
            _extraTermsContainer.MaximumSize = new Size(0, 182);
            _extraTermsContainer.Name = "_extraTermsContainer";
            _extraTermsContainer.Padding = new Padding(8);
            _extraTermsContainer.Size = new Size(882, 174);
            _extraTermsContainer.TabIndex = 7;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(8, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(864, 156);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Controls.Add(panel4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(856, 128);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Summer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 197F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel2.Controls.Add(button4, 2, 1);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 51);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(16, 0, 0, 0);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(850, 77);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.FromArgb(229, 57, 73);
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(756, 47);
            button4.Name = "button4";
            button4.Size = new Size(85, 24);
            button4.TabIndex = 28;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = SystemColors.WindowFrame;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(756, 9);
            button3.Name = "button3";
            button3.Size = new Size(85, 24);
            button3.TabIndex = 25;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(218, 10);
            label2.Name = "label2";
            label2.Size = new Size(531, 21);
            label2.TabIndex = 16;
            label2.Text = "Semester Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 10);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 1;
            label3.Text = "Semester Name:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 48);
            label5.Name = "label5";
            label5.Size = new Size(174, 21);
            label5.TabIndex = 29;
            label5.Text = "Remove this Extra term.";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(850, 48);
            panel4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 8);
            label4.Name = "label4";
            label4.Size = new Size(319, 30);
            label4.TabIndex = 1;
            label4.Text = "[Semester's Name] Configuration";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(16, 8, 8, 0);
            panel3.Size = new Size(906, 48);
            panel3.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(button2);
            panel5.Controls.Add(_extraSemestersLabel);
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(16, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(882, 40);
            panel5.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.FromArgb(229, 57, 73);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(786, 8);
            button2.Name = "button2";
            button2.Size = new Size(85, 24);
            button2.TabIndex = 30;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = false;
            // 
            // _extraSemestersLabel
            // 
            _extraSemestersLabel.AutoSize = true;
            _extraSemestersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _extraSemestersLabel.Location = new Point(8, 8);
            _extraSemestersLabel.Name = "_extraSemestersLabel";
            _extraSemestersLabel.Size = new Size(120, 21);
            _extraSemestersLabel.TabIndex = 28;
            _extraSemestersLabel.Text = "Extra Semesters";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(696, 8);
            button1.Name = "button1";
            button1.Size = new Size(85, 24);
            button1.TabIndex = 29;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // SemesterTemplateUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(_header);
            MinimumSize = new Size(0, 321);
            Name = "SemesterTemplateUC";
            Size = new Size(906, 358);
            _header.ResumeLayout(false);
            _header.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            _extraTermsContainer.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel _header;
        private Label _termName;
        private Label label1;
        private Label _termNameDetails;
        private Button _editProgramName;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Button button5;
        private Panel panel1;
        private Panel panel2;
        private Panel _extraTermsContainer;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Panel panel5;
        private Button button2;
        private Label _extraSemestersLabel;
        private Button button1;
    }
}
