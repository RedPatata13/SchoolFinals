namespace Finals.Forms.UserControls
{
    partial class ClassTransitionUserControlContainer
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
            panel1 = new Panel();
            label1 = new Label();
            _clearAllClick = new Button();
            _addEntryButton = new Button();
            panel2 = new Panel();
            UC_Container = new Panel();
            button1 = new Button();
            button2 = new Button();
            _ucStatus = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(_ucStatus);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(_clearAllClick);
            panel1.Controls.Add(_addEntryButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 40);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 46;
            label1.Text = "Class Transitions";
            // 
            // _clearAllClick
            // 
            _clearAllClick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _clearAllClick.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _clearAllClick.BackColor = Color.FromArgb(229, 57, 73);
            _clearAllClick.FlatAppearance.BorderColor = Color.Black;
            _clearAllClick.FlatStyle = FlatStyle.Flat;
            _clearAllClick.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _clearAllClick.ForeColor = Color.White;
            _clearAllClick.Location = new Point(384, 8);
            _clearAllClick.Name = "_clearAllClick";
            _clearAllClick.Size = new Size(68, 25);
            _clearAllClick.TabIndex = 45;
            _clearAllClick.Text = "Clear";
            _clearAllClick.UseVisualStyleBackColor = false;
            // 
            // _addEntryButton
            // 
            _addEntryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _addEntryButton.AutoSize = true;
            _addEntryButton.BackColor = SystemColors.Control;
            _addEntryButton.FlatStyle = FlatStyle.Flat;
            _addEntryButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _addEntryButton.ForeColor = SystemColors.ControlText;
            _addEntryButton.Location = new Point(320, 8);
            _addEntryButton.Name = "_addEntryButton";
            _addEntryButton.Size = new Size(56, 25);
            _addEntryButton.TabIndex = 44;
            _addEntryButton.Text = "Add";
            _addEntryButton.UseVisualStyleBackColor = false;
            _addEntryButton.Click += _addEntryButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(2, 269);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 40);
            panel2.TabIndex = 2;
            // 
            // UC_Container
            // 
            UC_Container.AutoScroll = true;
            UC_Container.BackColor = SystemColors.ControlDarkDark;
            UC_Container.BorderStyle = BorderStyle.FixedSingle;
            UC_Container.Dock = DockStyle.Fill;
            UC_Container.Location = new Point(2, 42);
            UC_Container.Name = "UC_Container";
            UC_Container.Padding = new Padding(4);
            UC_Container.Size = new Size(461, 227);
            UC_Container.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Enabled = false;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(344, 8);
            button1.Name = "button1";
            button1.Size = new Size(108, 25);
            button1.TabIndex = 47;
            button1.Text = "Confirm Changes";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = SystemColors.Control;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(280, 8);
            button2.Name = "button2";
            button2.Size = new Size(56, 25);
            button2.TabIndex = 46;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // _ucStatus
            // 
            _ucStatus.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _ucStatus.ForeColor = SystemColors.ControlDarkDark;
            _ucStatus.Location = new Point(240, 8);
            _ucStatus.Name = "_ucStatus";
            _ucStatus.Size = new Size(72, 24);
            _ucStatus.TabIndex = 48;
            _ucStatus.Text = "Viewing";
            _ucStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ClassTransitionUserControlContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(UC_Container);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(450, 122);
            Name = "ClassTransitionUserControlContainer";
            Padding = new Padding(2);
            Size = new Size(465, 311);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button _clearAllClick;
        private Button _addEntryButton;
        private Label label1;
        private Panel panel2;
        private Panel UC_Container;
        private Button button1;
        private Button button2;
        private Label _ucStatus;
    }
}
