namespace Finals.Core.Admin
{
    partial class AdminClassSectionDetails
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
            panel2 = new Panel();
            BackButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(BackButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 32);
            panel2.TabIndex = 33;
            // 
            // BackButton
            // 
            BackButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackButton.BackColor = SystemColors.Control;
            BackButton.FlatAppearance.BorderColor = Color.Black;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.ControlText;
            BackButton.Location = new Point(0, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(64, 24);
            BackButton.TabIndex = 31;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // AdminClassSectionDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "AdminClassSectionDetails";
            Size = new Size(1059, 707);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button BackButton;
    }
}
