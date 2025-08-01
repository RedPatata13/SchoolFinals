using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core.Student.StudentAccount;
using Finals.Core.Student.StudentCourses;
using Finals.Core.Student.StudentRegistration;
using Finals.Forms;

namespace Finals.Core.FeatureRegister
{
    public class FeatureRegister_Student : IFeatureRegistrator
    {
        public IFeature Home => throw new NotImplementedException();

        public void RegisterFeatures(IInterfaceFrame frame)
        {
            frame.RegisterFeature(new StudentCourses_Feature());
            frame.RegisterFeature(new StudentAccount_Feature());
            frame.RegisterFeature(new StudentRegistration_Feature());
        }
    }
}
