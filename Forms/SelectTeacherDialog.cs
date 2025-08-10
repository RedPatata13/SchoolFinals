using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Migrations;
using Finals.Models;
using Finals.Repositories;

namespace Finals.Forms
{
    public partial class SelectTeacherDialog : Form, ISelectTeacherDialog
    {
        private ICollection<TeacherModel> _teachers = new List<TeacherModel>();
        private TeacherModel _value = null!;
        public SelectTeacherDialog()
        {
            InitializeComponent();
            var presenter = new SelecteTeacherDialogPresenter(this);
        }

        public ICollection<TeacherModel> Teachers
        {
            get => _teachers;
            set
            {
                _teachers = value;
                UpdateTeachersDGV();
            }
        }

        public TeacherModel Value
        {
            get => _value;
            set
            {
                _value = value;
                ValidateValue();
            }
        }

        private void UpdateTeachersDGV()
        {
            _teacherDGV.Rows.Clear();
            foreach (var teacher in _teachers)
            {
                var row = new DataGridViewRow();
                row.CreateCells(_teacherDGV, teacher.ToString(), teacher.TeacherID, "N/A", "Select");
                row.Tag = teacher;
                _teacherDGV.Rows.Add(row);
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
        private void _teachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int buttonColumnIndex = _teacherDGV.Columns.Count - 1;
            if (e.ColumnIndex == buttonColumnIndex)
            {
                var row = _teacherDGV.Rows[e.RowIndex];
                var teacher = row.Tag as TeacherModel;

                //_coursesDGV.Rows.RemoveAt(e.RowIndex);
                if (teacher != null)
                {
                    _fullName.Text = teacher.ToString();
                    _firstName.Text = teacher.FirstName;
                    _lastName.Text = teacher.LastName;
                    _middleName.Text = teacher.MiddleName;
                    Value = teacher;
                }
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

    public interface ISelectTeacherDialog
    {
        TeacherModel Value { get; set; }
        ICollection<TeacherModel> Teachers { get; set; }
    }

    public class SelecteTeacherDialogPresenter
    {
        private readonly ISelectTeacherDialog _view;
        public SelecteTeacherDialogPresenter(ISelectTeacherDialog view)
        {
            _view = view;
            _view.Teachers = GetTeachers();
        }
        private ICollection<TeacherModel> GetTeachers()
        {
            return UserRepo.GetTeachers();
        }
    }
}
