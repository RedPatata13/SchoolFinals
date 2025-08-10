using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core;
using Finals.Core.Admin;
using Finals.Models;
using Finals.Services;

namespace Finals.Forms.UserControls
{
    public partial class CourseMultiSelectDialog : Form, ICourseMultiSelectDialog
    {
        private ICollection<CourseModel> _courses = new List<CourseModel>();
        private ICollection<CourseModel> selectedCourses = new List<CourseModel>();
        public CourseMultiSelectDialog()
        {
            InitializeComponent();
            var presenter = new CourseMultiSelectDialogPresenter(this);
        }

        public ICollection<CourseModel> Courses
        {
            get => _courses;
            set
            {
                var set = selectedCourses != null
                    ? new HashSet<string>(selectedCourses.Select(c => c.CourseId))
                    : new HashSet<string>();

                _courses = value.Where(c => !set.Contains(c.CourseId)).DistinctBy(c => c.CourseId).ToList();
                UpdateCourseDGV();
            }
        }

        public ICollection<CourseModel> SelectedCourses
        {
            get => selectedCourses;
            set
            {
                selectedCourses = value ?? new List<CourseModel>();
                UpdateSelectedCourseDGV();
            }
        }

        private void UpdateCourseDGV()
        {
            _courseCount.Text = _courses.Count.ToString();
            _coursesDGV.Rows.Clear();
            foreach (var course in _courses)
            {
                var row = new DataGridViewRow();
                row.CreateCells(
                    _coursesDGV,
                    course.CourseName,
                    course.CourseId,
                    (course.DateCreated != default(DateTime)) ? course.DateCreated.ToShortDateString() : "N/A",
                    (course.Creator != null && !String.IsNullOrWhiteSpace(course.Creator.UserName)) ? course.Creator?.UserName : "Unknown Creator",
                    "See Details"
                    );
                row.Tag = course;
                _coursesDGV.Rows.Add(row);
            }

            _coursesDGV.Sort(_coursesDGV.Columns[0], ListSortDirection.Ascending);
        }

        private void UpdateSelectedCourseDGV()
        {
            _totalSelectedCoursesCount.Text = selectedCourses.Count.ToString();
            _selectedCourseDGV.Rows.Clear();
            foreach (var courses in selectedCourses)
            {
                var row = new DataGridViewRow();
                row.CreateCells(
                    _selectedCourseDGV,
                    courses.CourseName,
                    courses.CourseId,
                    "Remove"
                );

                row.Tag = courses;
                _selectedCourseDGV.Rows.Add(row);
            }

            _selectedCourseDGV.Sort(_selectedCourseDGV.Columns[0], ListSortDirection.Ascending);
            ValidateSelected();
        }

        private void _courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int buttonColumnIndex = _coursesDGV.Columns.Count - 1;
            if (e.ColumnIndex == buttonColumnIndex)
            {
                var row = _coursesDGV.Rows[e.RowIndex];
                var course = row.Tag as CourseModel;

                //_coursesDGV.Rows.RemoveAt(e.RowIndex);
                if (course != null)
                {
                    SelectedCourses.Add(course);
                    _courses.Remove(course);
                    UpdateCourseDGV();
                    UpdateSelectedCourseDGV();
                }
            }
        }

        private void _selectedourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int buttonColumnIndex = _selectedCourseDGV.Columns.Count - 1;
            if (e.ColumnIndex == buttonColumnIndex)
            {
                var row = _selectedCourseDGV.Rows[e.RowIndex];
                var course = row.Tag as CourseModel;

                //_selectedCourseDGV.Rows.RemoveAt(e.RowIndex);
                if (course != null)
                {
                    SelectedCourses.Remove(course);
                    _courses.Add(course);
                    UpdateCourseDGV();
                    UpdateSelectedCourseDGV();
                }
            }
        }

        private void ValidateSelected()
        {
            if (SelectedCourses.Count == 0)
            {
                MainActionButton.Enabled = false;
                MainActionButton.BackColor = SystemColors.Menu;
                MainActionButton.ForeColor = SystemColors.ScrollBar;
            }
            else
            {
                MainActionButton.Enabled = true;
                MainActionButton.BackColor = SystemColors.Highlight;
                MainActionButton.ForeColor = SystemColors.HighlightText;
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

    public interface ICourseMultiSelectDialog
    {
        ICollection<CourseModel> Courses { get; set; }
        ICollection<CourseModel> SelectedCourses { get; set; }
    }

    public class CourseMultiSelectDialogPresenter
    {
        private readonly ICourseMultiSelectDialog _view;
        public CourseMultiSelectDialogPresenter(ICourseMultiSelectDialog view)
        {
            _view = view;
            WireEvents();
        }
        private void WireEvents()
        {
            PopulateCourses();
        }

        private void PopulateCourses()
        {
            _view.Courses = CourseRepo.GetAllCourses();
        }
    }
}
