namespace Finals.Forms.UserControls
{
    partial class ClassTransitionUC
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new Label();
            _secondaryActionButton = new Button();
            textBox2 = new TextBox();
            _mainActionButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlLight;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(_secondaryActionButton, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(_mainActionButton, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(421, 40);
            tableLayoutPanel1.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.AutoSize = true;
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 13);
            textBox1.TabIndex = 0;
            textBox1.Text = "label1";
            // 
            // _secondaryActionButton
            // 
            _secondaryActionButton.Anchor = AnchorStyles.None;
            _secondaryActionButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _secondaryActionButton.BackColor = Color.FromArgb(229, 57, 73);
            _secondaryActionButton.FlatAppearance.BorderColor = Color.Black;
            _secondaryActionButton.FlatStyle = FlatStyle.Flat;
            _secondaryActionButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _secondaryActionButton.ForeColor = Color.White;
            _secondaryActionButton.Location = new Point(363, 5);
            _secondaryActionButton.Name = "_secondaryActionButton";
            _secondaryActionButton.Size = new Size(52, 29);
            _secondaryActionButton.TabIndex = 43;
            _secondaryActionButton.Text = "Delete";
            _secondaryActionButton.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(223, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 29);
            textBox2.TabIndex = 44;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // _mainActionButton
            // 
            _mainActionButton.Anchor = AnchorStyles.None;
            _mainActionButton.BackColor = SystemColors.Control;
            _mainActionButton.FlatStyle = FlatStyle.Flat;
            _mainActionButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _mainActionButton.ForeColor = SystemColors.ControlText;
            _mainActionButton.Location = new Point(307, 5);
            _mainActionButton.Name = "_mainActionButton";
            _mainActionButton.Size = new Size(47, 29);
            _mainActionButton.TabIndex = 9;
            _mainActionButton.Text = "Edit";
            _mainActionButton.UseVisualStyleBackColor = false;
            // 
            // ClassTransitionUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(0, 40);
            Name = "ClassTransitionUC";
            Size = new Size(421, 40);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label textBox1;
        private Button _secondaryActionButton;
        private TextBox textBox2;
        private Button _mainActionButton;
    }
}
