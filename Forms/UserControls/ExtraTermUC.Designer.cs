namespace Finals.Forms.UserControls
{
    partial class ExtraTermUC
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
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 197F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel2.Controls.Add(button4, 2, 1);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(16, 0, 16, 0);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(846, 77);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.FromArgb(229, 57, 73);
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(736, 47);
            button4.Name = "button4";
            button4.Size = new Size(85, 24);
            button4.TabIndex = 28;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = SystemColors.WindowFrame;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(736, 9);
            button3.Name = "button3";
            button3.Size = new Size(85, 24);
            button3.TabIndex = 25;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(218, 10);
            label2.Name = "label2";
            label2.Size = new Size(511, 21);
            label2.TabIndex = 16;
            label2.Text = "Semester Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 10);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 1;
            label3.Text = "Semester Name:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 48);
            label5.Name = "label5";
            label5.Size = new Size(174, 21);
            label5.TabIndex = 29;
            label5.Text = "Remove this Extra term.";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(846, 48);
            panel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 8);
            label4.Name = "label4";
            label4.Size = new Size(319, 30);
            label4.TabIndex = 1;
            label4.Text = "[Semester's Name] Configuration";
            // 
            // ExtraTermUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel4);
            MinimumSize = new Size(0, 126);
            Name = "ExtraTermUC";
            Size = new Size(846, 126);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label5;
        private Panel panel4;
        private Label label4;
    }
}
