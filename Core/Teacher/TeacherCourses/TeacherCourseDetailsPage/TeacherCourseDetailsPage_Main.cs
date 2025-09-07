using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Forms.UserControls;
using Finals.Models;
using Finals.Core.Teacher.TeacherCourseTasks;
using Finals.Core.Teacher.TeacherCourses.TeacherCourseDetailsPage;
using Finals.Forms;
using Finals.Core.Teacher.TeacherCourses.TeacherCoursePage_Grades;

namespace Finals.Core.Teacher.TeacherCourseDetailsPage
{
    public partial class TeacherCourseDetailsPage_Main : UserControl, ITeacherCourseDetailsPage_Main
    {
        private CourseModel_Assigned _assignedCourse = null!;
        private Label NoStudents = new Label()
        {
            Text = "No students enrolled yet.",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 12, FontStyle.Italic),
            ForeColor = Color.Gray,
            AutoSize = false
        };
        private Action<Control, bool> _projectToContainer = null!;
        public TeacherCourseDetailsPage_Main(CourseModel_Assigned course)
        {
            InitializeComponent();
            AssignedCourse = course ?? throw new ArgumentNullException(nameof(course));
        }

        public event EventHandler BackClick
        {
            add => _backButton.Click += value;
            remove => _backButton.Click -= value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GradesClassification final = new GradesClassification()
            {
                Name = "Final Grade",
                Value = 1,
                Depth = 0
            };

            GradesClassification finalsTerm = new GradesClassification(final)
            {
                Name = "Finals Term",
                Value = 0.6,
                Depth = 0
            };

            GradesClassification midTerm = new GradesClassification(final)
            {
                Name = "Midterm",
                Value = 0.4,
                Depth = 0
            };

            GradesClassification ft_Exam = new GradesClassification(finalsTerm)
            {
                Name = "Exam",
                Value = 0.6,
                Depth = 0
            };

            GradesClassification classStanding = new GradesClassification(finalsTerm)
            {
                Name = "Class Standing",
                Value = 0.4,
                Depth = 0
            };

            var mt_ex = (GradesClassification)ft_Exam.Clone();
            var mt_cs = (GradesClassification)classStanding.Clone();

            mt_cs.Parent = mt_ex.Parent = midTerm;

            midTerm.Children = new List<GradesClassification>();
            midTerm.Children.Add(mt_ex);
            midTerm.Children.Add(mt_cs);

            using (var dialog = new GradesTreeDialog(final))
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.ShowDialog(this);
            }
        }

        public Action<Control, bool> ProjectToContainer
        {
            get => _projectToContainer;
            set
            {
                _projectToContainer = value;
            }
        }

        public CourseModel_Assigned AssignedCourse
        {
            get => _assignedCourse;
            set
            {
                _assignedCourse = value;
                RenderStudentTiles();
            }
        }

        private void RenderStudentTiles()
        {
            panel5.Controls.Clear();


            var registrationList = (_assignedCourse.Registrations ?? new List<AssignedCourseRegistration>())
                .Where(rs => rs.Student != null)
                .Select(rs => rs.Student)
                .ToList();

            if (registrationList == null || registrationList.Count == 0)
            {
                panel5.Controls.Add(NoStudents);
                return;
            }

            panel5.Controls.Remove(NoStudents);
            foreach (var student in registrationList)
            {
                var tile = new StudentListTile()
                {
                    Dock = DockStyle.Top,
                    StudentName = student.ToString() ?? String.Empty,
                    StudentType = "R",
                    Tag = student
                };
                panel5.Controls.Add(tile);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gradesUc = new TeacherCoursePage_Grades(AssignedCourse.Registrations.Select(s => s.Student).ToList());
            gradesUc.BackClick += (s, ev) =>
            {
                ProjectToContainer?.Invoke(this, true);
            };
            ProjectToContainer?.Invoke(gradesUc, false);
        }
    }
    public interface ITeacherCourseDetailsPage_Main
    {
        event EventHandler BackClick;
        Action<Control, bool> ProjectToContainer { get; set; }
        CourseModel_Assigned AssignedCourse { get; set; }
    }
}
