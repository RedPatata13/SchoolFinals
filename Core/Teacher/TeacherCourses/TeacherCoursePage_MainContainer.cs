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
        private string _userId = null!;
        public string UserId => _userId ?? String.Empty;

        public TeacherCoursePage_MainContainer(string userId)
        {
            _userId = userId;
            InitializeComponent();
            DisplayLandingPage();
            
        }

        public void DisplayCoursePage(CourseModel_Assigned course, Action action)
        {
            var coursePage = new TeacherCourseDetailsPage_Main(course);
            coursePage.Dock = DockStyle.Fill;
            coursePage.ProjectToContainer = ProjectToContainer;
            Projector.Project(this, coursePage);

            coursePage.BackClick += (_, _) => action?.Invoke();
            //MessageBox.Show("this gets clicked");
        }

        private void DisplayLandingPage()
        {
            var landingPageFactory = () =>
            {
                return new TeacherCoursePage_LandingPage(UserId);
            };
            var landingPage = landingPageFactory();
            landingPage.LoadCoursePage = DisplayCoursePage;
            landingPage.BackToLandingPage = () => ProjectLandingPage(landingPageFactory, landingPage);

            //ProjectLandingPage(landingPageFactory, landingPage);
            landingPage.Dock = DockStyle.Fill;
            Projector.Project(this, landingPage);
        }

        public void ProjectLandingPage(Func<TeacherCoursePage_LandingPage> landingPageFactory, TeacherCoursePage_LandingPage current)
        {
            var landingPage = landingPageFactory();
            landingPage.Dock = DockStyle.Fill;
            landingPage.LoadCoursePage = DisplayCoursePage;
            landingPage.BackToLandingPage = () => ProjectLandingPage(landingPageFactory, landingPage);
            Projector.Project(this, landingPage);
            current.Dispose();
        }

        public void ProjectToContainer(Control control, bool fillDock = false)
        {
            if(fillDock) control.Dock = DockStyle.Fill;
            Projector.Project(this, control);
        }
    }

    public interface ITeacherCoursePage_MainContainer
    {
        void ProjectLandingPage(Func<TeacherCoursePage_LandingPage> landingPageFactory, TeacherCoursePage_LandingPage current);
        void DisplayCoursePage(CourseModel_Assigned course, Action action);
        void ProjectToContainer(Control control, bool fillDock = false);
        string UserId
        {
            get;
        }
    }
}
