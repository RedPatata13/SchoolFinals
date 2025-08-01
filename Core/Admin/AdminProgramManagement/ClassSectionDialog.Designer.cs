namespace Finals.Core.Admin.AdminProgramManagement
{
    partial class ClassSectionDialog
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
            panel1 = new Panel();
            SecondaryActiomButton = new Button();
            MainActionButton = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            _createClassButton = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(SecondaryActiomButton);
            panel1.Controls.Add(MainActionButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 624);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 49);
            panel1.TabIndex = 19;
            // 
            // SecondaryActiomButton
            // 
            SecondaryActiomButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SecondaryActiomButton.BackColor = SystemColors.ControlLight;
            SecondaryActiomButton.FlatStyle = FlatStyle.Flat;
            SecondaryActiomButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecondaryActiomButton.ForeColor = SystemColors.ControlText;
            SecondaryActiomButton.Location = new Point(896, 8);
            SecondaryActiomButton.Name = "SecondaryActiomButton";
            SecondaryActiomButton.Size = new Size(85, 37);
            SecondaryActiomButton.TabIndex = 20;
            SecondaryActiomButton.Text = "Cancel";
            SecondaryActiomButton.UseVisualStyleBackColor = false;
            SecondaryActiomButton.Click += SecondaryActiomButton_Click;
            // 
            // MainActionButton
            // 
            MainActionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MainActionButton.BackColor = SystemColors.Menu;
            MainActionButton.Enabled = false;
            MainActionButton.FlatStyle = FlatStyle.Flat;
            MainActionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainActionButton.ForeColor = SystemColors.ScrollBar;
            MainActionButton.Location = new Point(984, 8);
            MainActionButton.Name = "MainActionButton";
            MainActionButton.Size = new Size(85, 37);
            MainActionButton.TabIndex = 19;
            MainActionButton.Text = "Confirm";
            MainActionButton.UseVisualStyleBackColor = false;
            MainActionButton.Click += MainActionButton_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 616);
            panel2.Name = "panel2";
            panel2.Size = new Size(1081, 8);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 576);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(12, 0, 12, 0);
            panel3.Size = new Size(1081, 40);
            panel3.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Controls.Add(tabControl1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(8);
            panel4.Size = new Size(1081, 576);
            panel4.TabIndex = 22;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(8, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1065, 560);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(_createClassButton);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1057, 532);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create a Class";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(24, 368);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 30;
            label5.Text = "Status: ";
            label5.Visible = false;
            // 
            // _createClassButton
            // 
            _createClassButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _createClassButton.AutoSize = true;
            _createClassButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _createClassButton.BackColor = SystemColors.Menu;
            _createClassButton.Enabled = false;
            _createClassButton.FlatStyle = FlatStyle.Flat;
            _createClassButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _createClassButton.ForeColor = SystemColors.ScrollBar;
            _createClassButton.Location = new Point(22, 310);
            _createClassButton.Name = "_createClassButton";
            _createClassButton.Size = new Size(81, 25);
            _createClassButton.TabIndex = 29;
            _createClassButton.Text = "Create Class";
            _createClassButton.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-- Select Year --", "1st", "2nd", "3rd", "4th", "5th" });
            comboBox1.Location = new Point(24, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(493, 29);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(80, 368);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 27;
            label3.Text = "Class Successfully Created";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 248);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 26;
            label4.Text = "Year Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(24, 208);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 24;
            label2.Text = "This field is required.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 160);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 23;
            label1.Text = "Class Name:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(21, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(496, 29);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1057, 532);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Existing Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(12, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1057, 40);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ClassSectionDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1081, 673);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ClassSectionDialog";
            Text = "Select a Class";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TabPage tabPage2;
        private Button _createClassButton;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}