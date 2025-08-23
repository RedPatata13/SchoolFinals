namespace Finals.Forms
{
    partial class SemesterCreationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemesterCreationDialog));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            _charCount = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            startDateTimeSelector = new DateTimePicker();
            startDateDateSelector = new DateTimePicker();
            panel2 = new Panel();
            endDateTimeSelector = new DateTimePicker();
            endDateDateSelector = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            SecondaryActiomButton = new Button();
            MainActionButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.Size = new Size(692, 373);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(_charCount);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(156, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(533, 34);
            panel3.TabIndex = 11;
            // 
            // _charCount
            // 
            _charCount.AutoSize = true;
            _charCount.ForeColor = SystemColors.ControlDarkDark;
            _charCount.Location = new Point(472, 8);
            _charCount.Name = "_charCount";
            _charCount.Size = new Size(48, 15);
            _charCount.TabIndex = 3;
            _charCount.Text = "100/100";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(startDateTimeSelector);
            panel1.Controls.Add(startDateDateSelector);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(156, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 34);
            panel1.TabIndex = 10;
            // 
            // startDateTimeSelector
            // 
            startDateTimeSelector.Checked = false;
            startDateTimeSelector.CustomFormat = "hh:mm tt";
            startDateTimeSelector.Format = DateTimePickerFormat.Custom;
            startDateTimeSelector.Location = new Point(312, 6);
            startDateTimeSelector.Name = "startDateTimeSelector";
            startDateTimeSelector.ShowUpDown = true;
            startDateTimeSelector.Size = new Size(152, 23);
            startDateTimeSelector.TabIndex = 1;
            // 
            // startDateDateSelector
            // 
            startDateDateSelector.Checked = false;
            startDateDateSelector.CustomFormat = "MMM dd, yyyy";
            startDateDateSelector.Format = DateTimePickerFormat.Custom;
            startDateDateSelector.Location = new Point(8, 6);
            startDateDateSelector.Name = "startDateDateSelector";
            startDateDateSelector.Size = new Size(296, 23);
            startDateDateSelector.TabIndex = 0;
            startDateDateSelector.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(endDateTimeSelector);
            panel2.Controls.Add(endDateDateSelector);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(156, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(533, 34);
            panel2.TabIndex = 6;
            // 
            // endDateTimeSelector
            // 
            endDateTimeSelector.Checked = false;
            endDateTimeSelector.CustomFormat = "hh:mm tt";
            endDateTimeSelector.Format = DateTimePickerFormat.Custom;
            endDateTimeSelector.Location = new Point(312, 6);
            endDateTimeSelector.Name = "endDateTimeSelector";
            endDateTimeSelector.ShowUpDown = true;
            endDateTimeSelector.Size = new Size(152, 23);
            endDateTimeSelector.TabIndex = 2;
            // 
            // endDateDateSelector
            // 
            endDateDateSelector.Checked = false;
            endDateDateSelector.CustomFormat = "MMM dd, yyyy";
            endDateDateSelector.Format = DateTimePickerFormat.Custom;
            endDateDateSelector.Location = new Point(8, 6);
            endDateDateSelector.Name = "endDateDateSelector";
            endDateDateSelector.Size = new Size(296, 23);
            endDateDateSelector.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 49);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 3;
            label2.Text = "Date Start";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 1;
            label1.Text = "Semester Name:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 89);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 4;
            label3.Text = "Date End";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(156, 132);
            label4.Name = "label4";
            label4.Size = new Size(520, 78);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(54, 69, 79);
            panel6.Controls.Add(SecondaryActiomButton);
            panel6.Controls.Add(MainActionButton);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 336);
            panel6.Name = "panel6";
            panel6.Size = new Size(692, 49);
            panel6.TabIndex = 35;
            // 
            // SecondaryActiomButton
            // 
            SecondaryActiomButton.BackColor = SystemColors.ControlLight;
            SecondaryActiomButton.FlatStyle = FlatStyle.Flat;
            SecondaryActiomButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecondaryActiomButton.ForeColor = SystemColors.ControlText;
            SecondaryActiomButton.Location = new Point(512, 8);
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
            MainActionButton.Location = new Point(600, 8);
            MainActionButton.Name = "MainActionButton";
            MainActionButton.Size = new Size(85, 37);
            MainActionButton.TabIndex = 19;
            MainActionButton.Text = "Confirm";
            MainActionButton.UseVisualStyleBackColor = false;
            MainActionButton.Click += MainActionButton_Click;
            // 
            // SemesterCreationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 385);
            Controls.Add(panel6);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SemesterCreationDialog";
            Padding = new Padding(0, 12, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SemesterCreationDialog";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel6;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private DateTimePicker endDateDateSelector;
        private Label label4;
        private Panel panel3;
        private Panel panel1;
        private DateTimePicker startDateDateSelector;
        private Label _charCount;
        private DateTimePicker startDateTimeSelector;
        private DateTimePicker endDateTimeSelector;
    }
}