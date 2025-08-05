using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Forms;
using Finals.Models;
using Finals.Services;

namespace Finals.Core.Admin.AdminCourseManagement
{
    public partial class AdminCourseManagement_LandingPage : UserControl, IAdminCourseManagement_LandingPage
    {
        private string uid;
        private Action<CourseModel> _onCourseUpdate = null!;
        private ICollection<CourseModel> _courses = new List<CourseModel>();
        public string UserId => uid;

        public ICollection<CourseModel> Courses
        {
            get => _courses;
            set
            {
                _courses = value ?? new List<CourseModel>();
                UpdateDGV();
            }
        }

        public Action<CourseModel> OnCourseUpdate { get => _onCourseUpdate; set => _onCourseUpdate = value; }

        public event EventHandler CreateCourseClicked
        {
            add => _addCourseButton.Click += value;
            remove => _addCourseButton.Click -= value;
        }
        public AdminCourseManagement_LandingPage(string userId)
        {
            InitializeComponent();
            comboBox3.SelectedIndex = comboBox2.SelectedIndex = 0;
            uid = userId;
            var presenter = new AdminCoruseManagementLandingPagePresenter(this);
        }

        private void UpdateDGV()
        {
            _dgv.Rows.Clear();
            foreach (var course in Courses)
            {
                var row = new DataGridViewRow();
                row.CreateCells(_dgv, course.CourseName, course.CourseId, course.DefaultUnits, course.DateCreated.ToShortDateString(), course.Description, "See Details");
                row.Tag = course;
                _dgv.Rows.Add(row);
            }
        }

        private void _dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int buttonColumnIndex = _dgv.Columns.Count - 1;
            if (e.ColumnIndex == buttonColumnIndex)
            {
                var row = _dgv.Rows[e.RowIndex];
                var course = row.Tag as CourseModel;

                if (course != null)
                {
                    OnCourseUpdate?.Invoke(course);
                    UpdateDGV();
                }
            }
        }
    }

    public interface IAdminCourseManagement_LandingPage
    {
        string UserId { get; }
        ICollection<CourseModel> Courses { get; set; }
        Action<CourseModel> OnCourseUpdate { get; set; }
        event EventHandler CreateCourseClicked;
    }

    public class AdminCoruseManagementLandingPagePresenter
    {
        private readonly IAdminCourseManagement_LandingPage _view;

        public AdminCoruseManagementLandingPagePresenter(IAdminCourseManagement_LandingPage view)
        {
            _view = view;
            //_view.CreateCourseClicked += OnCreateCourseClicked;
            WireEvents();
        }

        private void WireEvents()
        {
            _view.Courses = CourseRepo.GetAllCourses();
            _view.CreateCourseClicked += (_, _) =>
            {
                using(var dialog = new CourseCRUDDialog())
                {
                    dialog.Text = "Create new Course";
                    dialog.StartPosition = FormStartPosition.CenterScreen;
                    var result = dialog.ShowDialog();

                    if(result == DialogResult.OK)
                    {
                        var val = dialog.Value;
                        val.CreatorId = _view.UserId;
                        val.CourseId = Guid.NewGuid().ToString().Substring(0, 10);
                        val.DateCreated = DateTime.Now;
                        CourseRepo.CreateCourse(val);
                    }
                }
            };

            _view.OnCourseUpdate = UpdateCourse;
        }

        private void UpdateCourse(CourseModel course)
        {
            using (var dialog = new CourseCRUDDialog(course))
            {
                dialog.Text = "Update Course";
                dialog.StartPosition = FormStartPosition.CenterScreen;
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    course.CourseName = dialog.CourseName;
                    course.DefaultUnits = dialog.DefaultUnits;
                    course.Description = dialog.CourseDescription;
                    course.DateCreated = dialog.DateCreated;
                    CourseRepo.UpdateCourse(course);
                }
            }
        }
    }
}
