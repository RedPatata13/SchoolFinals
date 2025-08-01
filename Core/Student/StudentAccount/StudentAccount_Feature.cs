using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core.Student.StudentCourses;

namespace Finals.Core.Student.StudentAccount
{
    public class StudentAccount_Feature : IFeature
    {
        private bool _isEdited = false;
        private string _name = "Your Account";
        private string _description = "See your recorded information.";
        private UserControl _uc = new StudentAccount_LandingPages();

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
