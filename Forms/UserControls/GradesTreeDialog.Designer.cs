namespace Finals.Forms.UserControls
{
    partial class GradesTreeDialog
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
            HoverEffect hoverEffect1 = new HoverEffect();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesTreeDialog));
            coursePanel1 = new Core.Teacher.UserControls.CoursePanel();
            _gradesTree = new TreeView();
            panel1 = new Panel();
            SecondaryActiomButton = new Button();
            MainActionButton = new Button();
            label1 = new Label();
            _childrenValues = new Panel();
            label2 = new Label();
            label3 = new Label();
            _categorySubtotal = new Label();
            label5 = new Label();
            label6 = new Label();
            AddButton = new Button();
            label4 = new Label();
            _category = new Label();
            AddAttendanceButton = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // coursePanel1
            // 
            hoverEffect1.MouseEnter = SystemColors.ControlLight;
            hoverEffect1.PrevColor = SystemColors.ActiveBorder;
            coursePanel1.DefaultHoverEffects = hoverEffect1;
            coursePanel1.IsOngoing = false;
            coursePanel1.Location = new Point(0, 0);
            coursePanel1.Name = "coursePanel1";
            coursePanel1.Padding = new Padding(1);
            coursePanel1.Size = new Size(785, 150);
            coursePanel1.TabIndex = 0;
            // 
            // _gradesTree
            // 
            _gradesTree.BackColor = Color.FromArgb(54, 69, 79);
            _gradesTree.Dock = DockStyle.Left;
            _gradesTree.ForeColor = SystemColors.HighlightText;
            _gradesTree.Location = new Point(0, 0);
            _gradesTree.Name = "_gradesTree";
            _gradesTree.Size = new Size(176, 601);
            _gradesTree.TabIndex = 2;
            _gradesTree.AfterSelect += treeView1_AfterSelect;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(SecondaryActiomButton);
            panel1.Controls.Add(MainActionButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(176, 559);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 42);
            panel1.TabIndex = 3;
            // 
            // SecondaryActiomButton
            // 
            SecondaryActiomButton.BackColor = SystemColors.ControlLight;
            SecondaryActiomButton.FlatStyle = FlatStyle.Flat;
            SecondaryActiomButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecondaryActiomButton.ForeColor = SystemColors.ControlText;
            SecondaryActiomButton.Location = new Point(592, 8);
            SecondaryActiomButton.Name = "SecondaryActiomButton";
            SecondaryActiomButton.Size = new Size(85, 29);
            SecondaryActiomButton.TabIndex = 9;
            SecondaryActiomButton.Text = "Cancel";
            SecondaryActiomButton.UseVisualStyleBackColor = false;
            // 
            // MainActionButton
            // 
            MainActionButton.BackColor = SystemColors.Highlight;
            MainActionButton.FlatStyle = FlatStyle.Flat;
            MainActionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainActionButton.ForeColor = SystemColors.HighlightText;
            MainActionButton.Location = new Point(680, 8);
            MainActionButton.Name = "MainActionButton";
            MainActionButton.Size = new Size(85, 29);
            MainActionButton.TabIndex = 8;
            MainActionButton.Text = "Confirm";
            MainActionButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 56);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 4;
            label1.Text = "Subcategories:";
            // 
            // _childrenValues
            // 
            _childrenValues.AutoScroll = true;
            _childrenValues.BackColor = SystemColors.ControlDark;
            _childrenValues.BorderStyle = BorderStyle.FixedSingle;
            _childrenValues.Location = new Point(192, 80);
            _childrenValues.Name = "_childrenValues";
            _childrenValues.Size = new Size(384, 464);
            _childrenValues.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(592, 80);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 6;
            label2.Text = "Note:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(608, 200);
            label3.Name = "label3";
            label3.Size = new Size(254, 30);
            label3.TabIndex = 7;
            label3.Text = "Current category subtotal:";
            // 
            // _categorySubtotal
            // 
            _categorySubtotal.AutoSize = true;
            _categorySubtotal.Font = new Font("Segoe UI", 15.75F);
            _categorySubtotal.Location = new Point(896, 200);
            _categorySubtotal.Name = "_categorySubtotal";
            _categorySubtotal.Size = new Size(46, 30);
            _categorySubtotal.TabIndex = 8;
            _categorySubtotal.Text = "100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(592, 128);
            label5.Name = "label5";
            label5.Size = new Size(282, 21);
            label5.TabIndex = 9;
            label5.Text = "- Category subtotal must equate to 100";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(616, 232);
            label6.Name = "label6";
            label6.Size = new Size(262, 15);
            label6.TabIndex = 11;
            label6.Text = "Category subtotal should equate at exactly 100%";
            label6.Visible = false;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.BackColor = SystemColors.Highlight;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = SystemColors.HighlightText;
            AddButton.Location = new Point(367, 53);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(56, 25);
            AddButton.TabIndex = 10;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(192, 8);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 12;
            label4.Text = "Category:";
            // 
            // _category
            // 
            _category.AutoSize = true;
            _category.Font = new Font("Segoe UI", 15.75F);
            _category.Location = new Point(304, 8);
            _category.Name = "_category";
            _category.Size = new Size(96, 30);
            _category.TabIndex = 13;
            _category.Text = "Category";
            // 
            // AddAttendanceButton
            // 
            AddAttendanceButton.AutoSize = true;
            AddAttendanceButton.BackColor = SystemColors.Control;
            AddAttendanceButton.FlatStyle = FlatStyle.Flat;
            AddAttendanceButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAttendanceButton.ForeColor = SystemColors.ControlText;
            AddAttendanceButton.Location = new Point(424, 53);
            AddAttendanceButton.Name = "AddAttendanceButton";
            AddAttendanceButton.Size = new Size(151, 25);
            AddAttendanceButton.TabIndex = 15;
            AddAttendanceButton.Text = "Add attendance category";
            AddAttendanceButton.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(593, 105);
            label8.Name = "label8";
            label8.Size = new Size(274, 21);
            label8.TabIndex = 16;
            label8.Text = "- 'Attendance' is automatically graded.";
            // 
            // GradesTreeDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 601);
            Controls.Add(label8);
            Controls.Add(AddAttendanceButton);
            Controls.Add(_category);
            Controls.Add(label4);
            Controls.Add(AddButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(_categorySubtotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(_childrenValues);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(_gradesTree);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "GradesTreeDialog";
            Text = "s";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Core.Teacher.UserControls.CoursePanel coursePanel1;
        private TreeView _gradesTree;
        private Panel panel1;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private Label label1;
        private Panel _childrenValues;
        private Label label2;
        private Label label3;
        private Label _categorySubtotal;
        private Label label5;
        private Label label6;
        private Button AddButton;
        private Label label4;
        private Label _category;
        private Button AddAttendanceButton;
        private Label label8;
    }
}