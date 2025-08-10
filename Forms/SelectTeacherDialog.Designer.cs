namespace Finals.Forms
{
    partial class SelectTeacherDialog
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
            tableLayoutPanel1 = new TableLayoutPanel();
            _courseSelectedContainer = new Panel();
            panel5 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            _middleName = new Label();
            label13 = new Label();
            _firstName = new Label();
            label11 = new Label();
            _lastName = new Label();
            label9 = new Label();
            _fullName = new Label();
            label5 = new Label();
            label15 = new Label();
            _dateJoined = new Label();
            panel4 = new Panel();
            label2 = new Label();
            _coursesContainer = new Panel();
            panel8 = new Panel();
            _teacherDGV = new DataGridView();
            TeacherName = new DataGridViewTextBoxColumn();
            TeacherId = new DataGridViewTextBoxColumn();
            DateJoined = new DataGridViewTextBoxColumn();
            SelectTeacher = new DataGridViewButtonColumn();
            panel2 = new Panel();
            label4 = new Label();
            _courseCount = new Label();
            label3 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            _courseSelectedContainer.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            _coursesContainer.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_teacherDGV).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
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
            panel6.TabIndex = 32;
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
            tableLayoutPanel1.TabIndex = 33;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.Controls.Add(_middleName, 1, 4);
            tableLayoutPanel2.Controls.Add(label13, 0, 4);
            tableLayoutPanel2.Controls.Add(_firstName, 1, 3);
            tableLayoutPanel2.Controls.Add(label11, 0, 3);
            tableLayoutPanel2.Controls.Add(_lastName, 1, 2);
            tableLayoutPanel2.Controls.Add(label9, 0, 2);
            tableLayoutPanel2.Controls.Add(_fullName, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label15, 0, 6);
            tableLayoutPanel2.Controls.Add(_dateJoined, 1, 6);
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
            // _middleName
            // 
            _middleName.AutoSize = true;
            _middleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _middleName.Location = new Point(141, 94);
            _middleName.Name = "_middleName";
            _middleName.Size = new Size(38, 21);
            _middleName.TabIndex = 14;
            _middleName.Text = "N/A";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 94);
            label13.Name = "label13";
            label13.Size = new Size(107, 21);
            label13.TabIndex = 13;
            label13.Text = "Middle Name:";
            // 
            // _firstName
            // 
            _firstName.AutoSize = true;
            _firstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _firstName.Location = new Point(141, 66);
            _firstName.Name = "_firstName";
            _firstName.Size = new Size(38, 21);
            _firstName.TabIndex = 12;
            _firstName.Text = "N/A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 66);
            label11.Name = "label11";
            label11.Size = new Size(89, 21);
            label11.TabIndex = 11;
            label11.Text = "First Name:";
            // 
            // _lastName
            // 
            _lastName.AutoSize = true;
            _lastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _lastName.Location = new Point(141, 38);
            _lastName.Name = "_lastName";
            _lastName.Size = new Size(38, 21);
            _lastName.TabIndex = 10;
            _lastName.Text = "N/A";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 38);
            label9.Name = "label9";
            label9.Size = new Size(87, 21);
            label9.TabIndex = 9;
            label9.Text = "Last Name:";
            // 
            // _fullName
            // 
            _fullName.AutoSize = true;
            _fullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _fullName.Location = new Point(141, 10);
            _fullName.Name = "_fullName";
            _fullName.Size = new Size(38, 21);
            _fullName.TabIndex = 8;
            _fullName.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 5;
            label5.Text = "Full Name:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 150);
            label15.Name = "label15";
            label15.Size = new Size(94, 21);
            label15.TabIndex = 15;
            label15.Text = "Date Joined:";
            // 
            // _dateJoined
            // 
            _dateJoined.AutoSize = true;
            _dateJoined.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _dateJoined.Location = new Point(141, 150);
            _dateJoined.Name = "_dateJoined";
            _dateJoined.Size = new Size(38, 21);
            _dateJoined.TabIndex = 16;
            _dateJoined.Text = "N/A";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(407, 48);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 16);
            label2.Name = "label2";
            label2.Size = new Size(213, 21);
            label2.TabIndex = 4;
            label2.Text = "Selected Teacher Information:";
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
            panel8.Controls.Add(_teacherDGV);
            panel8.Controls.Add(panel2);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(4, 52);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(8);
            panel8.Size = new Size(803, 628);
            panel8.TabIndex = 4;
            // 
            // _teacherDGV
            // 
            _teacherDGV.AllowUserToAddRows = false;
            _teacherDGV.AllowUserToDeleteRows = false;
            _teacherDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _teacherDGV.Columns.AddRange(new DataGridViewColumn[] { TeacherName, TeacherId, DateJoined, SelectTeacher });
            _teacherDGV.Dock = DockStyle.Fill;
            _teacherDGV.Location = new Point(8, 32);
            _teacherDGV.Name = "_teacherDGV";
            _teacherDGV.ReadOnly = true;
            _teacherDGV.Size = new Size(787, 588);
            _teacherDGV.TabIndex = 1;
            _teacherDGV.CellContentClick += _teachers_CellContentClick;
            // 
            // TeacherName
            // 
            TeacherName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TeacherName.HeaderText = "Teacher Name";
            TeacherName.Name = "TeacherName";
            TeacherName.ReadOnly = true;
            // 
            // TeacherId
            // 
            TeacherId.HeaderText = "Teacher Id";
            TeacherId.Name = "TeacherId";
            TeacherId.ReadOnly = true;
            // 
            // DateJoined
            // 
            DateJoined.HeaderText = "Date Joined";
            DateJoined.Name = "DateJoined";
            DateJoined.ReadOnly = true;
            // 
            // SelectTeacher
            // 
            SelectTeacher.HeaderText = "Select Teacher";
            SelectTeacher.Name = "SelectTeacher";
            SelectTeacher.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(_courseCount);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 24);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1199, 6);
            label4.Name = "label4";
            label4.Size = new Size(146, 13);
            label4.TabIndex = 2;
            label4.Text = "Teacher Count:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // _courseCount
            // 
            _courseCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _courseCount.AutoSize = true;
            _courseCount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _courseCount.Location = new Point(1351, 6);
            _courseCount.Name = "_courseCount";
            _courseCount.Size = new Size(13, 13);
            _courseCount.TabIndex = 1;
            _courseCount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 6);
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
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 1;
            label1.Text = "Search Teacher:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(128, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 29);
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
            // SelectTeacherDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 741);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SelectTeacherDialog";
            Text = "SelectTeacherDialog";
            panel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            _courseSelectedContainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            _coursesContainer.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_teacherDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel6;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel _courseSelectedContainer;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label _middleName;
        private Label label13;
        private Label _firstName;
        private Label label11;
        private Label _lastName;
        private Label label9;
        private Label _fullName;
        private Label label5;
        private Label label15;
        private Label _dateJoined;
        private Panel panel4;
        private Label label2;
        private Panel _coursesContainer;
        private Panel panel8;
        private DataGridView _teacherDGV;
        private DataGridViewTextBoxColumn TeacherName;
        private DataGridViewTextBoxColumn TeacherId;
        private DataGridViewTextBoxColumn DateJoined;
        private DataGridViewButtonColumn SelectTeacher;
        private Panel panel2;
        private Label label4;
        private Label _courseCount;
        private Label label3;
        private Panel panel7;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}