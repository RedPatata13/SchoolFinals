namespace Finals.Core.Admin.AdminProgramManagement
{
    partial class AdminProgramDetails
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
            Forms.UserControls.HoverEffect hoverEffect1 = new Forms.UserControls.HoverEffect();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProgramDetails));
            Forms.UserControls.HoverEffect hoverEffect2 = new Forms.UserControls.HoverEffect();
            Forms.UserControls.HoverEffect hoverEffect3 = new Forms.UserControls.HoverEffect();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BackButton = new Button();
            panel2 = new Panel();
            ProgramTitleLabel = new Label();
            panel1 = new Panel();
            coursePanel1 = new Teacher.UserControls.CoursePanel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            _progDetails_Status = new Label();
            label3 = new Label();
            _editStatusButton = new Button();
            _editProgramName = new Button();
            label12 = new Label();
            _progDetailsProgramTitle = new Label();
            _progDetails_CreatedBy = new Label();
            _progDetails_DateCreated = new Label();
            label2 = new Label();
            label5 = new Label();
            _progDetails_LastEditor = new Label();
            label20 = new Label();
            button7 = new Button();
            coursePanel2 = new Teacher.UserControls.CoursePanel();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            _editDescriptionButton = new Button();
            label1 = new Label();
            _progDetails_Description = new Label();
            coursePanel3 = new Teacher.UserControls.CoursePanel();
            panel7 = new Panel();
            panel8 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            _dgv = new DataGridView();
            ClassName = new DataGridViewTextBoxColumn();
            ClassID = new DataGridViewTextBoxColumn();
            ClassYearLevel = new DataGridViewTextBoxColumn();
            ClassCount = new DataGridViewTextBoxColumn();
            ClassDetails = new DataGridViewButtonColumn();
            _addSectionToProgramButton = new Button();
            CourseTemplatesContainer = new TabPage();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            SuspendLayout();
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
            // panel2
            // 
            panel2.Controls.Add(BackButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 32);
            panel2.TabIndex = 32;
            // 
            // ProgramTitleLabel
            // 
            ProgramTitleLabel.Dock = DockStyle.Fill;
            ProgramTitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProgramTitleLabel.ForeColor = SystemColors.HighlightText;
            ProgramTitleLabel.Location = new Point(24, 24);
            ProgramTitleLabel.Name = "ProgramTitleLabel";
            ProgramTitleLabel.Size = new Size(1009, 206);
            ProgramTitleLabel.TabIndex = 0;
            ProgramTitleLabel.Text = "Program Title";
            ProgramTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ProgramTitleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(24);
            panel1.Size = new Size(1059, 256);
            panel1.TabIndex = 33;
            // 
            // coursePanel1
            // 
            hoverEffect1.MouseEnter = SystemColors.ControlLight;
            hoverEffect1.PrevColor = SystemColors.ActiveBorder;
            coursePanel1.DefaultHoverEffects = hoverEffect1;
            coursePanel1.IsOngoing = false;
            coursePanel1.Location = new Point(0, 0);
            coursePanel1.Name = "coursePanel1";
            coursePanel1.Padding = new Padding(1);
            coursePanel1.Size = new Size(785, 150);
            coursePanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 288);
            panel3.Name = "panel3";
            panel3.Size = new Size(1059, 8);
            panel3.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 296);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 8, 0, 8);
            panel4.Size = new Size(1059, 200);
            panel4.TabIndex = 35;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.82249F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.1775055F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel2.Controls.Add(_progDetails_Status, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(_editStatusButton, 2, 1);
            tableLayoutPanel2.Controls.Add(_editProgramName, 2, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 0);
            tableLayoutPanel2.Controls.Add(_progDetailsProgramTitle, 1, 0);
            tableLayoutPanel2.Controls.Add(_progDetails_CreatedBy, 1, 3);
            tableLayoutPanel2.Controls.Add(_progDetails_DateCreated, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(_progDetails_LastEditor, 1, 5);
            tableLayoutPanel2.Controls.Add(label20, 0, 5);
            tableLayoutPanel2.Controls.Add(button7, 2, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 8);
            tableLayoutPanel2.Margin = new Padding(3, 3, 3, 100);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(1059, 184);
            tableLayoutPanel2.TabIndex = 35;
            // 
            // _progDetails_Status
            // 
            _progDetails_Status.Anchor = AnchorStyles.Left;
            _progDetails_Status.AutoSize = true;
            _progDetails_Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _progDetails_Status.ForeColor = SystemColors.ControlDarkDark;
            _progDetails_Status.Location = new Point(224, 36);
            _progDetails_Status.Name = "_progDetails_Status";
            _progDetails_Status.Size = new Size(48, 21);
            _progDetails_Status.TabIndex = 32;
            _progDetails_Status.Text = "Open";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 36);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 31;
            label3.Text = "Status";
            // 
            // _editStatusButton
            // 
            _editStatusButton.Anchor = AnchorStyles.Left;
            _editStatusButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _editStatusButton.BackColor = SystemColors.WindowFrame;
            _editStatusButton.FlatAppearance.BorderColor = Color.Black;
            _editStatusButton.FlatStyle = FlatStyle.Flat;
            _editStatusButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _editStatusButton.ForeColor = Color.White;
            _editStatusButton.Location = new Point(968, 35);
            _editStatusButton.Name = "_editStatusButton";
            _editStatusButton.Size = new Size(85, 24);
            _editStatusButton.TabIndex = 25;
            _editStatusButton.Text = "Edit";
            _editStatusButton.UseVisualStyleBackColor = false;
            // 
            // _editProgramName
            // 
            _editProgramName.Anchor = AnchorStyles.Left;
            _editProgramName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _editProgramName.BackColor = SystemColors.WindowFrame;
            _editProgramName.FlatAppearance.BorderColor = Color.Black;
            _editProgramName.FlatStyle = FlatStyle.Flat;
            _editProgramName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _editProgramName.ForeColor = Color.White;
            _editProgramName.Location = new Point(968, 4);
            _editProgramName.Name = "_editProgramName";
            _editProgramName.Size = new Size(85, 24);
            _editProgramName.TabIndex = 24;
            _editProgramName.Text = "Edit";
            _editProgramName.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(4, 5);
            label12.Name = "label12";
            label12.Size = new Size(117, 21);
            label12.TabIndex = 0;
            label12.Text = "Program Name";
            // 
            // _progDetailsProgramTitle
            // 
            _progDetailsProgramTitle.Anchor = AnchorStyles.Left;
            _progDetailsProgramTitle.AutoSize = true;
            _progDetailsProgramTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _progDetailsProgramTitle.ForeColor = SystemColors.ControlDarkDark;
            _progDetailsProgramTitle.Location = new Point(224, 5);
            _progDetailsProgramTitle.Name = "_progDetailsProgramTitle";
            _progDetailsProgramTitle.Size = new Size(202, 21);
            _progDetailsProgramTitle.TabIndex = 1;
            _progDetailsProgramTitle.Text = "Placeholder Program Name";
            // 
            // _progDetails_CreatedBy
            // 
            _progDetails_CreatedBy.Anchor = AnchorStyles.Left;
            _progDetails_CreatedBy.AutoSize = true;
            _progDetails_CreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _progDetails_CreatedBy.ForeColor = SystemColors.ControlDarkDark;
            _progDetails_CreatedBy.Location = new Point(224, 98);
            _progDetails_CreatedBy.Name = "_progDetails_CreatedBy";
            _progDetails_CreatedBy.Size = new Size(44, 21);
            _progDetails_CreatedBy.TabIndex = 12;
            _progDetails_CreatedBy.Text = "Desk";
            // 
            // _progDetails_DateCreated
            // 
            _progDetails_DateCreated.Anchor = AnchorStyles.Left;
            _progDetails_DateCreated.AutoSize = true;
            _progDetails_DateCreated.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _progDetails_DateCreated.ForeColor = SystemColors.ControlDarkDark;
            _progDetails_DateCreated.Location = new Point(224, 67);
            _progDetails_DateCreated.Name = "_progDetails_DateCreated";
            _progDetails_DateCreated.Size = new Size(76, 21);
            _progDetails_DateCreated.TabIndex = 6;
            _progDetails_DateCreated.Text = "12/12/25";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 67);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 30;
            label2.Text = "Date Created";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 98);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 33;
            label5.Text = "Created By";
            // 
            // _progDetails_LastEditor
            // 
            _progDetails_LastEditor.Anchor = AnchorStyles.Left;
            _progDetails_LastEditor.AutoSize = true;
            _progDetails_LastEditor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _progDetails_LastEditor.ForeColor = SystemColors.ControlDarkDark;
            _progDetails_LastEditor.Location = new Point(224, 154);
            _progDetails_LastEditor.Name = "_progDetails_LastEditor";
            _progDetails_LastEditor.Size = new Size(44, 21);
            _progDetails_LastEditor.TabIndex = 38;
            _progDetails_LastEditor.Text = "Desk";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(4, 154);
            label20.Name = "label20";
            label20.Size = new Size(106, 21);
            label20.TabIndex = 37;
            label20.Text = "Last Edited By";
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left;
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = SystemColors.ControlLightLight;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(968, 150);
            button7.Name = "button7";
            button7.Size = new Size(85, 28);
            button7.TabIndex = 29;
            button7.Text = "Audit Log";
            button7.UseVisualStyleBackColor = false;
            // 
            // coursePanel2
            // 
            hoverEffect2.MouseEnter = SystemColors.ControlLight;
            hoverEffect2.PrevColor = SystemColors.ActiveBorder;
            coursePanel2.DefaultHoverEffects = hoverEffect2;
            coursePanel2.IsOngoing = false;
            coursePanel2.Location = new Point(0, 0);
            coursePanel2.Name = "coursePanel2";
            coursePanel2.Padding = new Padding(1);
            coursePanel2.Size = new Size(785, 150);
            coursePanel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 1210);
            panel5.Name = "panel5";
            panel5.Size = new Size(1059, 19);
            panel5.TabIndex = 36;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(tableLayoutPanel1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 496);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 0, 0, 8);
            panel6.Size = new Size(1059, 152);
            panel6.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(_progDetails_Description, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1057, 142);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel3.Controls.Add(_editDescriptionButton, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Size = new Size(1051, 34);
            tableLayoutPanel3.TabIndex = 39;
            // 
            // _editDescriptionButton
            // 
            _editDescriptionButton.Anchor = AnchorStyles.Left;
            _editDescriptionButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _editDescriptionButton.BackColor = SystemColors.WindowFrame;
            _editDescriptionButton.FlatAppearance.BorderColor = Color.Black;
            _editDescriptionButton.FlatStyle = FlatStyle.Flat;
            _editDescriptionButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _editDescriptionButton.ForeColor = Color.White;
            _editDescriptionButton.Location = new Point(962, 5);
            _editDescriptionButton.Name = "_editDescriptionButton";
            _editDescriptionButton.Size = new Size(85, 24);
            _editDescriptionButton.TabIndex = 39;
            _editDescriptionButton.Text = "Edit";
            _editDescriptionButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 38;
            label1.Text = "Program Description:";
            // 
            // _progDetails_Description
            // 
            _progDetails_Description.Dock = DockStyle.Fill;
            _progDetails_Description.Location = new Point(3, 40);
            _progDetails_Description.Name = "_progDetails_Description";
            _progDetails_Description.Padding = new Padding(8, 8, 4, 8);
            _progDetails_Description.Size = new Size(1051, 102);
            _progDetails_Description.TabIndex = 40;
            _progDetails_Description.Text = "ProgramDescription";
            // 
            // coursePanel3
            // 
            hoverEffect3.MouseEnter = SystemColors.ControlLight;
            hoverEffect3.PrevColor = SystemColors.ActiveBorder;
            coursePanel3.DefaultHoverEffects = hoverEffect3;
            coursePanel3.IsOngoing = false;
            coursePanel3.Location = new Point(0, 0);
            coursePanel3.Name = "coursePanel3";
            coursePanel3.Padding = new Padding(1);
            coursePanel3.Size = new Size(785, 150);
            coursePanel3.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 648);
            panel7.Name = "panel7";
            panel7.Size = new Size(1059, 8);
            panel7.TabIndex = 38;
            // 
            // panel8
            // 
            panel8.AutoSize = true;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(tableLayoutPanel4);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 656);
            panel8.Name = "panel8";
            panel8.Size = new Size(1059, 554);
            panel8.TabIndex = 39;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.ControlDark;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1057, 552);
            tableLayoutPanel4.TabIndex = 40;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLight;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(1051, 30);
            label4.TabIndex = 38;
            label4.Text = "Program Information";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(CourseTemplatesContainer);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1051, 516);
            tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(tableLayoutPanel5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1043, 488);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Classes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.ControlLight;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel5.Controls.Add(_dgv, 0, 0);
            tableLayoutPanel5.Controls.Add(_addSectionToProgramButton, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1035, 480);
            tableLayoutPanel5.TabIndex = 40;
            // 
            // _dgv
            // 
            _dgv.AllowUserToAddRows = false;
            _dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            _dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            _dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgv.Columns.AddRange(new DataGridViewColumn[] { ClassName, ClassID, ClassYearLevel, ClassCount, ClassDetails });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            _dgv.DefaultCellStyle = dataGridViewCellStyle2;
            _dgv.Dock = DockStyle.Fill;
            _dgv.Location = new Point(3, 3);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.Size = new Size(937, 474);
            _dgv.TabIndex = 44;
            _dgv.CellContentClick += _dgv_CellContentClick;
            // 
            // ClassName
            // 
            ClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClassName.HeaderText = "Class Name";
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            ClassName.Resizable = DataGridViewTriState.False;
            ClassName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ClassID
            // 
            ClassID.HeaderText = "Class ID";
            ClassID.Name = "ClassID";
            ClassID.ReadOnly = true;
            // 
            // ClassYearLevel
            // 
            ClassYearLevel.HeaderText = "Year Level";
            ClassYearLevel.Name = "ClassYearLevel";
            ClassYearLevel.ReadOnly = true;
            // 
            // ClassCount
            // 
            ClassCount.HeaderText = "No. of Students";
            ClassCount.Name = "ClassCount";
            ClassCount.ReadOnly = true;
            // 
            // ClassDetails
            // 
            ClassDetails.HeaderText = "Details";
            ClassDetails.Name = "ClassDetails";
            ClassDetails.ReadOnly = true;
            // 
            // _addSectionToProgramButton
            // 
            _addSectionToProgramButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _addSectionToProgramButton.BackColor = SystemColors.Highlight;
            _addSectionToProgramButton.FlatAppearance.BorderColor = Color.Black;
            _addSectionToProgramButton.FlatStyle = FlatStyle.Flat;
            _addSectionToProgramButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _addSectionToProgramButton.ForeColor = Color.White;
            _addSectionToProgramButton.Location = new Point(946, 3);
            _addSectionToProgramButton.Name = "_addSectionToProgramButton";
            _addSectionToProgramButton.Size = new Size(86, 24);
            _addSectionToProgramButton.TabIndex = 43;
            _addSectionToProgramButton.Text = "Add Class";
            _addSectionToProgramButton.UseVisualStyleBackColor = false;
            // 
            // CourseTemplatesContainer
            // 
            CourseTemplatesContainer.AutoScroll = true;
            CourseTemplatesContainer.BorderStyle = BorderStyle.FixedSingle;
            CourseTemplatesContainer.Location = new Point(4, 24);
            CourseTemplatesContainer.Name = "CourseTemplatesContainer";
            CourseTemplatesContainer.Padding = new Padding(3);
            CourseTemplatesContainer.Size = new Size(1043, 488);
            CourseTemplatesContainer.TabIndex = 1;
            CourseTemplatesContainer.Text = "Course Templates";
            CourseTemplatesContainer.UseVisualStyleBackColor = true;
            // 
            // AdminProgramDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminProgramDetails";
            Size = new Size(1059, 1229);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Panel panel2;
        private Label ProgramTitleLabel;
        private Panel panel1;
        private Teacher.UserControls.CoursePanel coursePanel1;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button10;
        private Label _progDetails_Status;
        private Label label3;
        private Button _editDescriptionButton;
        private Button _editStatusButton;
        private Button _editProgramName;
        private Label label12;
        private Label _progDetailsProgramTitle;
        private Label _progDetails_CreatedBy;
        private Label _progDetails_DateCreated;
        private Label label2;
        private Label label5;
        private Label _progDetails_LastEditor;
        private Label label20;
        private Button button7;
        private Teacher.UserControls.CoursePanel coursePanel2;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label _progDetails_Description;
        private Teacher.UserControls.CoursePanel coursePanel3;
        private Panel panel7;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView _dgv;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn ClassID;
        private DataGridViewTextBoxColumn ClassYearLevel;
        private DataGridViewTextBoxColumn ClassCount;
        private DataGridViewButtonColumn ClassDetails;
        private Button _addSectionToProgramButton;
        private TabPage CourseTemplatesContainer;
    }
}
