using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core.Admin.AdminAccountsCRUD.AdminStudentRecordsCRUD_Pages;

namespace Finals.Core.Admin.AdminAccountsCRUD
{
    public partial class AdminStudentRecordsCRUD_Container : UserControl, IAdminStudentRecordsCRUD_Container
    {
        public AdminStudentRecordsCRUD_Container()
        {
            InitializeComponent();
            var presenter = new AdminStudentRecordsCRUD_ContainerPresenter(this);
        }

        public Panel ProjectionPanel => panel2;

        public event EventHandler AccountButton
        {
            add => _accountButton.Click += value;
            remove => _accountButton.Click -= value;
        }
        public event EventHandler GradesButton
        {
            add => _gradesButton.Click += value;
            remove => _gradesButton.Click -= value;
        }
        public event EventHandler RecordsBtton
        {
            add => _recordsButton.Click += value;
            remove => _recordsButton.Click -= value;
        }
    }

    public interface IAdminStudentRecordsCRUD_Container
    {
        event EventHandler AccountButton;
        event EventHandler GradesButton;
        event EventHandler RecordsBtton;
        Panel ProjectionPanel { get; }
    }

    public class AdminStudentRecordsCRUD_ContainerPresenter
    {
        public readonly IAdminStudentRecordsCRUD_Container _view;
        private AdminStudentRecords_Account accountPage = new AdminStudentRecords_Account();
        private AdminStudentRecords_Grades gradesPage = new AdminStudentRecords_Grades();
        private AdminStudentRecords_Records recordsPage = new AdminStudentRecords_Records();
        public AdminStudentRecordsCRUD_ContainerPresenter(IAdminStudentRecordsCRUD_Container view) 
        { 
            _view = view;
            WireEvents();

            ProjectUC(new AdminStudentRecords_Account());
        }

        private void WireEvents()
        {
            _view.AccountButton += (_, _) => ProjectUC(accountPage);
            _view.GradesButton += (_, _) => ProjectUC(gradesPage);
            _view.RecordsBtton += (_, _) => ProjectUC(recordsPage);
        }

        private void ProjectUC(UserControl uc)
        {
            _view.ProjectionPanel.SuspendLayout();
            _view.ProjectionPanel.Controls.Clear();
            _view.ProjectionPanel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            _view.ProjectionPanel.ResumeLayout();
        }
    }
}
