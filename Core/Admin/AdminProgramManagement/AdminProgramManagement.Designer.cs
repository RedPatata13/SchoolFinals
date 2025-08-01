namespace Finals.Core.Admin.AdminProgramManagement
{
    partial class AdminProgramManagement
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
            comboBox1 = new ComboBox();
            button4 = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            _programsContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            _addProgramButton = new Button();
            _closedPrograms = new Label();
            _openedPrograms = new Label();
            _totalPrograms = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1059, 48);
            panel3.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Open", "Closed" });
            comboBox1.Location = new Point(800, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 29);
            comboBox1.TabIndex = 32;
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
            button4.Location = new Point(968, 8);
            button4.Name = "button4";
            button4.Size = new Size(85, 28);
            button4.TabIndex = 30;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(8, 8);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Search Programs Here";
            textBox1.Size = new Size(784, 29);
            textBox1.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tableLayoutPanel1.Controls.Add(_programsContainer, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1059, 667);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // _programsContainer
            // 
            _programsContainer.AutoScroll = true;
            _programsContainer.BackColor = SystemColors.ControlLight;
            _programsContainer.BorderStyle = BorderStyle.FixedSingle;
            _programsContainer.Dock = DockStyle.Fill;
            _programsContainer.Location = new Point(3, 3);
            _programsContainer.Name = "_programsContainer";
            _programsContainer.Padding = new Padding(4);
            _programsContainer.Size = new Size(872, 661);
            _programsContainer.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(_addProgramButton);
            panel1.Controls.Add(_closedPrograms);
            panel1.Controls.Add(_openedPrograms);
            panel1.Controls.Add(_totalPrograms);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(881, 3);
            panel1.MinimumSize = new Size(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 125);
            panel1.TabIndex = 4;
            // 
            // _addProgramButton
            // 
            _addProgramButton.Anchor = AnchorStyles.Top;
            _addProgramButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _addProgramButton.BackColor = SystemColors.Control;
            _addProgramButton.FlatAppearance.BorderColor = Color.Black;
            _addProgramButton.FlatStyle = FlatStyle.Flat;
            _addProgramButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _addProgramButton.ForeColor = SystemColors.ControlText;
            _addProgramButton.Location = new Point(8, 8);
            _addProgramButton.Name = "_addProgramButton";
            _addProgramButton.Size = new Size(160, 28);
            _addProgramButton.TabIndex = 33;
            _addProgramButton.Text = "Create New Program";
            _addProgramButton.UseVisualStyleBackColor = false;
            // 
            // _closedPrograms
            // 
            _closedPrograms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _closedPrograms.AutoSize = true;
            _closedPrograms.Location = new Point(128, 96);
            _closedPrograms.Name = "_closedPrograms";
            _closedPrograms.Size = new Size(13, 15);
            _closedPrograms.TabIndex = 5;
            _closedPrograms.Text = "1";
            // 
            // _openedPrograms
            // 
            _openedPrograms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _openedPrograms.AutoSize = true;
            _openedPrograms.Location = new Point(128, 72);
            _openedPrograms.Name = "_openedPrograms";
            _openedPrograms.Size = new Size(13, 15);
            _openedPrograms.TabIndex = 4;
            _openedPrograms.Text = "1";
            // 
            // _totalPrograms
            // 
            _totalPrograms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _totalPrograms.AutoSize = true;
            _totalPrograms.Location = new Point(128, 48);
            _totalPrograms.Name = "_totalPrograms";
            _totalPrograms.Size = new Size(13, 15);
            _totalPrograms.TabIndex = 3;
            _totalPrograms.Text = "1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(8, 96);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Closed";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(8, 72);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Opened";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(8, 48);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Programs";
            // 
            // AdminProgramManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel3);
            Name = "AdminProgramManagement";
            Size = new Size(1059, 715);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private ComboBox comboBox1;
        private Button button4;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel _programsContainer;
        private Panel panel1;
        private Label _closedPrograms;
        private Label _openedPrograms;
        private Label _totalPrograms;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button _addProgramButton;
    }
}
