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
using Finals.Services;

namespace Finals.Forms
{
    public partial class SelectSchoolYearDialog : Form, ISelectSchoolYearDialog
    {
        private ICollection<SchoolYearModel> _models = new List<SchoolYearModel>();
        private SchoolYearModel _value = null!;
        public SelectSchoolYearDialog()
        {
            InitializeComponent();
            var presenter = new SelectSchoolYearDialogPresenter(this);
        }

        public ICollection<SchoolYearModel> SchoolYears
        {
            get => _models;
            set
            {
                _models = value;
                UpdateDGV();
            }
        }

        public SchoolYearModel Value
        {
            get => _value;
            set
            {
                _value = value;
                ValidateValue();
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

        private void UpdateDGV()
        {
            _syDGV.Rows.Clear();
            foreach (var sy in _models)
            {
                var row = new DataGridViewRow();
                row.CreateCells(
                        _syDGV,
                        sy.Name,
                        sy.SchoolYearId,
                        (sy.StartDate != default(DateTime)) ? sy.StartDate.ToShortDateString() : "N/A",
                        (sy.EndDate != default(DateTime)) ? sy.EndDate.ToShortDateString() : "N/A",
                        DateTime.Now,
                        "Select"
                );
                row.Tag = sy;
                _syDGV.Rows.Add(row);
            }
        }

        private void _syDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int buttonColumnIndex = _syDGV.Columns.Count - 1;
            if (e.ColumnIndex == buttonColumnIndex)
            {
                var row = _syDGV.Rows[e.RowIndex];
                _syDGV.Rows[e.RowIndex].Selected = true;
                var sy = row.Tag as SchoolYearModel;

                if (sy != null)
                {
                    _syName.Text = sy.Name;
                    _syId.Text = sy.SchoolYearId;
                    _syDateStart.Text = (sy.StartDate != default(DateTime)) ? sy.StartDate.ToShortDateString() : "N/A";
                    _syDateConcluded.Text = (sy.EndDate != default(DateTime)) ? sy.EndDate.ToShortDateString() : "N/A";
                    Value = sy;
                }
            }
        }

        private void ValidateValue()
        {
            if (_value != null)
            {
                MainActionButton.Enabled = true;
                MainActionButton.ForeColor = SystemColors.HighlightText;
                MainActionButton.BackColor = SystemColors.Highlight;
            }
            else
            {
                MainActionButton.Enabled = false;
                MainActionButton.ForeColor = SystemColors.ScrollBar;
                MainActionButton.BackColor = SystemColors.Menu;
            }
        }
    }

    public interface ISelectSchoolYearDialog
    {
        ICollection<SchoolYearModel> SchoolYears { get; set; }
        SchoolYearModel Value { get; set; }
    }

    public class SelectSchoolYearDialogPresenter
    {
        private readonly ISelectSchoolYearDialog _view;
        public SelectSchoolYearDialogPresenter(ISelectSchoolYearDialog view)
        {
            _view = view;
            LoadSchoolYears();
        }
        public void LoadSchoolYears()
        {
            _view.SchoolYears = SchoolYearRepo.GetAll();
        }
    }
}
