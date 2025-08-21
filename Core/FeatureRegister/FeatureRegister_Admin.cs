using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Core.Admin.AdminAccountsCRUD;
using Finals.Core.Admin.AdminCourseManagement;
using Finals.Core.Admin.AdminPersonalAccount;
using Finals.Core.Admin.AdminProgramManagement;
using Finals.Core.Admin.AdminYearManagement;
using Finals.Forms;
using Finals.Models;

namespace Finals.Core.FeatureRegister
{
    public class FeatureRegister_Admin : IFeatureRegistrator
    {
        private readonly UserModel _user = null!;
        public IFeature Home => throw new NotImplementedException();

        public FeatureRegister_Admin(UserModel user)
        {
            _user = user;
        }

        public void RegisterFeatures(IInterfaceFrame frame)
        {
            frame.RegisterFeature(new TestFeature()
            {
                _uc = new AdminYearManagement_Main() { Dock = DockStyle.Fill },
                _name = "School Year",
                _description = "Manage and view School years."
            });
            frame.RegisterFeature(new TestFeature()
            {
                _uc = new AdminProgramManagement_Container(_user),
                _name = "Programs",
                _description = "Lorem ipsum dolor sit amet"
            });
            frame.RegisterFeature(new TestFeature()
            {
                _uc = new AdminCourseManagement_Container(_user.UserID),
                _name = "Courses",
                _description = "Manage your courses"
            });
            
            //frame.RegisterFeature(new TestFeature()
            //{
            //    _uc = new UserControl(),
            //    _name = "Records",
            //    _description = ""
            //});
            frame.RegisterFeature(new TestFeature()
            {
                //_uc = new AdminAccountsCRUD(),
                //_uc = new AdminStudentRecordsCRUD_Container(),
                _uc = new AdminAccountsCRUD(_user.UserID) { Dock = DockStyle.Fill },
                _name = "User Accounts",
                _description = ""
            });
            frame.RegisterFeature(new TestFeature()
            {
                _uc = new AdminPersonalAccount_Main(),
                _name = "Personal Account",
                _description = ""
            });
        }
    }
}
