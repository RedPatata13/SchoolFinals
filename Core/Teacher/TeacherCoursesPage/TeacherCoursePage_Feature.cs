using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Core.Teacher.TeacherCoursesPage
{
    public class TeacherCoursePage_Feature : IFeature
    {
        private UserControl uc = new TeacherCoursePage_MainContainer();
        public bool IsEdited { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Image Image => throw new NotImplementedException();

        public string Name => "Courses";

        public string Description => "lroem ipsum dolor ist amet";

        public UserControl UserControl => uc;

        public void PreSwap()
        {
            throw new NotImplementedException();
        }
    }
}
