namespace Finals.Forms.Entry.UserControls
{
    partial class EntryHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryHome));
            pictureBox2 = new PictureBox();
            label4 = new Label();
            LoginPanel = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            RegistrationPanel = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            RegistrationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.yx;
            pictureBox2.Location = new Point(8, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 8);
            label4.Name = "label4";
            label4.Size = new Size(523, 45);
            label4.TabIndex = 4;
            label4.Text = "AIDE - School Management System";
            // 
            // LoginPanel
            // 
            LoginPanel.BorderStyle = BorderStyle.FixedSingle;
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(pictureBox1);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Location = new Point(240, 184);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Padding = new Padding(4);
            LoginPanel.Size = new Size(408, 72);
            LoginPanel.TabIndex = 6;
            LoginPanel.MouseEnter += LoginPanel_MouseEnter;
            LoginPanel.MouseLeave += LoginPanel_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 12);
            label3.Name = "label3";
            label3.Size = new Size(84, 37);
            label3.TabIndex = 3;
            label3.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 52);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 1;
            label1.Text = "Login to an existing account.";
            // 
            // RegistrationPanel
            // 
            RegistrationPanel.BorderStyle = BorderStyle.FixedSingle;
            RegistrationPanel.Controls.Add(label5);
            RegistrationPanel.Controls.Add(pictureBox3);
            RegistrationPanel.Controls.Add(label2);
            RegistrationPanel.Location = new Point(240, 264);
            RegistrationPanel.Name = "RegistrationPanel";
            RegistrationPanel.Padding = new Padding(4);
            RegistrationPanel.Size = new Size(408, 72);
            RegistrationPanel.TabIndex = 7;
            RegistrationPanel.MouseEnter += RegistrationPanel_MouseEnter;
            RegistrationPanel.MouseLeave += RegistrationPanel_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 12);
            label5.Name = "label5";
            label5.Size = new Size(159, 37);
            label5.TabIndex = 3;
            label5.Text = "Registration";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 52);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 1;
            label2.Text = "Register for a program.";
            // 
            // EntryHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(LoginPanel);
            Controls.Add(RegistrationPanel);
            Name = "EntryHome";
            Size = new Size(906, 520);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            RegistrationPanel.ResumeLayout(false);
            RegistrationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label4;
        private Panel LoginPanel;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel RegistrationPanel;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label2;
    }
}
