using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Finals.Core.Student.StudentCourses;

namespace Finals.Core.Student.StudentRegistration
{
    public class StudentRegistration_Feature : IFeature
    {
        private bool _isEdited = false;
        private string _name = "Assessment";
        private string _description = "Checks your eligibility in order to enroll to the next semester, year or be able to graduate.";
        private UserControl _uc = new Test();
        public bool IsEdited { get => _isEdited; set => _isEdited = value; }

        public Image Image => throw new NotImplementedException();

        public string Name => _name;

        public string Description => _description;

        public UserControl UserControl
            {
                get
            {
                //MessageBox.Show("this got called");
                return _uc;
            }      
            }
        public void PreSwap()
        {
            //throw new NotImplementedException();
        }
    }
}
