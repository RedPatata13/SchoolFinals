using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core.Teacher.UserControls;
using Finals.Models;

namespace Finals.Core.Teacher.TeacherCourses.TeacherCoursePage_Grades
{
    public partial class TeacherCoursePage_Grades : UserControl, ITeacherCoursePage_Grades
    {
        private ICollection<StudentModel> students;
        public TeacherCoursePage_Grades(ICollection<StudentModel> Students)
        {
            InitializeComponent();
            //students = Students ?? new List<StudentModel>();
            if(Students == null || Students.Count == 0)
            {
                students = new List<StudentModel>();
                MessageBox.Show("No students enrolled yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                students = Students;
            }
            RenderStudentGrades();
        }

        public event EventHandler BackClick
        {
            add => _backButton.Click += value;
            remove => _backButton.Click -= value;
        }

        private void RenderStudentGrades()
        {
            panel5.Controls.Clear();
            if (students.Count == 0)
            {
                Label noStudentsLabel = new Label()
                {
                    Text = "No students enrolled yet.",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = false
                };
                panel5.Controls.Add(noStudentsLabel);
                return;
            }


            foreach(var student in students)
            {
                var studentGradeControl = new EditGradesUC()
                {
                    StudentName = (String.IsNullOrEmpty(student.ToString()))? "Unknown Student" : student.ToString(),
                    StudentGrade = "N/A"
                };

                studentGradeControl.Dock = DockStyle.Top;
                panel5.Controls.Add(studentGradeControl);
            }
        }
    }

    public interface ITeacherCoursePage_Grades
    {
        event EventHandler BackClick;
    }
}
