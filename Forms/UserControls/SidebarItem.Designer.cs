namespace Finals.Forms.UserControls
{
    partial class SidebarItem
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
            SidebarTitle = new Label();
            Highlight = new Panel();
            SuspendLayout();
            // 
            // SidebarTitle
            // 
            SidebarTitle.AutoSize = true;
            SidebarTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SidebarTitle.ForeColor = SystemColors.WindowFrame;
            SidebarTitle.Location = new Point(24, 0);
            SidebarTitle.Name = "SidebarTitle";
            SidebarTitle.Size = new Size(103, 21);
            SidebarTitle.TabIndex = 3;
            SidebarTitle.Text = "SidebarItem1";
            SidebarTitle.Click += SidebarTitle_Click;
            // 
            // Highlight
            // 
            Highlight.BackColor = SystemColors.Highlight;
            Highlight.Location = new Point(8, 0);
            Highlight.Name = "Highlight";
            Highlight.Size = new Size(4, 24);
            Highlight.TabIndex = 4;
            Highlight.Visible = false;
            // 
            // SidebarItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Highlight);
            Controls.Add(SidebarTitle);
            Name = "SidebarItem";
            Size = new Size(260, 21);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label SidebarTitle;
        private Panel Highlight;
    }
}
