namespace Finals.Forms
{
    partial class SelectSchoolYearDialog
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
            _syDGV = new DataGridView();
            SchoolYearName = new DataGridViewTextBoxColumn();
            SYId = new DataGridViewTextBoxColumn();
            DateStart = new DataGridViewTextBoxColumn();
            DateConcluded = new DataGridViewTextBoxColumn();
            DateArchived = new DataGridViewTextBoxColumn();
            SelectSY = new DataGridViewButtonColumn();
            _syDateConcluded = new Label();
            label13 = new Label();
            _syDateStart = new Label();
            label11 = new Label();
            _courseCount = new Label();
            _syId = new Label();
            label9 = new Label();
            _syName = new Label();
            label5 = new Label();
            label15 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            _dateArchive = new Label();
            _coursesContainer = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            _courseSelectedContainer = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            SecondaryActiomButton = new Button();
            MainActionButton = new Button();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)_syDGV).BeginInit();
            panel7.SuspendLayout();
            _coursesContainer.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            _courseSelectedContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // _syDGV
            // 
            _syDGV.AllowUserToAddRows = false;
            _syDGV.AllowUserToDeleteRows = false;
            _syDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _syDGV.Columns.AddRange(new DataGridViewColumn[] { SchoolYearName, SYId, DateStart, DateConcluded, DateArchived, SelectSY });
            _syDGV.Dock = DockStyle.Fill;
            _syDGV.Location = new Point(8, 32);
            _syDGV.Name = "_syDGV";
            _syDGV.ReadOnly = true;
            _syDGV.Size = new Size(787, 588);
            _syDGV.TabIndex = 1;
            _syDGV.CellContentClick += _syDGV_CellContentClick;
            // 
            // SchoolYearName
            // 
            SchoolYearName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SchoolYearName.HeaderText = "SY Name";
            SchoolYearName.Name = "SchoolYearName";
            SchoolYearName.ReadOnly = true;
            // 
            // SYId
            // 
            SYId.HeaderText = "SY ID";
            SYId.Name = "SYId";
            SYId.ReadOnly = true;
            // 
            // DateStart
            // 
            DateStart.HeaderText = "DateStarted";
            DateStart.Name = "DateStart";
            DateStart.ReadOnly = true;
            // 
            // DateConcluded
            // 
            DateConcluded.HeaderText = "Date Concluded";
            DateConcluded.Name = "DateConcluded";
            DateConcluded.ReadOnly = true;
            // 
            // DateArchived
            // 
            DateArchived.HeaderText = "Date Archived";
            DateArchived.Name = "DateArchived";
            DateArchived.ReadOnly = true;
            // 
            // SelectSY
            // 
            SelectSY.HeaderText = "Select School Year";
            SelectSY.Name = "SelectSY";
            SelectSY.ReadOnly = true;
            // 
            // _syDateConcluded
            // 
            _syDateConcluded.AutoSize = true;
            _syDateConcluded.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _syDateConcluded.Location = new Point(141, 94);
            _syDateConcluded.Name = "_syDateConcluded";
            _syDateConcluded.Size = new Size(38, 21);
            _syDateConcluded.TabIndex = 14;
            _syDateConcluded.Text = "N/A";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 94);
            label13.Name = "label13";
            label13.Size = new Size(120, 21);
            label13.TabIndex = 13;
            label13.Text = "Date Concluded";
            // 
            // _syDateStart
            // 
            _syDateStart.AutoSize = true;
            _syDateStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _syDateStart.Location = new Point(141, 66);
            _syDateStart.Name = "_syDateStart";
            _syDateStart.Size = new Size(38, 21);
            _syDateStart.TabIndex = 12;
            _syDateStart.Text = "N/A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 66);
            label11.Name = "label11";
            label11.Size = new Size(98, 21);
            label11.TabIndex = 11;
            label11.Text = "Date Started:";
            // 
            // _courseCount
            // 
            _courseCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _courseCount.AutoSize = true;
            _courseCount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _courseCount.Location = new Point(595, 20);
            _courseCount.Name = "_courseCount";
            _courseCount.Size = new Size(13, 13);
            _courseCount.TabIndex = 1;
            _courseCount.Text = "0";
            // 
            // _syId
            // 
            _syId.AutoSize = true;
            _syId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _syId.Location = new Point(141, 38);
            _syId.Name = "_syId";
            _syId.Size = new Size(38, 21);
            _syId.TabIndex = 10;
            _syId.Text = "N/A";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 38);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 9;
            label9.Text = "SY ID:";
            // 
            // _syName
            // 
            _syName.AutoSize = true;
            _syName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _syName.Location = new Point(141, 10);
            _syName.Name = "_syName";
            _syName.Size = new Size(38, 21);
            _syName.TabIndex = 8;
            _syName.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 5;
            label5.Text = "SY Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 122);
            label15.Name = "label15";
            label15.Size = new Size(110, 21);
            label15.TabIndex = 15;
            label15.Text = "Date Archived:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(-955, 20);
            label3.Name = "label3";
            label3.Size = new Size(53, 13);
            label3.TabIndex = 0;
            label3.Text = "Teachers:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(button1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(4, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(803, 48);
            panel7.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 14);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(64, 10);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " School Year Name or Id";
            textBox1.Size = new Size(624, 29);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(696, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 24);
            panel2.TabIndex = 0;
            // 
            // _dateArchive
            // 
            _dateArchive.AutoSize = true;
            _dateArchive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _dateArchive.Location = new Point(141, 122);
            _dateArchive.Name = "_dateArchive";
            _dateArchive.Size = new Size(38, 21);
            _dateArchive.TabIndex = 16;
            _dateArchive.Text = "N/A";
            // 
            // _coursesContainer
            // 
            _coursesContainer.BackColor = SystemColors.Control;
            _coursesContainer.BorderStyle = BorderStyle.FixedSingle;
            _coursesContainer.Controls.Add(panel8);
            _coursesContainer.Controls.Add(panel7);
            _coursesContainer.Dock = DockStyle.Fill;
            _coursesContainer.Location = new Point(3, 3);
            _coursesContainer.Name = "_coursesContainer";
            _coursesContainer.Padding = new Padding(4);
            _coursesContainer.Size = new Size(813, 686);
            _coursesContainer.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Control;
            panel8.Controls.Add(_syDGV);
            panel8.Controls.Add(panel2);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(4, 52);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(8);
            panel8.Size = new Size(803, 628);
            panel8.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 16);
            label2.Name = "label2";
            label2.Size = new Size(242, 21);
            label2.TabIndex = 4;
            label2.Text = "Selected School Year Information:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(_courseCount);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(407, 48);
            panel4.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.Controls.Add(_syDateConcluded, 1, 4);
            tableLayoutPanel2.Controls.Add(label13, 0, 4);
            tableLayoutPanel2.Controls.Add(_syDateStart, 1, 3);
            tableLayoutPanel2.Controls.Add(label11, 0, 3);
            tableLayoutPanel2.Controls.Add(_syId, 1, 2);
            tableLayoutPanel2.Controls.Add(label9, 0, 2);
            tableLayoutPanel2.Controls.Add(_syName, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label15, 0, 5);
            tableLayoutPanel2.Controls.Add(_dateArchive, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(8, 8);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(391, 612);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(tableLayoutPanel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(4, 52);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(8);
            panel5.Size = new Size(407, 628);
            panel5.TabIndex = 6;
            // 
            // _courseSelectedContainer
            // 
            _courseSelectedContainer.BorderStyle = BorderStyle.FixedSingle;
            _courseSelectedContainer.Controls.Add(panel5);
            _courseSelectedContainer.Controls.Add(panel4);
            _courseSelectedContainer.Dock = DockStyle.Fill;
            _courseSelectedContainer.Location = new Point(822, 3);
            _courseSelectedContainer.Name = "_courseSelectedContainer";
            _courseSelectedContainer.Padding = new Padding(4);
            _courseSelectedContainer.Size = new Size(417, 686);
            _courseSelectedContainer.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.94203F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.057972F));
            tableLayoutPanel1.Controls.Add(_courseSelectedContainer, 1, 0);
            tableLayoutPanel1.Controls.Add(_coursesContainer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1242, 692);
            tableLayoutPanel1.TabIndex = 35;
            // 
            // SecondaryActiomButton
            // 
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
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(54, 69, 79);
            panel6.Controls.Add(SecondaryActiomButton);
            panel6.Controls.Add(MainActionButton);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 692);
            panel6.Name = "panel6";
            panel6.Size = new Size(1242, 49);
            panel6.TabIndex = 34;
            // 
            // SelectSchoolYearDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 741);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SelectSchoolYearDialog";
            Text = "SelectSchoolYearDialog";
            ((System.ComponentModel.ISupportInitialize)_syDGV).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            _coursesContainer.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel5.ResumeLayout(false);
            _courseSelectedContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView _syDGV;
        private Label _syDateConcluded;
        private Label label13;
        private Label _syDateStart;
        private Label label11;
        private Label _courseCount;
        private Label _syId;
        private Label label9;
        private Label _syName;
        private Label label5;
        private Label label15;
        private Label label3;
        private Panel panel7;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel2;
        private Label _dateArchive;
        private Panel _coursesContainer;
        private Panel panel8;
        private Label label2;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private Panel _courseSelectedContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private Panel panel6;
        private DataGridViewTextBoxColumn SchoolYearName;
        private DataGridViewTextBoxColumn SYId;
        private DataGridViewTextBoxColumn DateStart;
        private DataGridViewTextBoxColumn DateConcluded;
        private DataGridViewTextBoxColumn DateArchived;
        private DataGridViewButtonColumn SelectSY;
    }
}