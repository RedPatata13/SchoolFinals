using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Core.Teacher.TeacherCourseDetailsPage
{
    public class TeacherCourseDetails_Feature : IFeature
    {
        private UserControl _uc = new TeacherCourseDetailsPage_Main();
        public bool IsEdited { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Image Image => throw new NotImplementedException();

        public string Name => "Course Details";

        public string Description => "Lorem ipsum dolor sit amet";

        public UserControl UserControl => _uc;

        public void PreSwap()
        {
            throw new NotImplementedException();
        }
    }
}
