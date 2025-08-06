namespace Finals.Core.Admin.AdminAccountsCRUD
{
    partial class UserCRUDDialog
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
            _userRole = new ComboBox();
            label5 = new Label();
            _userPassword = new TextBox();
            label4 = new Label();
            _userEmail = new TextBox();
            label3 = new Label();
            _userName = new TextBox();
            label2 = new Label();
            _uid = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(SecondaryActiomButton);
            panel1.Controls.Add(MainActionButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 458);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 49);
            panel1.TabIndex = 30;
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
            SecondaryActiomButton.Click += SecondaryActionButton_Click;
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
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(_userRole);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(_userPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(_userEmail);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(_userName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(_uid);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(836, 458);
            panel2.TabIndex = 31;
            // 
            // _userRole
            // 
            _userRole.DropDownStyle = ComboBoxStyle.DropDownList;
            _userRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _userRole.FormattingEnabled = true;
            _userRole.Items.AddRange(new object[] { "-- USER ROLE --", "Student", "Teacher", "Admin " });
            _userRole.Location = new Point(136, 271);
            _userRole.Name = "_userRole";
            _userRole.Size = new Size(272, 29);
            _userRole.TabIndex = 10;
            _userRole.TextChanged += Role_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 279);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 9;
            label5.Text = "Role:";
            // 
            // _userPassword
            // 
            _userPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _userPassword.Location = new Point(136, 215);
            _userPassword.Name = "_userPassword";
            _userPassword.Size = new Size(624, 29);
            _userPassword.TabIndex = 8;
            _userPassword.TextChanged += Password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 223);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 7;
            label4.Text = "Password:";
            // 
            // _userEmail
            // 
            _userEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _userEmail.Location = new Point(136, 159);
            _userEmail.Name = "_userEmail";
            _userEmail.Size = new Size(624, 29);
            _userEmail.TabIndex = 6;
            _userEmail.TextChanged += Email_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 167);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // _userName
            // 
            _userName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _userName.Location = new Point(136, 103);
            _userName.Name = "_userName";
            _userName.Size = new Size(624, 29);
            _userName.TabIndex = 4;
            _userName.TextChanged += Username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 111);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 3;
            label2.Text = "Username: ";
            // 
            // _uid
            // 
            _uid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _uid.Location = new Point(136, 47);
            _uid.Name = "_uid";
            _uid.Size = new Size(624, 29);
            _uid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 55);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 1;
            label1.Text = "User ID:";
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 736);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 34);
            panel3.TabIndex = 0;
            // 
            // UserCRUDDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 507);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserCRUDDialog";
            Text = "UserCRUDDialog";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button SecondaryActiomButton;
        private Button MainActionButton;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox _uid;
        private TextBox _userName;
        private Label label2;
        private TextBox _userEmail;
        private Label label3;
        private TextBox _userPassword;
        private Label label4;
        private Label label5;
        private ComboBox _userRole;
    }
}