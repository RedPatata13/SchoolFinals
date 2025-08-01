namespace Finals.Forms.Entry.UserControls
{
    partial class RegistrationPage
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
            BackLink = new LinkLabel();
            SuspendLayout();
            // 
            // MainContentArea
            // 
            MainContentArea.AutoScroll = true;
            MainContentArea.Location = new Point(0, 32);
            MainContentArea.Name = "MainContentArea";
            MainContentArea.Size = new Size(904, 488);
            MainContentArea.TabIndex = 2;
            // 
            // BackLink
            // 
            BackLink.AutoSize = true;
            BackLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLink.LinkColor = Color.FromArgb(64, 0, 64);
            BackLink.Location = new Point(8, 8);
            BackLink.Name = "BackLink";
            BackLink.Size = new Size(42, 21);
            BackLink.TabIndex = 4;
            BackLink.TabStop = true;
            BackLink.Text = "Back";
            // 
            // RegistrationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackLink);
            Controls.Add(MainContentArea);
            Name = "RegistrationPage";
            Size = new Size(906, 520);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel MainContentArea;
        private LinkLabel BackLink;
    }
}
