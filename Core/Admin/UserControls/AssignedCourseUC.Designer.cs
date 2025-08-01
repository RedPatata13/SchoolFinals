namespace Finals.Core.Admin.UserControls
{
    partial class AssignedCourseUC
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
            panel1 = new Panel();
            _addButton = new Button();
            _removeButton = new Button();
            label1 = new Label();
            panel3 = new Panel();
            _unitsRequired = new Label();
            label4 = new Label();
            _totalUnits = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(_addButton);
            panel1.Controls.Add(_removeButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 48);
            panel1.TabIndex = 12;
            // 
            // _addButton
            // 
            _addButton.BackColor = SystemColors.Control;
            _addButton.FlatStyle = FlatStyle.Flat;
            _addButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _addButton.ForeColor = SystemColors.ControlText;
            _addButton.Location = new Point(400, 8);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(85, 32);
            _addButton.TabIndex = 10;
            _addButton.Text = "Add";
            _addButton.UseVisualStyleBackColor = false;
            // 
            // _removeButton
            // 
            _removeButton.BackColor = Color.FromArgb(229, 57, 73);
            _removeButton.FlatStyle = FlatStyle.Flat;
            _removeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _removeButton.ForeColor = SystemColors.HighlightText;
            _removeButton.Location = new Point(488, 8);
            _removeButton.Name = "_removeButton";
            _removeButton.Size = new Size(85, 32);
            _removeButton.TabIndex = 9;
            _removeButton.Text = "Remove";
            _removeButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 8;
            label1.Text = "Courses";
            // 
            // panel3
            // 
            panel3.Controls.Add(_unitsRequired);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(_totalUnits);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 288);
            panel3.Name = "panel3";
            panel3.Size = new Size(583, 65);
            panel3.TabIndex = 14;
            // 
            // _unitsRequired
            // 
            _unitsRequired.AutoSize = true;
            _unitsRequired.Font = new Font("Segoe UI", 12F);
            _unitsRequired.Location = new Point(192, 32);
            _unitsRequired.Name = "_unitsRequired";
            _unitsRequired.Size = new Size(19, 21);
            _unitsRequired.TabIndex = 15;
            _unitsRequired.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(16, 32);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 14;
            label4.Text = "Units Required:";
            // 
            // _totalUnits
            // 
            _totalUnits.AutoSize = true;
            _totalUnits.Font = new Font("Segoe UI", 12F);
            _totalUnits.Location = new Point(192, 8);
            _totalUnits.Name = "_totalUnits";
            _totalUnits.Size = new Size(19, 21);
            _totalUnits.TabIndex = 13;
            _totalUnits.Text = "5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 12;
            label2.Text = "Total Units:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12, 0, 12, 0);
            panel2.Size = new Size(583, 240);
            panel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(12, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(559, 240);
            dataGridView1.TabIndex = 2;
            // 
            // AssignedCourseUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "AssignedCourseUC";
            Size = new Size(583, 353);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button _addButton;
        private Button _removeButton;
        private Label label1;
        private Panel panel3;
        private Label _unitsRequired;
        private Label label4;
        private Label _totalUnits;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridView1;
    }
}
