
namespace Finals.Forms
{
    partial class InterfaceFrameForm
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
            label7 = new Label();
            label6 = new Label();
            GapSpacer = new Panel();
            SidebarMain = new FlowLayoutPanel();
            SidebarArea = new Panel();
            panel1 = new Panel();
            MainArea = new Panel();
            ContentArea = new Panel();
            MainContentArea = new Panel();
            Nav = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            FeatureDescription = new Label();
            FeatureName = new Label();
            button1 = new Button();
            SidebarArea.SuspendLayout();
            panel1.SuspendLayout();
            MainArea.SuspendLayout();
            ContentArea.SuspendLayout();
            Nav.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(10, 40);
            label7.Name = "label7";
            label7.Size = new Size(40, 13);
            label7.TabIndex = 1;
            label7.Text = "Admin";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(8, 16);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 1;
            label6.Text = "RootAdmin";
            label6.Visible = false;
            // 
            // GapSpacer
            // 
            GapSpacer.BackColor = Color.FromArgb(54, 69, 79);
            GapSpacer.Dock = DockStyle.Top;
            GapSpacer.Location = new Point(0, 48);
            GapSpacer.Name = "GapSpacer";
            GapSpacer.Size = new Size(288, 48);
            GapSpacer.TabIndex = 5;
            // 
            // SidebarMain
            // 
            SidebarMain.BackColor = Color.FromArgb(54, 69, 79);
            SidebarMain.Dock = DockStyle.Fill;
            SidebarMain.Location = new Point(0, 96);
            SidebarMain.Name = "SidebarMain";
            SidebarMain.Size = new Size(288, 585);
            SidebarMain.TabIndex = 6;
            SidebarMain.Paint += SidebarMain_Paint;
            // 
            // SidebarArea
            // 
            SidebarArea.Controls.Add(SidebarMain);
            SidebarArea.Controls.Add(GapSpacer);
            SidebarArea.Controls.Add(panel1);
            SidebarArea.Dock = DockStyle.Left;
            SidebarArea.Location = new Point(0, 0);
            SidebarArea.Name = "SidebarArea";
            SidebarArea.Size = new Size(288, 681);
            SidebarArea.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 69, 79);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 48);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // MainArea
            // 
            MainArea.AutoScroll = true;
            MainArea.BackColor = SystemColors.Control;
            MainArea.Controls.Add(ContentArea);
            MainArea.Dock = DockStyle.Fill;
            MainArea.Location = new Point(288, 0);
            MainArea.Name = "MainArea";
            MainArea.Size = new Size(1616, 681);
            MainArea.TabIndex = 6;
            MainArea.Paint += MainArea_Paint;
            // 
            // ContentArea
            // 
            ContentArea.AutoSize = true;
            ContentArea.BackColor = SystemColors.AppWorkspace;
            ContentArea.Controls.Add(MainContentArea);
            ContentArea.Controls.Add(Nav);
            ContentArea.Location = new Point(224, 0);
            ContentArea.Name = "ContentArea";
            ContentArea.Size = new Size(1083, 872);
            ContentArea.TabIndex = 0;
            // 
            // MainContentArea
            // 
            MainContentArea.AutoSize = true;
            MainContentArea.BackColor = SystemColors.Control;
            MainContentArea.Dock = DockStyle.Fill;
            MainContentArea.Location = new Point(0, 120);
            MainContentArea.Name = "MainContentArea";
            MainContentArea.Padding = new Padding(20, 0, 0, 0);
            MainContentArea.Size = new Size(1083, 752);
            MainContentArea.TabIndex = 5;
            // 
            // Nav
            // 
            Nav.Controls.Add(tableLayoutPanel1);
            Nav.Dock = DockStyle.Top;
            Nav.Location = new Point(0, 0);
            Nav.Name = "Nav";
            Nav.Size = new Size(1083, 120);
            Nav.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.4916F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.508404F));
            tableLayoutPanel1.Controls.Add(FeatureDescription, 0, 2);
            tableLayoutPanel1.Controls.Add(FeatureName, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(1083, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // FeatureDescription
            // 
            FeatureDescription.AutoSize = true;
            FeatureDescription.Location = new Point(8, 87);
            FeatureDescription.Margin = new Padding(8);
            FeatureDescription.Name = "FeatureDescription";
            FeatureDescription.Size = new Size(150, 15);
            FeatureDescription.TabIndex = 2;
            FeatureDescription.Text = "lorem ipsum dolor sit amet";
            // 
            // FeatureName
            // 
            FeatureName.AutoSize = true;
            FeatureName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeatureName.Location = new Point(3, 39);
            FeatureName.Name = "FeatureName";
            FeatureName.Size = new Size(214, 40);
            FeatureName.TabIndex = 0;
            FeatureName.Text = "Feature name";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1005, 51);
            button1.Margin = new Padding(3, 12, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InterfaceFrameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 681);
            Controls.Add(MainArea);
            Controls.Add(SidebarArea);
            Name = "InterfaceFrameForm";
            Text = "InterfaceFrameForm";
            WindowState = FormWindowState.Maximized;
            Load += InterfaceFrameForm_Load;
            SidebarArea.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            MainArea.ResumeLayout(false);
            MainArea.PerformLayout();
            ContentArea.ResumeLayout(false);
            ContentArea.PerformLayout();
            Nav.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void SidebarMain_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void AccountArea_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Panel GapSpacer;
        private FlowLayoutPanel SidebarMain;
        private Panel SidebarArea;
        private Panel panel1;
        private Panel MainArea;
        private Panel ContentArea;
        private Panel MainContentArea;
        private Panel Nav;
        private Label FeatureName;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Label FeatureDescription;
    }
}