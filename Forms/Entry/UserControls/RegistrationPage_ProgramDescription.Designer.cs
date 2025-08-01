namespace Finals.Forms.Entry.UserControls
{
    partial class RegistrationPage_ProgramDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPage_ProgramDescription));
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 328);
            button1.Name = "button1";
            button1.Size = new Size(104, 32);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 64);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Select your program.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(281, 45);
            label1.TabIndex = 3;
            label1.Text = "Program Selection";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(744, 23);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(32, 200);
            label3.Name = "label3";
            label3.Size = new Size(856, 112);
            label3.TabIndex = 6;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(24, 120);
            label4.Name = "label4";
            label4.Size = new Size(313, 30);
            label4.TabIndex = 3;
            label4.Text = "[PLACEHOLDER] Program Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(32, 176);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 2;
            label5.Text = "Program Desription:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(128, 328);
            button2.Name = "button2";
            button2.Size = new Size(104, 32);
            button2.TabIndex = 4;
            button2.Text = "Continue";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(32, 160);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 2;
            label6.Text = "Program ID:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(104, 160);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 2;
            label7.Text = "CS110";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrationPage_ProgramDescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "RegistrationPage_ProgramDescription";
            Size = new Size(904, 488);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Label label6;
        private Label label7;
    }
}
