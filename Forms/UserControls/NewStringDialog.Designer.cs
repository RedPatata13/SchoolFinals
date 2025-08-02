namespace Finals.Forms.UserControls
{
    partial class NewStringDialog
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
            textBox1 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            SecondaryActiomButton = new Button();
            button2 = new Button();
            MainActionButton = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(24, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 29);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SecondaryActiomButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(MainActionButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 240);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 46);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(336, 8);
            button1.Name = "button1";
            button1.Size = new Size(85, 29);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SecondaryActiomButton
            // 
            SecondaryActiomButton.BackColor = SystemColors.ControlLight;
            SecondaryActiomButton.FlatStyle = FlatStyle.Flat;
            SecondaryActiomButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecondaryActiomButton.ForeColor = SystemColors.ControlText;
            SecondaryActiomButton.Location = new Point(536, 8);
            SecondaryActiomButton.Name = "SecondaryActiomButton";
            SecondaryActiomButton.Size = new Size(85, 29);
            SecondaryActiomButton.TabIndex = 9;
            SecondaryActiomButton.Text = "Cancel";
            SecondaryActiomButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ScrollBar;
            button2.Location = new Point(424, 8);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 10;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MainActionButton
            // 
            MainActionButton.BackColor = SystemColors.Highlight;
            MainActionButton.FlatStyle = FlatStyle.Flat;
            MainActionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainActionButton.ForeColor = SystemColors.HighlightText;
            MainActionButton.Location = new Point(624, 8);
            MainActionButton.Name = "MainActionButton";
            MainActionButton.Size = new Size(85, 29);
            MainActionButton.TabIndex = 8;
            MainActionButton.Text = "Confirm";
            MainActionButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 96);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Enter Value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(24, 144);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 6;
            label2.Text = "This field is required.";
            label2.Visible = false;
            // 
            // NewStringDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 286);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewStringDialog";
            Text = "NewStringDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}