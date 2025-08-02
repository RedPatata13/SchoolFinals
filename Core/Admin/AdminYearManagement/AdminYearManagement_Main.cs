using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Finals.Core.Admin.AdminYearManagement.UserControls;
using Finals.Services;
using Finals.Services.Contracts;
using Finals.Models;

namespace Finals.Core.Admin.AdminYearManagement
{
    public partial class AdminYearManagement_Main : UserControl, IAdminYearManagement_Main
    {
        private SchoolYearModel _curr = null!;
        private SchoolYearPhaseUserControl _uc = null!;
        private string sy_Name = null!;

        public AdminYearManagement_Main()
        {
            InitializeComponent();

            panel1.Controls.Clear();
            var uc = new SchoolYearPhaseUserControl();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

            _uc = uc;

            var presenter = new AdminYearManagementPresenter(this);
        }

        public SchoolYearModel CurrentSchoolYear 
        {
            get => _curr;
            set
            {
                _curr = value;
                _uc.SchoolYear = value;
                SYDetails_Name.Text = value.Name;
                SYDetails_ID.Text = value.SchoolYearId;
                SYDetails_Status.Text = value.Status.ToString();
                SYDetails_DateStarted.Text = value.StartDate.ToString();
                SYDetails_DateEnd.Text = value.EndDate.ToString();
                SYDetails_IsRegistrationOpen.Text = (value.IsRegistrationOpen) ? "YES" : "NO";
            }
        }
        public string SY_Name 
        {
            get => _curr.Name;
            set
            {
                _curr.Name = value;
                _uc.SchoolYear.Name = value;
                SYDetails_Name.Text = value;
                
            }
        }
        public SchoolYearStatus SchoolYearStatus
        {
            get => _curr.Status;
            set
            {
                _curr.Status = value;
                SYDetails_Status.Text = value.ToString();
            }
        }
        public DateTime StartDate 
        {
            get => _curr.StartDate;
            set
            {
                _curr.StartDate = value;
                SYDetails_DateStarted.Text = value.ToString();
            }
        }
        public DateTime EndDate
        {
            get => _curr.EndDate;
            set
            {
                _curr.EndDate = value;
                SYDetails_DateEnd.Text = value.ToString();
            }
        }
        public bool IsRegistrationOpen 
        { 
            get => _curr.IsRegistrationOpen;
            set
            {

                _curr.IsRegistrationOpen = value;
                SYDetails_IsRegistrationOpen.Text = (value) ? "YES" : "NO";
            }
        }

        public event EventHandler SYBannerMainAction
        {
            add => _uc.MainAction += value;
            remove => _uc.MainAction -= value;
        }
    }

    public interface IAdminYearManagement_Main
    {
        SchoolYearModel CurrentSchoolYear { get; set; }
        string SY_Name { get; set; }
        SchoolYearStatus SchoolYearStatus { get; set; }
        
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        bool IsRegistrationOpen { get; set; }


        event EventHandler SYBannerMainAction;
    }

    public class AdminYearManagementPresenter
    {
        public readonly IAdminYearManagement_Main _view;
        private EventHandler _currentMainAction = (_, _) => { }; // do nothing
        public AdminYearManagementPresenter(IAdminYearManagement_Main view)
        {
            _view = view;
            WireEvents();
        }
        private void WireEvents()
        {
            SetSchoolYearToLatest();
        }

        private void SetSchoolYearToLatest()
        {
            ISchoolYearManagerService service = null!;
            try
            {
                service = new SchoolYearManagerService();
                var sy = service.GetCurrentSchoolYear();
                _view.CurrentSchoolYear = sy;

                SetNewMainBannerEvents(Popup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (service != null) service.Dispose();
            }

            void Popup()
            {
                using (var dialog = new ConfirmSchoolYearConclude())
                {
                    dialog.StartPosition = FormStartPosition.CenterScreen;
                    var res = dialog.ShowDialog();

                    if (res == DialogResult.OK)
                    {
                        CreateSchoolYearDraft();
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        // Do nothing, user cancelled
                    }
                    else
                    {
                        MessageBox.Show("An unexpected error occurred while creating a new school year draft.");
                    }
                }
            }
        }

        private void CreateSchoolYearDraft()
        {
            ISchoolYearManagementService service = null!;
            try
            {
                service = new SchoolYearManagementService();
                var newSy = service.CreateNewSchoolYear(true); // true to conclude the current school year
                MessageBox.Show("A new School Year draft has been created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _view.CurrentSchoolYear = newSy; // update the view with the new school year draft
            } 
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error has occured while trying to create a new School Year draft " + ex.Message);
            } 
            finally
            {
                if (service != null) service.Dispose();
            }
        }

        private void SetNewMainBannerEvents(Action action)
        {
            if (_currentMainAction != null)
            {
                _view.SYBannerMainAction -= _currentMainAction;
            }
            _currentMainAction = (_, _) =>
            {
                action?.Invoke();
            };
            _view.SYBannerMainAction += _currentMainAction;
        }
    }
}
