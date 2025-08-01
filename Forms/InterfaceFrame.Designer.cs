namespace Finals.Forms
{
    partial class InterfaceFrame
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
            SidebarArea = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            AccountArea = new Panel();
            MainArea = new Panel();
            MainContentArea = new Panel();
            DirectoryArea = new Panel();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            Nav = new Panel();
            FeatureDescription = new Label();
            FeatureName = new Label();
            GapSpacer = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            SidebarArea.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainArea.SuspendLayout();
            DirectoryArea.SuspendLayout();
            Nav.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // SidebarArea
            // 
            SidebarArea.Controls.Add(flowLayoutPanel1);
            SidebarArea.Controls.Add(GapSpacer);
            SidebarArea.Controls.Add(panel1);
            SidebarArea.Controls.Add(AccountArea);
            SidebarArea.Dock = DockStyle.Left;
            SidebarArea.Location = new Point(0, 0);
            SidebarArea.Name = "SidebarArea";
            SidebarArea.Size = new Size(264, 720);
            SidebarArea.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 56);
            panel1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 32);
            label7.Name = "label7";
            label7.Size = new Size(56, 13);
            label7.TabIndex = 1;
            label7.Text = "User Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(56, 8);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 1;
            label6.Text = "UserName";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AccountArea
            // 
            AccountArea.Dock = DockStyle.Top;
            AccountArea.Location = new Point(0, 0);
            AccountArea.Name = "AccountArea";
            AccountArea.Size = new Size(264, 56);
            AccountArea.TabIndex = 4;
            // 
            // MainArea
            // 
            MainArea.Controls.Add(MainContentArea);
            MainArea.Controls.Add(DirectoryArea);
            MainArea.Controls.Add(Nav);
            MainArea.Dock = DockStyle.Fill;
            MainArea.Location = new Point(264, 0);
            MainArea.Name = "MainArea";
            MainArea.Size = new Size(1016, 720);
            MainArea.TabIndex = 1;
            // 
            // MainContentArea
            // 
            MainContentArea.Dock = DockStyle.Fill;
            MainContentArea.Location = new Point(0, 112);
            MainContentArea.Name = "MainContentArea";
            MainContentArea.Size = new Size(1016, 608);
            MainContentArea.TabIndex = 2;
            // 
            // DirectoryArea
            // 
            DirectoryArea.Controls.Add(label4);
            DirectoryArea.Controls.Add(label5);
            DirectoryArea.Controls.Add(label3);
            DirectoryArea.Dock = DockStyle.Top;
            DirectoryArea.Location = new Point(0, 80);
            DirectoryArea.Name = "DirectoryArea";
            DirectoryArea.Size = new Size(1016, 32);
            DirectoryArea.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 8);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 0;
            label4.Text = "/";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(88, 8);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 0;
            label5.Text = "CurrPage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(16, 8);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "PrevPage";
            // 
            // Nav
            // 
            Nav.Controls.Add(FeatureDescription);
            Nav.Controls.Add(FeatureName);
            Nav.Dock = DockStyle.Top;
            Nav.Location = new Point(0, 0);
            Nav.Name = "Nav";
            Nav.Size = new Size(1016, 80);
            Nav.TabIndex = 0;
            // 
            // FeatureDescription
            // 
            FeatureDescription.AutoSize = true;
            FeatureDescription.Location = new Point(16, 56);
            FeatureDescription.Name = "FeatureDescription";
            FeatureDescription.Size = new Size(150, 15);
            FeatureDescription.TabIndex = 1;
            FeatureDescription.Text = "lorem ipsum dolor sit amet";
            // 
            // FeatureName
            // 
            FeatureName.AutoSize = true;
            FeatureName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeatureName.Location = new Point(8, 8);
            FeatureName.Name = "FeatureName";
            FeatureName.Size = new Size(214, 45);
            FeatureName.TabIndex = 0;
            FeatureName.Text = "Feature name";
            // 
            // GapSpacer
            // 
            GapSpacer.Dock = DockStyle.Top;
            GapSpacer.Location = new Point(0, 112);
            GapSpacer.Name = "GapSpacer";
            GapSpacer.Size = new Size(264, 16);
            GapSpacer.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 128);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(264, 592);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8);
            panel2.Size = new Size(261, 50);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(8, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 14);
            label8.Name = "label8";
            label8.Size = new Size(103, 21);
            label8.TabIndex = 1;
            label8.Text = "SidebarItem1";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(3, 59);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(8);
            panel4.Size = new Size(261, 50);
            panel4.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(8, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(48, 14);
            label10.Name = "label10";
            label10.Size = new Size(103, 21);
            label10.TabIndex = 1;
            label10.Text = "SidebarItem3";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(3, 115);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(8);
            panel3.Size = new Size(261, 50);
            panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(8, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(48, 14);
            label9.Name = "label9";
            label9.Size = new Size(103, 21);
            label9.TabIndex = 1;
            label9.Text = "SidebarItem2";
            // 
            // InterfaceFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainArea);
            Controls.Add(SidebarArea);
            Name = "InterfaceFrame";
            Size = new Size(1280, 720);
            SidebarArea.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainArea.ResumeLayout(false);
            DirectoryArea.ResumeLayout(false);
            DirectoryArea.PerformLayout();
            Nav.ResumeLayout(false);
            Nav.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidebarArea;
        private Panel AccountArea;
        private Panel MainArea;
        private Panel Nav;
        private Panel DirectoryArea;
        private Panel MainContentArea;
        private Panel panel1;
        private Label FeatureName;
        private Label FeatureDescription;
        private Label label4;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Panel GapSpacer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label8;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label10;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label9;
    }
}
