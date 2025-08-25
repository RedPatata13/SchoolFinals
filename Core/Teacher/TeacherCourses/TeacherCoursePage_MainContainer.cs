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
using Finals.Core.Teacher.TeacherCoursesPage;
using Finals.Forms;
using Finals.Models;

namespace Finals.Core.Teacher.TeacherCourses
{
    public partial class TeacherCoursePage_MainContainer : UserControl, ITeacherCoursePage_MainContainer
    {
        public TeacherCoursePage_MainContainer()
        {
            InitializeComponent();
            DisplayLandingPage();
        }

        public void DisplayCoursePage(CourseModel_Assigned course, Action action)
        {
            var coursePage = new TeacherCourseDetailsPage_Main(course);
            coursePage.Dock = DockStyle.Fill;
            Projector.Project(this, coursePage);

            coursePage.BackClick += (_, _) => action?.Invoke();
        }

        public void DisplayLandingPage()
        {
            var landingPage = new TeacherCoursePage_LandingPage();
            landingPage.Dock = DockStyle.Fill;
            landingPage.LoadCoursePage = DisplayCoursePage;
            Projector.Project(this, landingPage);
        }
    }

    public interface ITeacherCoursePage_MainContainer
    {
        void DisplayLandingPage();
        void DisplayCoursePage(CourseModel_Assigned course, Action action);
    }
}
