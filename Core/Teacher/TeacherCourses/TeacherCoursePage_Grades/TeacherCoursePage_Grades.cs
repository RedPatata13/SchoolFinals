using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Teacher.TeacherCourses.TeacherCoursePage_Grades
{
    public partial class TeacherCoursePage_Grades : UserControl, ITeacherCoursePage_Grades
    {
        public TeacherCoursePage_Grades()
        {
            InitializeComponent();
        }

        public event EventHandler BackClick
        {
            add => _backButton.Click += value;
            remove => _backButton.Click -= value;
        }
    }

    public interface ITeacherCoursePage_Grades
    {
        event EventHandler BackClick;
    }
}
