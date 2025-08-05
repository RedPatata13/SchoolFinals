namespace Finals.Core.Admin.AdminCourseManagement
{
    partial class CourseCRUDDialog
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
            label4 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            SecondaryActiomButton = new Button();
            MainActionButton = new Button();
            label3 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 192);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 27;
            label4.Text = "Course Description";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(24, 208);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(792, 120);
            textBox2.TabIndex = 26;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 25;
            label1.Text = "Course Name:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(24, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(792, 29);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 28;
            label2.Text = "This field is required.";
            label2.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(SecondaryActiomButton);
            panel1.Controls.Add(MainActionButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 358);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 49);
            panel1.TabIndex = 29;
            // 
            // SecondaryActiomButton
            // 
            SecondaryActiomButton.BackColor = SystemColors.ControlLight;
            SecondaryActiomButton.FlatStyle = FlatStyle.Flat;
            SecondaryActiomButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecondaryActiomButton.ForeColor = SystemColors.ControlText;
            SecondaryActiomButton.Location = new Point(656, 8);
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
            MainActionButton.Location = new Point(744, 8);
            MainActionButton.Name = "MainActionButton";
            MainActionButton.Size = new Size(85, 37);
            MainActionButton.TabIndex = 19;
            MainActionButton.Text = "Confirm";
            MainActionButton.UseVisualStyleBackColor = false;
            MainActionButton.Click += MainActionButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(24, 152);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 31;
            label3.Text = "This field is required.";
            label3.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 104);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 30;
            label5.Text = "Units:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-- UNITS --", "1", "2", "3", "4", "5", "6" });
            comboBox1.Location = new Point(24, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(792, 29);
            comboBox1.TabIndex = 32;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(24, 328);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 33;
            label6.Text = "This field is required.";
            label6.Visible = false;
            // 
            // CourseCRUDDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 407);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CourseCRUDDialog";
            Text = "CourseCRUDDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private Label label3;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
    }
}