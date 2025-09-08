namespace Finals.Core.Teacher.UserControls
{
    partial class StudentCollectionGradesEditDialog
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
            label1 = new Label();
            button1 = new Button();
            panel7 = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            _coursesContainer = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel9 = new Panel();
            panel5 = new Panel();
            _unselectedStudentsDGV = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            IncludeStudent = new DataGridViewButtonColumn();
            panel3 = new Panel();
            label6 = new Label();
            checkBox1 = new CheckBox();
            panel10 = new Panel();
            label8 = new Label();
            _courseSelectedContainer = new Panel();
            panel8 = new Panel();
            _selectedStudentsDGV = new DataGridView();
            StudentId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewButtonColumn();
            panel2 = new Panel();
            label4 = new Label();
            _courseCount = new Label();
            label3 = new Label();
            panel4 = new Panel();
            button2 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            SecondaryActiomButton = new Button();
            MainActionButton = new Button();
            panel6 = new Panel();
            panel7.SuspendLayout();
            _coursesContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_unselectedStudentsDGV).BeginInit();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            _courseSelectedContainer.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_selectedStudentsDGV).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "Search Student";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(712, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(comboBox1);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(button1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(4, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1232, 84);
            panel7.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(128, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(89, 23);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(216, 48);
            label5.Name = "label5";
            label5.Size = new Size(17, 21);
            label5.TabIndex = 8;
            label5.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 48);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 6;
            label7.Text = "Grade Selected";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(128, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(576, 29);
            textBox1.TabIndex = 0;
            // 
            // _coursesContainer
            // 
            _coursesContainer.BackColor = SystemColors.Control;
            _coursesContainer.BorderStyle = BorderStyle.FixedSingle;
            _coursesContainer.Controls.Add(tableLayoutPanel1);
            _coursesContainer.Controls.Add(panel7);
            _coursesContainer.Dock = DockStyle.Fill;
            _coursesContainer.Location = new Point(0, 0);
            _coursesContainer.Name = "_coursesContainer";
            _coursesContainer.Padding = new Padding(4);
            _coursesContainer.Size = new Size(1242, 692);
            _coursesContainer.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.82143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.17857F));
            tableLayoutPanel1.Controls.Add(panel9, 0, 0);
            tableLayoutPanel1.Controls.Add(_courseSelectedContainer, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 88);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1232, 598);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(4);
            panel9.Size = new Size(731, 592);
            panel9.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(_unselectedStudentsDGV);
            panel5.Controls.Add(panel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(4, 40);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(8);
            panel5.Size = new Size(721, 546);
            panel5.TabIndex = 9;
            // 
            // _unselectedStudentsDGV
            // 
            _unselectedStudentsDGV.AllowUserToAddRows = false;
            _unselectedStudentsDGV.AllowUserToDeleteRows = false;
            _unselectedStudentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _unselectedStudentsDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, IncludeStudent });
            _unselectedStudentsDGV.Dock = DockStyle.Fill;
            _unselectedStudentsDGV.Location = new Point(8, 32);
            _unselectedStudentsDGV.Name = "_unselectedStudentsDGV";
            _unselectedStudentsDGV.ReadOnly = true;
            _unselectedStudentsDGV.RowHeadersVisible = false;
            _unselectedStudentsDGV.Size = new Size(705, 506);
            _unselectedStudentsDGV.TabIndex = 2;
            _unselectedStudentsDGV.CellContentClick += _unselectedStudentsDGV_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Student Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Grade";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // IncludeStudent
            // 
            IncludeStudent.HeaderText = "Include Student";
            IncludeStudent.Name = "IncludeStudent";
            IncludeStudent.ReadOnly = true;
            IncludeStudent.Text = "Include";
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(checkBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(8, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(705, 24);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(572, 8);
            label6.Name = "label6";
            label6.Size = new Size(111, 13);
            label6.TabIndex = 5;
            label6.Text = "Selected Students: 0";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Only Include Ungraded";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.Control;
            panel10.Controls.Add(label8);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(4, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(721, 36);
            panel10.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 8);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 4;
            label8.Text = "Students";
            // 
            // _courseSelectedContainer
            // 
            _courseSelectedContainer.BorderStyle = BorderStyle.FixedSingle;
            _courseSelectedContainer.Controls.Add(panel8);
            _courseSelectedContainer.Controls.Add(panel4);
            _courseSelectedContainer.Location = new Point(740, 3);
            _courseSelectedContainer.Name = "_courseSelectedContainer";
            _courseSelectedContainer.Padding = new Padding(4);
            _courseSelectedContainer.Size = new Size(489, 592);
            _courseSelectedContainer.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Control;
            panel8.Controls.Add(_selectedStudentsDGV);
            panel8.Controls.Add(panel2);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(4, 40);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(8);
            panel8.Size = new Size(479, 546);
            panel8.TabIndex = 8;
            // 
            // _selectedStudentsDGV
            // 
            _selectedStudentsDGV.AllowUserToAddRows = false;
            _selectedStudentsDGV.AllowUserToDeleteRows = false;
            _selectedStudentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _selectedStudentsDGV.Columns.AddRange(new DataGridViewColumn[] { StudentId, StudentName, Grade, Remove });
            _selectedStudentsDGV.Dock = DockStyle.Fill;
            _selectedStudentsDGV.Location = new Point(8, 32);
            _selectedStudentsDGV.Name = "_selectedStudentsDGV";
            _selectedStudentsDGV.ReadOnly = true;
            _selectedStudentsDGV.RowHeadersVisible = false;
            _selectedStudentsDGV.Size = new Size(463, 506);
            _selectedStudentsDGV.TabIndex = 1;
            _selectedStudentsDGV.CellContentClick += _selectedStudentsDGV_CellContentClick;
            // 
            // StudentId
            // 
            StudentId.HeaderText = "Student Id";
            StudentId.Name = "StudentId";
            StudentId.ReadOnly = true;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentName.HeaderText = "Name";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // Grade
            // 
            Grade.HeaderText = "Grade";
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            // 
            // Remove
            // 
            Remove.HeaderText = "Remove Student";
            Remove.Name = "Remove";
            Remove.ReadOnly = true;
            Remove.Text = "Remove";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(_courseCount);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 24);
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
            label3.Text = "Selected Students: 0";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(479, 36);
            panel4.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 57, 73);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(392, 8);
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
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 4;
            label2.Text = "Courses Selected";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(_coursesContainer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 692);
            panel1.TabIndex = 34;
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
            panel6.TabIndex = 33;
            // 
            // StudentCollectionGradesEditDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 741);
            Controls.Add(panel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StudentCollectionGradesEditDialog";
            Text = "StudentCollectionGradesEditDialog";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            _coursesContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_unselectedStudentsDGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            _courseSelectedContainer.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_selectedStudentsDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel7;
        private TextBox textBox1;
        private Panel _coursesContainer;
        private Button button2;
        private Label label2;
        private Panel panel4;
        private Panel _courseSelectedContainer;
        private Panel panel1;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private Panel panel6;
        private ComboBox comboBox1;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel9;
        private Panel panel5;
        private Panel panel3;
        private Panel panel10;
        private Label label8;
        private Panel panel8;
        private DataGridView _selectedStudentsDGV;
        private Panel panel2;
        private Label label4;
        private Label _courseCount;
        private Label label3;
        private CheckBox checkBox1;
        private Label label5;
        private DataGridView _unselectedStudentsDGV;
        private Label label6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn IncludeStudent;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewButtonColumn Remove;
    }
}