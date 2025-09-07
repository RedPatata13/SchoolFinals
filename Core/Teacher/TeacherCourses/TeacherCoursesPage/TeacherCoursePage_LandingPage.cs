using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core.Teacher.TeacherCourseDetailsPage;
using Finals.Core.Teacher.UserControls;
using Finals.Forms;
using Finals.Forms.UserControls;
using Finals.Models;
using Finals.Services;

namespace Finals.Core.Teacher.TeacherCoursesPage
{
    public partial class TeacherCoursePage_LandingPage : UserControl, ITeacherCoursePage_LandingPage
    {
        private string _userId = null!;
        private ICollection<CourseModel_Assigned> _courses = new List<CourseModel_Assigned>()
            {
                new CourseModel_Assigned()
                {
                    Registrations = new List<AssignedCourseRegistration>()
                    {
                        new AssignedCourseRegistration()
                        {
                            Student = new StudentModel()
                            {
                                FirstName = "John",
                                LastName = "Doe",
                                MiddleName = "A.",
                            }
                        }
                    }
                }
            };
        private bool _hasCourses = true;
        private Label NoAssignedCoursesLabel = new Label()
        {
            Text = "No Assigned Courses",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            AutoSize = false
        };
        private Action<CourseModel_Assigned, Action> _loadCoursePage = null!;
        private Action _loadLandingPage = null!;
        private Action _projectToContainer = null!;
        public ICollection<CourseModel_Assigned> courses
        {
            get => _courses;
            set
            {
                _courses = value;
                RenderCourses();
            }
        }

        public Action<CourseModel_Assigned, Action> LoadCoursePage
        {
            get => _loadCoursePage;
            set
            {
                _loadCoursePage = value;
                //MessageBox.Show("setter called");   
                RenderCourses();
            }
        }
        public Action BackToLandingPage
        {
            get => _loadLandingPage;
            set
            {
                _loadLandingPage = value;
                RenderCourses();
            }
        }

        public Action ProjectToContainer
        {
            get => _projectToContainer;
            set
            {
                _projectToContainer = value;
                RenderCourses();
            }
        }

        public string UserId => _userId;

        private void RenderCourses()
        {
            if (_courses == null || _courses.Count == 0)
            {
                if (!_hasCourses) Controls.Remove(_TilesContainer);
                Controls.Add(NoAssignedCoursesLabel);
                _hasCourses = false;
                return;
            }
            if (!_hasCourses) Controls.Add(_TilesContainer);
            _hasCourses = true;
            _TilesContainer.Controls.Clear();

            foreach (var course in _courses)
            {
                var tile = new AssignedCourseTile(course);
                tile.TileClicked += (s, e) =>
                {
                    LoadCoursePage?.Invoke(course, BackToLandingPage);
                    if (LoadCoursePage == null) MessageBox.Show("LoadCoursePage is null");
                    //MessageBox.Show("tile clicked");
                };
                _TilesContainer.Controls.Add(tile);
            }
        }
        public TeacherCoursePage_LandingPage(string userId)
        {
            InitializeComponent();
            _userId = userId;

            var presenter = new TeacherCoursePage_LandingPage_Presenter(this);
            RenderCourses();
        }
    }

    public interface ITeacherCoursePage_LandingPage
    {
        ICollection<CourseModel_Assigned> courses { get; set; }
        Action<CourseModel_Assigned, Action> LoadCoursePage { get; set; }
        Action BackToLandingPage { get; set; }
        Action ProjectToContainer { get; set; }

        string UserId { get; }
    }

    public class TeacherCoursePage_LandingPage_Presenter
    {
        private readonly ITeacherCoursePage_LandingPage _view;
        public TeacherCoursePage_LandingPage_Presenter(ITeacherCoursePage_LandingPage view)
        {
            _view = view;
            WireEvents();
        }

        private void WireEvents()
        {
            _view.courses = AssignedCourseRepo.GetTeacherAssignedCoursesForCurrentTerm(_view.UserId);
        }
    }
}
