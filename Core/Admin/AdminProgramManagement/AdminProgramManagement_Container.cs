using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Models;
using Finals.Models;

namespace Finals.Core.Admin.AdminProgramManagement
{
    public partial class AdminProgramManagement_Container : UserControl, IAdminProgramManagementContainer
    {
        private UserControl _adminProgramManagement;
        
        public AdminProgramManagement_Container(UserModel user)
        {
            InitializeComponent();
            _adminProgramManagement = new AdminProgramManagement(user);
            if (_adminProgramManagement is UserControl uc)
            {
                Project(uc);
            } else
            {
                throw new Exception("An unknown error has occured. AdminProgramManagemnet_Container.contructor");
            }
            
            var presenter = new AdminProgramManagementContainerPresenter(this);
        }

        public UserControl MainPage => _adminProgramManagement;

        public Action<ProgramModel> Action { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Project(UserControl uc)
        {
            SuspendLayout();
            this.Controls.Clear();
            this.Controls.Add(uc);
            ResumeLayout();
        }
    }

    public interface IAdminProgramManagementContainer
    {
        UserControl MainPage { get; }

        Action<ProgramModel> Action { get; set; }
        void Project(UserControl uc);
    }

    public class AdminProgramManagementContainerPresenter
    {
        private readonly IAdminProgramManagementContainer _container;
        public AdminProgramManagementContainerPresenter(IAdminProgramManagementContainer container)
        {
            _container = container;
            WireEvents();
        }

        private void WireEvents()
        {

            if (_container.MainPage is IAdminProgramManagement adminProgramManagement)
            {
                adminProgramManagement.ProgramAction = (model) =>
                {
                    var uc = new AdminProgramDetails(model, adminProgramManagement.CurrentUser);
                    _container.Project(uc);

                    uc.BackClick += (_, _) => _container.Project(_container.MainPage);
                };
            }
            else
            {
                throw new Exception("MainPage does not implement IAdminProgramManagement");
            }
        }

        //private Action<ClassSectionModel> ProjectClassDetails()
        //{
        //    var uc = new UserControl();

        //    _container.Project(uc);
        //}
    }
}
