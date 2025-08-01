namespace Finals.Forms.Entry.UserControls
{
    partial class LoginPage
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
            MainContentArea = new Panel();
            LoginButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            ShowPasswordCheckbox = new CheckBox();
            LoginField = new TextBox();
            PasswordField = new TextBox();
            BackLink = new LinkLabel();
            MainContentArea.SuspendLayout();
            SuspendLayout();
            // 
            // MainContentArea
            // 
            MainContentArea.Controls.Add(LoginButton);
            MainContentArea.Controls.Add(label2);
            MainContentArea.Controls.Add(label3);
            MainContentArea.Controls.Add(label1);
            MainContentArea.Controls.Add(ShowPasswordCheckbox);
            MainContentArea.Controls.Add(LoginField);
            MainContentArea.Controls.Add(PasswordField);
            MainContentArea.Location = new Point(0, 32);
            MainContentArea.Name = "MainContentArea";
            MainContentArea.Size = new Size(904, 488);
            MainContentArea.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.PowderBlue;
            LoginButton.Location = new Point(328, 320);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(248, 32);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 216);
            label2.Name = "label2";
            label2.Size = new Size(280, 21);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkTurquoise;
            label3.Location = new Point(312, 80);
            label3.Name = "label3";
            label3.Size = new Size(280, 40);
            label3.TabIndex = 3;
            label3.Text = "Login";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 144);
            label1.Name = "label1";
            label1.Size = new Size(280, 21);
            label1.TabIndex = 3;
            label1.Text = "User ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowPasswordCheckbox
            // 
            ShowPasswordCheckbox.AutoSize = true;
            ShowPasswordCheckbox.ForeColor = Color.DarkCyan;
            ShowPasswordCheckbox.Location = new Point(312, 280);
            ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            ShowPasswordCheckbox.Size = new Size(108, 19);
            ShowPasswordCheckbox.TabIndex = 2;
            ShowPasswordCheckbox.Text = "Show password";
            ShowPasswordCheckbox.UseVisualStyleBackColor = true;
            ShowPasswordCheckbox.CheckedChanged += ShowPasswordCheckbox_CheckedChanged;
            // 
            // LoginField
            // 
            LoginField.CausesValidation = false;
            LoginField.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginField.Location = new Point(312, 168);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(280, 35);
            LoginField.TabIndex = 1;
            // 
            // PasswordField
            // 
            PasswordField.CausesValidation = false;
            PasswordField.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordField.Location = new Point(312, 240);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(280, 35);
            PasswordField.TabIndex = 1;
            // 
            // BackLink
            // 
            BackLink.AutoSize = true;
            BackLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLink.ForeColor = Color.DarkCyan;
            BackLink.LinkColor = Color.DarkCyan;
            BackLink.Location = new Point(8, 8);
            BackLink.Name = "BackLink";
            BackLink.Size = new Size(42, 21);
            BackLink.TabIndex = 5;
            BackLink.TabStop = true;
            BackLink.Text = "Back";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackLink);
            Controls.Add(MainContentArea);
            Name = "LoginPage";
            Size = new Size(906, 520);
            MainContentArea.ResumeLayout(false);
            MainContentArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MainContentArea;
        private LinkLabel BackLink;
        private TextBox LoginField;
        private TextBox PasswordField;
        private Label label2;
        private Label label1;
        private CheckBox ShowPasswordCheckbox;
        private Label label3;
        private Button LoginButton;
    }
}
