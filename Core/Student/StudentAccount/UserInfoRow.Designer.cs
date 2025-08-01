namespace Finals.Core.Student.StudentAccount
{
    partial class UserInfoRow
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
            _name = new Label();
            ValueField = new Label();
            EditOrSaveButton = new Button();
            EditValueTextBox = new TextBox();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // _name
            // 
            _name.AutoSize = true;
            _name.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _name.Location = new Point(16, 8);
            _name.Name = "_name";
            _name.Size = new Size(125, 30);
            _name.TabIndex = 0;
            _name.Text = "SampleData";
            // 
            // ValueField
            // 
            ValueField.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ValueField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValueField.Location = new Point(312, 8);
            ValueField.Name = "ValueField";
            ValueField.Size = new Size(500, 31);
            ValueField.TabIndex = 1;
            ValueField.Text = "Value";
            ValueField.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EditOrSaveButton
            // 
            EditOrSaveButton.Location = new Point(824, 8);
            EditOrSaveButton.Name = "EditOrSaveButton";
            EditOrSaveButton.Size = new Size(75, 32);
            EditOrSaveButton.TabIndex = 2;
            EditOrSaveButton.Text = "Edit";
            EditOrSaveButton.UseVisualStyleBackColor = true;
            // 
            // EditValueTextBox
            // 
            EditValueTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditValueTextBox.Location = new Point(304, 8);
            EditValueTextBox.Name = "EditValueTextBox";
            EditValueTextBox.Size = new Size(512, 29);
            EditValueTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(904, 8);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 32);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // UserInfoRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditValueTextBox);
            Controls.Add(CancelButton);
            Controls.Add(EditOrSaveButton);
            Controls.Add(ValueField);
            Controls.Add(_name);
            Name = "UserInfoRow";
            Size = new Size(1004, 46);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _name;
        private Label ValueField;
        private Button EditOrSaveButton;
        private TextBox EditValueTextBox;
        private Button CancelButton;
    }
}
