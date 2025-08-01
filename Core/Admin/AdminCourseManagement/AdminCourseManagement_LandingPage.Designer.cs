namespace Finals.Core.Admin.AdminCourseManagement
{
    partial class AdminCourseManagement_LandingPage
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
            panel3 = new Panel();
            comboBox2 = new ComboBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button4 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            _totalPrograms = new Label();
            label1 = new Label();
            panel4 = new Panel();
            _programsContainer = new FlowLayoutPanel();
            panel5 = new Panel();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            comboBox3 = new ComboBox();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(comboBox3);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1059, 72);
            panel3.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "- Units -", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox2.Location = new Point(288, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(144, 29);
            comboBox2.TabIndex = 34;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(440, 32);
            button1.Name = "button1";
            button1.Size = new Size(85, 28);
            button1.TabIndex = 33;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Open", "Closed" });
            comboBox1.Location = new Point(1659, -6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 29);
            comboBox1.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Course";
            textBox1.Size = new Size(528, 29);
            textBox1.TabIndex = 29;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = SystemColors.Highlight;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1827, -6);
            button4.Name = "button4";
            button4.Size = new Size(85, 28);
            button4.TabIndex = 30;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 72);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1059, 635);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(_totalPrograms);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(881, 3);
            panel2.MinimumSize = new Size(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 37);
            panel2.TabIndex = 4;
            // 
            // _totalPrograms
            // 
            _totalPrograms.AutoSize = true;
            _totalPrograms.Location = new Point(128, 8);
            _totalPrograms.Name = "_totalPrograms";
            _totalPrograms.Size = new Size(13, 15);
            _totalPrograms.TabIndex = 3;
            _totalPrograms.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Courses";
            // 
            // panel4
            // 
            panel4.Controls.Add(_programsContainer);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(872, 629);
            panel4.TabIndex = 5;
            // 
            // _programsContainer
            // 
            _programsContainer.AutoScroll = true;
            _programsContainer.BackColor = SystemColors.ControlLight;
            _programsContainer.BorderStyle = BorderStyle.FixedSingle;
            _programsContainer.Dock = DockStyle.Fill;
            _programsContainer.Location = new Point(0, 36);
            _programsContainer.Name = "_programsContainer";
            _programsContainer.Padding = new Padding(4);
            _programsContainer.Size = new Size(872, 593);
            _programsContainer.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(label9);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(872, 36);
            panel5.TabIndex = 5;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Location = new Point(344, 8);
            label9.Name = "label9";
            label9.Size = new Size(168, 23);
            label9.TabIndex = 10;
            label9.Text = "Page 1 of 1";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(512, 8);
            button2.Name = "button2";
            button2.Size = new Size(25, 25);
            button2.TabIndex = 8;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(320, 8);
            button3.Name = "button3";
            button3.Size = new Size(25, 25);
            button3.TabIndex = 9;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "All", "Created by you" });
            comboBox3.Location = new Point(0, 32);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(280, 29);
            comboBox3.TabIndex = 35;
            // 
            // AdminCourseManagement_LandingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel3);
            Name = "AdminCourseManagement_LandingPage";
            Size = new Size(1059, 707);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button4;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label _totalPrograms;
        private Label label1;
        private Label label9;
        private Button button2;
        private Button button3;
        private Panel panel4;
        private FlowLayoutPanel _programsContainer;
        private Panel panel5;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}
