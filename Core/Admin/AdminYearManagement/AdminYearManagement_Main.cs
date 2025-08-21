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
using Finals.Forms;

namespace Finals.Core.Admin.AdminYearManagement
{
    public partial class AdminYearManagement_Main : UserControl, IAdminYearManagement_Main
    {
        private SchoolYearModel? _curr = null!;
        private SchoolYearModel? _prev = null!;
        private SchoolYearModel? _upcoming = null!;
        private SchoolYearModel? _displayed = null!;
        private string sy_Name = null!;

        public AdminYearManagement_Main()
        {
            InitializeComponent();
            var presenter = new AdminYearManagementPresenter(this);
            _displayed = _curr;
        }

        public SchoolYearModel? CurrentSchoolYear 
        {
            get => _curr;
            set
            {
                _curr = value;
            }
        }

        public SchoolYearModel? UpcomingSchoolYear
        {
            get => _upcoming;
            set
            {
                _upcoming = value;
            }
        }

        public SchoolYearModel? PreviousSchoolYear
        {
            get => _prev;
            set
            {
                _prev = value;
            }
        }

        public SchoolYearModel SchoolYearDisplayed => _displayed!;

        public event EventHandler CurrentSyClick
        {
            add => _currSyButton.Click += value;
            remove => _currSyButton.Click -= value;
        }
        public event EventHandler UpcomingSyClick
        {
            add => _nextSyButton.Click += value;
            remove => _nextSyButton.Click -= value;
        }
        public event EventHandler PreviousSyClick
        {
            add => _prevSyButton.Click += value;
            remove => _prevSyButton.Click -= value;
        }

        public void ProjectSy(SchoolYearModel? model)
        {
            _displayed = model;
            var uc = new SchoolYearDetailsUC(model);
            uc.Size = new Size(this.Width, uc.Height);
            Projector.Project(_syProjector, uc);
        }
    }

    public interface IAdminYearManagement_Main
    {
        SchoolYearModel? CurrentSchoolYear { get; set; }
        SchoolYearModel? UpcomingSchoolYear { get; set; }
        SchoolYearModel? PreviousSchoolYear { get; set; }
        SchoolYearModel? SchoolYearDisplayed { get; }
        event EventHandler CurrentSyClick;
        event EventHandler UpcomingSyClick;
        event EventHandler PreviousSyClick;
        void ProjectSy(SchoolYearModel? model);
    }

    public class AdminYearManagementPresenter
    {
        public readonly IAdminYearManagement_Main _view;
        private EventHandler _currentMainAction = (_, _) => { }; // do nothing
        public AdminYearManagementPresenter(IAdminYearManagement_Main view)
        {
            _view = view;
            PopulateSchoolYear();
            WireEvents();
            Initialize();
            
        }
        private void PopulateSchoolYear()
        {
            _view.CurrentSchoolYear = SchoolYearRepo.GetCurrentSchoolYear();
            _view.PreviousSchoolYear = SchoolYearRepo.GetPreviousSchoolYear();
            _view.UpcomingSchoolYear = SchoolYearRepo.GetUpcomingSchoolYear();
        }
        private void WireEvents()
        {
            _view.CurrentSyClick += (_, _) => OnCurrentSyClick();
            _view.UpcomingSyClick += (_, _) => OnNextSyClick();
            _view.PreviousSyClick += (_, _) => OnPrevSyClick();
        }
        private void Initialize()
        {
            _view.ProjectSy(null!);
            OnCurrentSyClick();
        }
        private void OnCurrentSyClick()
        {
            _view.ProjectSy(_view.CurrentSchoolYear!);
            _view.ProjectSy(_view.CurrentSchoolYear!);
        }

        private void OnPrevSyClick()
        {
            _view.ProjectSy(_view.PreviousSchoolYear);
        }

        private void OnNextSyClick()
        {
            _view.ProjectSy(_view.UpcomingSchoolYear);
        }
    }
}
