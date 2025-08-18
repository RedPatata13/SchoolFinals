using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core.Admin.AdminYearManagement.UserControls;
using Finals.Forms;
using Finals.Forms.UserControls;
using Finals.Models;
using Finals.Services;

namespace Finals.Core.Admin
{
    public partial class AdminClassSectionDetails : UserControl, IAdminClassSectionDetails
    {
        private ClassSectionModel _model;
        private ICollection<CourseModel_Assigned> _assignedCourses = new List<CourseModel_Assigned>();
        private string _userId = null!;
        private Action<CourseModel_Assigned> _onTeacherUpdate = null!;
        private Func<Action> _onScheduleUpdate = null!;
        public AdminClassSectionDetails(ClassSectionModel model, string userId)
        {
            InitializeComponent();
            _model = model;
            _userId = userId;
            var presenter = new AdminClassSectionPresenter(this);
        }

        public ClassSectionModel Model
        {
            get => _model;
            set
            {
                _model = value;
            }
        }

        public event EventHandler AddCourseButtonClick
        {
            add => _addCourseButtonClick.Click += value;
            remove => _addCourseButtonClick.Click -= value;
        }

        public event EventHandler BackClick
        {
            add => BackButton.Click += value;
            remove => BackButton.Click -= value;
        }

        public ICollection<CourseModel_Assigned> AssignedCourses
        {
            get => _assignedCourses;
            set
            {
                _assignedCourses = value;
                UpdateCoursesDGV();
            }
        }
        public Action<CourseModel_Assigned> OnTeacherUpdate
        {
            get => _onTeacherUpdate;
            set => _onTeacherUpdate = value;
        }

        public Func<Action> OnScheduleUpdate
        {
            get => _onScheduleUpdate;
            set => _onScheduleUpdate = value;
        }
        public string UserId => _userId;

        private void UpdateCoursesDGV()
        {
            _courses.Rows.Clear();
            _courseCount.Text = _assignedCourses.Count.ToString();

            foreach (var course in _assignedCourses)
            {
                var row = new DataGridViewRow();
                row.CreateCells(
                    _courses,
                    (!String.IsNullOrWhiteSpace(course.Course.CourseName)) ? course.Course.CourseName : "Unknown Course",
                    course.CourseId,
                    ScheduleFormat(course.Schedules.ToList()),
                    "Update Schedule",
                    (course.Teacher != null && !String.IsNullOrWhiteSpace(course.Teacher.ToString())) ? course.Teacher.ToString() : "TBA",
                    "Update Teacher"
                );

                _courses.Rows.Add(row);
                row.Tag = course;
                _courses.Sort(_courses.Columns[0], ListSortDirection.Ascending);
            }
        }

        private string ScheduleFormat(List<VenueModel> venues)
        {
            if (venues.Count == 0) return "TBA";
            string suffix = (venues.Count > 1) ? $" + {venues.Count - 1}" : "";

            return $"{venues[0].Day} : {(!String.IsNullOrWhiteSpace(venues[0].Location) ? venues[0].Location : "TBA")}{suffix}";
        }

        private void _courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int updateTeacherColumnIndex = _courses.Columns.Count - 1;
            if (e.ColumnIndex == updateTeacherColumnIndex)
            {
                var row = _courses.Rows[e.RowIndex];
                var ac = row.Tag as CourseModel_Assigned;

                if(ac != null)
                {
                    this.OnTeacherUpdate?.Invoke(ac);
                    UpdateCoursesDGV();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new SelectTeacherDialog())
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.Text = "Select Teacher";
                var result = dialog.ShowDialog();
            }
        }
    }

    public interface IAdminClassSectionDetails
    {
        ClassSectionModel Model { get; set; }
        event EventHandler BackClick;
        event EventHandler AddCourseButtonClick;
        string UserId { get; }
        ICollection<CourseModel_Assigned> AssignedCourses { get; set; }
        Action<CourseModel_Assigned> OnTeacherUpdate {  get; set; }
        Func<Action> OnScheduleUpdate { get; set; }
    }

    public class AdminClassSectionPresenter
    {
        private readonly IAdminClassSectionDetails _view;
        public AdminClassSectionPresenter(IAdminClassSectionDetails view)
        {
            _view = view;
            WireEvents();
        }

        private void WireEvents()
        {
            _view.AddCourseButtonClick += (_, _) => AddCourseButtonInvoke();
            _view.AssignedCourses = AssignedCourseRepo.GetAllBySection(_view.Model.SectionID);
            _view.OnTeacherUpdate = ReassignTeacher;
        }

        private void AddCourseButtonInvoke()
        {
            using (var dialog = new CourseMultiSelectDialog())
            {
                dialog.Text = "Select Courses";
                var result = dialog.ShowDialog();

                if(result == DialogResult.OK)
                {
                    var list = new List<CourseModel_Assigned>();
                    foreach(var course in dialog.SelectedCourses)
                    {
                        var ac = new CourseModel_Assigned()
                        {
                            AssignedCourseModelId = Guid.NewGuid().ToString().Substring(0, 10),
                            CourseId = course.CourseId,
                            Course = course,
                            TeacherId = null!,
                            Teacher = null!,
                            SectionId = _view.Model.SectionID,
                            AssignedId = _view.UserId,
                            Schedules = new List<VenueModel>(),
                        };

                        list.Add(ac);
                    }

                    _view.AssignedCourses = _view.AssignedCourses.Concat(list).ToList();
                    AssignedCourseRepo.AddAssignedCourse(list.ToArray());
                    
                }
            }
        }

        private void ReassignTeacher(CourseModel_Assigned course)
        {
            using (var dialog = new SelectTeacherDialog())
            {
                dialog.Text = "Select a Teacher";
                dialog.StartPosition = FormStartPosition.CenterScreen;
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    course.Teacher = dialog.Value;
                    course.TeacherId = dialog.Value.TeacherID;

                    AssignedCourseRepo.UpdateAssignedTeacher(course.AssignedCourseModelId, dialog.Value.TeacherID);
                }
            }
        }
    }
}
