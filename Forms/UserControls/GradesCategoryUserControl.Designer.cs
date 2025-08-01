namespace Finals.Forms.UserControls
{
    partial class GradesCategoryUserControl
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
            _editButton = new Button();
            _deleteButton = new Button();
            textBox2 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // _editButton
            // 
            _editButton.Anchor = AnchorStyles.None;
            _editButton.AutoSize = true;
            _editButton.BackColor = SystemColors.Control;
            _editButton.FlatStyle = FlatStyle.Flat;
            _editButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _editButton.ForeColor = SystemColors.ControlText;
            _editButton.Location = new Point(368, 7);
            _editButton.Name = "_editButton";
            _editButton.Size = new Size(47, 25);
            _editButton.TabIndex = 9;
            _editButton.Text = "Edit";
            _editButton.UseVisualStyleBackColor = false;
            // 
            // _deleteButton
            // 
            _deleteButton.Anchor = AnchorStyles.None;
            _deleteButton.AutoSize = true;
            _deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _deleteButton.BackColor = Color.FromArgb(229, 57, 73);
            _deleteButton.FlatAppearance.BorderColor = Color.Black;
            _deleteButton.FlatStyle = FlatStyle.Flat;
            _deleteButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _deleteButton.ForeColor = Color.White;
            _deleteButton.Location = new Point(424, 7);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(52, 25);
            _deleteButton.TabIndex = 43;
            _deleteButton.Text = "Delete";
            _deleteButton.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(284, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 29);
            textBox2.TabIndex = 44;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(_deleteButton, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(_editButton, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(482, 40);
            tableLayoutPanel1.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.AutoSize = true;
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 13);
            textBox1.TabIndex = 0;
            textBox1.Text = "label1";
            // 
            // GradesCategoryUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Name = "GradesCategoryUserControl";
            Size = new Size(482, 39);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button _editButton;
        private Button _deleteButton;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label textBox1;
    }
}
