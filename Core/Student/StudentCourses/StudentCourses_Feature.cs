using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Core.Student.StudentCourses
{
    public class StudentCourses_Feature : IFeature
    {
        private bool _isEdited = false;
        private string _name = "Courses";
        private string _description = "See detailed information about your courses.";
        private UserControl _uc = new StudentCourses_MainUC();
        public bool IsEdited { get => _isEdited; set => _isEdited = value; }

        public Image Image => throw new NotImplementedException();

        public string Name => _name;

        public string Description => _description;

        public UserControl UserControl => _uc;

        public void PreSwap()
        {
            //throw new NotImplementedException();
        }
    }
}
