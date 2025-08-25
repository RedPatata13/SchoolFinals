using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core.Teacher.TeacherCourseDetailsPage;
using Finals.Core.Teacher.TeacherCourses;
using Finals.Core.Teacher.TeacherCoursesPage;
using Finals.Forms;
using Finals.Forms.UserControls;

namespace Finals.Core.FeatureRegister
{
    public class FeatureRegister_Teacher : IFeatureRegistrator
    {
        public IFeature Home => throw new NotImplementedException();

        public void RegisterFeatures(IInterfaceFrame frame)
        {
            frame.RegisterFeature(new TestFeature()
            {
                _uc = new TeacherCoursePage_MainContainer(),
                _name = "Your Courses",
                _description = "Your courses for this semester."
            });
            frame.RegisterFeature(new TestFeature()
            {
                _uc = new Teacher.TeacherCourseTasks.TeacherCourseTasks_Main(),
                _name = "Course Tasks",
                _description = "lorem iprsum dolor sit amet"
            });
        }
    }
}
