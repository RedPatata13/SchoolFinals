namespace Finals.Forms.UserControls
{
    partial class CourseMultiSelectDialog
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
            panel1 = new Panel();
            _courseSelectedContainer = new Panel();
            panel5 = new Panel();
            _selectedCourseDGV = new DataGridView();
            SelectedCourseName = new DataGridViewTextBoxColumn();
            SelectedCourseId = new DataGridViewTextBoxColumn();
            RemoveCourse = new DataGridViewButtonColumn();
            panel3 = new Panel();
            label5 = new Label();
            _totalSelectedCoursesCount = new Label();
            label6 = new Label();
            panel4 = new Panel();
            button2 = new Button();
            label2 = new Label();
            _coursesContainer = new Panel();
            panel8 = new Panel();
            _coursesDGV = new DataGridView();
            CourseName = new DataGridViewTextBoxColumn();
            CourseId = new DataGridViewTextBoxColumn();
            DateCreated = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            AddCourse = new DataGridViewButtonColumn();
            panel2 = new Panel();
            label4 = new Label();
            _courseCount = new Label();
            label3 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            _courseSelectedContainer.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_selectedCourseDGV).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            _coursesContainer.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_coursesDGV).BeginInit();
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
            panel6.TabIndex = 31;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(_courseSelectedContainer);
            panel1.Controls.Add(_coursesContainer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 692);
            panel1.TabIndex = 32;
            // 
            // _courseSelectedContainer
            // 
            _courseSelectedContainer.BorderStyle = BorderStyle.FixedSingle;
            _courseSelectedContainer.Controls.Add(panel5);
            _courseSelectedContainer.Controls.Add(panel4);
            _courseSelectedContainer.Location = new Point(821, 10);
            _courseSelectedContainer.Name = "_courseSelectedContainer";
            _courseSelectedContainer.Size = new Size(408, 670);
            _courseSelectedContainer.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(_selectedCourseDGV);
            panel5.Controls.Add(panel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 48);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(8);
            panel5.Size = new Size(406, 620);
            panel5.TabIndex = 6;
            // 
            // _selectedCourseDGV
            // 
            _selectedCourseDGV.AllowUserToAddRows = false;
            _selectedCourseDGV.AllowUserToDeleteRows = false;
            _selectedCourseDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _selectedCourseDGV.Columns.AddRange(new DataGridViewColumn[] { SelectedCourseName, SelectedCourseId, RemoveCourse });
            _selectedCourseDGV.Dock = DockStyle.Fill;
            _selectedCourseDGV.Location = new Point(8, 32);
            _selectedCourseDGV.Name = "_selectedCourseDGV";
            _selectedCourseDGV.ReadOnly = true;
            _selectedCourseDGV.Size = new Size(390, 580);
            _selectedCourseDGV.TabIndex = 2;
            _selectedCourseDGV.CellContentClick += _selectedourses_CellContentClick;
            // 
            // SelectedCourseName
            // 
            SelectedCourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SelectedCourseName.HeaderText = "Course Name";
            SelectedCourseName.Name = "SelectedCourseName";
            SelectedCourseName.ReadOnly = true;
            // 
            // SelectedCourseId
            // 
            SelectedCourseId.HeaderText = "Course Id";
            SelectedCourseId.Name = "SelectedCourseId";
            SelectedCourseId.ReadOnly = true;
            // 
            // RemoveCourse
            // 
            RemoveCourse.HeaderText = "Remove Course";
            RemoveCourse.Name = "RemoveCourse";
            RemoveCourse.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(_totalSelectedCoursesCount);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(8, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 24);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 4);
            label5.Name = "label5";
            label5.Size = new Size(97, 13);
            label5.TabIndex = 2;
            label5.Text = "Selected Courses:";
            // 
            // _totalSelectedCoursesCount
            // 
            _totalSelectedCoursesCount.AutoSize = true;
            _totalSelectedCoursesCount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _totalSelectedCoursesCount.Location = new Point(356, 6);
            _totalSelectedCoursesCount.Name = "_totalSelectedCoursesCount";
            _totalSelectedCoursesCount.Size = new Size(13, 13);
            _totalSelectedCoursesCount.TabIndex = 1;
            _totalSelectedCoursesCount.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(232, 6);
            label6.Name = "label6";
            label6.Size = new Size(124, 13);
            label6.TabIndex = 0;
            label6.Text = "Total Selected Courses:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 48);
            panel4.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 57, 73);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(322, 16);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Clear all";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 16);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 4;
            label2.Text = "Courses Selected";
            // 
            // _coursesContainer
            // 
            _coursesContainer.BackColor = SystemColors.Control;
            _coursesContainer.BorderStyle = BorderStyle.FixedSingle;
            _coursesContainer.Controls.Add(panel8);
            _coursesContainer.Controls.Add(panel7);
            _coursesContainer.Location = new Point(13, 10);
            _coursesContainer.Name = "_coursesContainer";
            _coursesContainer.Size = new Size(800, 670);
            _coursesContainer.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Control;
            panel8.Controls.Add(_coursesDGV);
            panel8.Controls.Add(panel2);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 48);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(8);
            panel8.Size = new Size(798, 620);
            panel8.TabIndex = 4;
            // 
            // _coursesDGV
            // 
            _coursesDGV.AllowUserToAddRows = false;
            _coursesDGV.AllowUserToDeleteRows = false;
            _coursesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _coursesDGV.Columns.AddRange(new DataGridViewColumn[] { CourseName, CourseId, DateCreated, CreatedBy, AddCourse });
            _coursesDGV.Dock = DockStyle.Fill;
            _coursesDGV.Location = new Point(8, 32);
            _coursesDGV.Name = "_coursesDGV";
            _coursesDGV.ReadOnly = true;
            _coursesDGV.Size = new Size(782, 580);
            _coursesDGV.TabIndex = 1;
            _coursesDGV.CellContentClick += _courses_CellContentClick;
            // 
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseName.HeaderText = "Course";
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            // 
            // CourseId
            // 
            CourseId.HeaderText = "Course Id";
            CourseId.Name = "CourseId";
            CourseId.ReadOnly = true;
            // 
            // DateCreated
            // 
            DateCreated.HeaderText = "Date Created";
            DateCreated.Name = "DateCreated";
            DateCreated.ReadOnly = true;
            // 
            // CreatedBy
            // 
            CreatedBy.HeaderText = "Created By";
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            // 
            // AddCourse
            // 
            AddCourse.HeaderText = "Add Course";
            AddCourse.Name = "AddCourse";
            AddCourse.ReadOnly = true;
            AddCourse.Resizable = DataGridViewTriState.True;
            AddCourse.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(_courseCount);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 24);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(592, 6);
            label4.Name = "label4";
            label4.Size = new Size(146, 13);
            label4.TabIndex = 2;
            label4.Text = "Unselected Courses Count:";
            // 
            // _courseCount
            // 
            _courseCount.AutoSize = true;
            _courseCount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _courseCount.Location = new Point(744, 6);
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
            label3.Size = new Size(111, 13);
            label3.TabIndex = 0;
            label3.Text = "Unselected Courses:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(button1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(798, 48);
            panel7.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 1;
            label1.Text = "Search Course:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(128, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(576, 29);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(712, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // CourseMultiSelectDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 741);
            Controls.Add(panel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CourseMultiSelectDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ss";
            panel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            _courseSelectedContainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_selectedCourseDGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            _coursesContainer.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_coursesDGV).EndInit();
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
        private Panel panel1;
        private Panel _courseSelectedContainer;
        private Panel panel5;
        private Panel panel4;
        private Button button2;
        private Label label2;
        private Panel _coursesContainer;
        private Panel panel8;
        private Panel panel7;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView _coursesDGV;
        private Panel panel2;
        private Label label3;
        private Label _courseCount;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn CourseId;
        private DataGridViewTextBoxColumn DateCreated;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewButtonColumn AddCourse;
        private Panel panel3;
        private Label _totalSelectedCoursesCount;
        private Label label6;
        private DataGridView _selectedCourseDGV;
        private DataGridViewTextBoxColumn SelectedCourseName;
        private DataGridViewTextBoxColumn SelectedCourseId;
        private DataGridViewButtonColumn RemoveCourse;
        private Label label4;
        private Label label5;
    }
}