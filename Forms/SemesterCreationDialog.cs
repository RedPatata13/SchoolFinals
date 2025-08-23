using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Models;

namespace Finals.Forms
{
    public partial class SemesterCreationDialog : Form, ISemesterCreationDialog
    {
        private SemesterModel _value = new SemesterModel();
        public SemesterCreationDialog()
        {
            InitializeComponent();
            startDateDateSelector.MinDate = DateTime.Now.Date;
            endDateDateSelector.MinDate = DateTime.Now.Date.AddYears(1);
            endDateTimeSelector.MinDate = endDateDateSelector.Value.Date.AddHours(23).AddMinutes(59);

            startDateTimeSelector.CustomFormat = endDateTimeSelector.CustomFormat = "hh:mm tt";
        }

        public SemesterModel Value
        {
            get
            {
                _value.SemesterName = textBox1.Text.Trim();
                _value.DateStart = StartDate_Date;
                _value.DateEnd = EndDate_Date;
                _value.IsActive = false;
                _value.Status = SemesterStatus.Preparatory;
                _value.SemesterType = SemesterType.Standard;
                _value.DateCreated = DateTime.Now;
                _value.SemesterId = Guid.NewGuid().ToString().Substring(0, 10);

                return _value;
            }
            set
            {
                _value = value;
                ValidateInput();
            }
        }

        public string SemesterName => textBox1.Text;

        public DateTime StartDate_Date => startDateDateSelector.Value.Date.Add(startDateTimeSelector.Value.TimeOfDay);

        public DateTime EndDate_Date => endDateDateSelector.Value.Date.Add(endDateTimeSelector.Value.TimeOfDay);

        public bool StartDateIsSet => startDateDateSelector.Checked;

        public bool EndDateIsSet => endDateDateSelector.Checked;

        private void ValidateInput()
        {
            string input = textBox1.Text.Trim();
            if (String.IsNullOrWhiteSpace(input))
            {
                MainActionButton.Enabled = false;
                MainActionButton.ForeColor = SystemColors.ScrollBar;
                MainActionButton.BackColor = SystemColors.Menu;
            }
            else if (input.Length >= 101)
            {
                _charCount.ForeColor = Color.Red;
                textBox1.Text = input.Substring(0, 101);
                MainActionButton.Enabled = false;
                MainActionButton.ForeColor = SystemColors.ScrollBar;
                MainActionButton.BackColor = SystemColors.Menu;
            }
            else
            {
                _charCount.ForeColor = SystemColors.ControlDarkDark;
                MainActionButton.Enabled = true;
                MainActionButton.ForeColor = SystemColors.HighlightText;
                MainActionButton.BackColor = SystemColors.Highlight;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
            var input = textBox1.Text.Trim();
            _charCount.Text = $"{input.Length}/100";
            _value.SemesterName = input;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bool sdt_check = startDateDateSelector.Checked;
            if (startDateDateSelector.Value.Date > endDateDateSelector.Value.Date)
            {
                bool edt_check = endDateDateSelector.Checked;
                endDateDateSelector.Value = startDateDateSelector.Value.Date;
                endDateTimeSelector.Value = startDateTimeSelector.Value.AddMinutes(1);
                endDateDateSelector.Checked = edt_check;
            }
        }

        private void MainActionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SecondaryActiomButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    public interface ISemesterCreationDialog
    {
        SemesterModel Value { get; set; }
        string SemesterName { get; }
        DateTime StartDate_Date { get; }
        DateTime EndDate_Date { get; }

        bool StartDateIsSet { get; }
        bool EndDateIsSet { get; }
    }
}
