using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Core.Admin.AdminYearManagement.UserControls
{
    public partial class SchoolYearPhaseUserControl : UserControl, ISchoolYearPhase
    {
        private string _syName = String.Empty;
        private SchoolYearModel _curr = null!;
        private Action _concludeSy = null!;
        private Action _activateSy = null!;
        private Action _startSy = null!;
        private Action _onCurrSet = null!;

        public event EventHandler MainAction
        {
            add => MainActionButton.Click  += value;
            remove => MainActionButton.Click -= value;
        }
        public event EventHandler SecondaryAction
        {
            add => SecondaryActiomButton.Click += value;
            remove => SecondaryActiomButton.Click -= value;
        }

        public SchoolYearModel SchoolYear 
        { 
            get => _curr; 
            set
            {
                _curr = value;
                _onCurrSet?.Invoke();
                Update(_curr);
            }
        }

        public Action OnConcludeSY { get => _concludeSy; set => _concludeSy = value; }
        public Action OnActivateSY { get => _activateSy; set => _activateSy = value; }
        public Action OnStartSY { get => _startSy; set => _startSy = value; }
        public Action OnCurrentSchoolYearUpdate { get => _onCurrSet; set => _onCurrSet = value;  }

        //public Control? MainControl { get => this.Parent; }

        //public Action<SchoolYear> OnUpdate { get => _onUpdate; set => _onUpdate = value; }

        public void Update(SchoolYearModel year)
        {
            //MessageBox.Show(year.SchoolYearId);
            switch (year.Status)
            {
                case SchoolYearStatus.Active:
                    UpdateJumboTron(year.Status, SystemColors.Highlight, SystemColors.HighlightText, Color.FromArgb(229, 57, 73), "Conclude", SystemColors.HighlightText, SystemColors.ControlText, SystemColors.ControlText, "", false);
                    break;

                case SchoolYearStatus.Locked:
                    UpdateJumboTron(year.Status, SystemColors.ControlLight, SystemColors.ControlText, SystemColors.Highlight, "New", SystemColors.HighlightText, SystemColors.ControlLightLight, SystemColors.ControlText, "Revert", true);
                    break;

                case SchoolYearStatus.Draft:
                    UpdateJumboTron(year.Status, SystemColors.ControlLight, Color.DarkGray, SystemColors.Highlight, "Activate", SystemColors.HighlightText, SystemColors.ControlLightLight, SystemColors.ControlText, "Revert", true);
                    break;
                case SchoolYearStatus.Archived:
                    BackColor = SystemColors.HighlightText;
                    SY_Status.BackColor = SystemColors.HighlightText;
                    MainActionButton.BackColor = Color.FromArgb(229, 57, 53);
                    MainActionButton.ForeColor = SystemColors.HighlightText;
                    MainActionButton.Text = "Conclude";
                    break;
            }
            SY_Name.Text = year.Name;
            void UpdateJumboTron(SchoolYearStatus status, Color backcolor, Color headerForeColor, Color pbc, string pbt, Color pbtc, Color sbc, Color sbtc,  string sbt, bool sb_visible = false)
            {
                SY_Status.Text = status.ToString();
                SY_ID.Text = _curr.SchoolYearId;
                BackColor = backcolor;
                SY_Name.ForeColor = headerForeColor;
                SY_Status.ForeColor = headerForeColor;
                MainActionButton.BackColor = pbc;
                MainActionButton.ForeColor = pbtc;
                MainActionButton.Text = pbt;
                SecondaryActiomButton.BackColor = sbc;
                SecondaryActiomButton.ForeColor = sbtc;
                SecondaryActiomButton.Text = sbt;
                SecondaryActiomButton.Visible = sb_visible;
            }
        }

        public SchoolYearPhaseUserControl()
        {
            InitializeComponent();
            var presenter = new SchoolYearPhasePresenter(this);
        }
    }

    public interface ISchoolYearPhase
    {
        SchoolYearModel SchoolYear { get; set; }
        void Update(SchoolYearModel year);

        Action OnConcludeSY { get; set; }
        Action OnActivateSY { get; set; }
        Action OnStartSY { get; set; }
        Action OnCurrentSchoolYearUpdate { get; set; }

        event EventHandler MainAction;
        event EventHandler SecondaryAction;
    }

    public class SchoolYearPhasePresenter
    {
        private readonly ISchoolYearPhase _view;
        private EventHandler? _mainActionHandler;
        public SchoolYearPhasePresenter(ISchoolYearPhase view)
        {
            _mainActionHandler = (_, _) => { };
            _view = view;
            WireEvents();
        }

        private void WireEvents()
        {
            //_view.MainAction += (_, _) => ConcludeSY();
            //SetCurrentSchoolYear();
            _view.OnCurrentSchoolYearUpdate = SetEvents;
            //SetEvents();
        }

        private void ConcludeSY()
        {
            using (var dialog = new ConfirmSchoolYearConclude())
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                var res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    _view.SchoolYear = new SchoolYearModel()
                    {
                        Status = SchoolYearStatus.Locked,
                        Name = "SY 2025 - 2026"
                    };
                    SetEvents();
                }

            }
        }
        private void NewSYDraft()
        {

            using (var dialog = new StartSchoolYearDraftDialog())
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                var res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    _view.SchoolYear = new SchoolYearModel()
                    {
                        Status = SchoolYearStatus.Draft,
                        Name = "SY 2026 - 2027"
                    };
                    SetEvents();
                }

            }
        }

        private void ActivateDraft()
        {
            using (var dialog = new ActivateSchoolYear())
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                var res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    _view.SchoolYear = new SchoolYearModel()
                    {
                        Status = SchoolYearStatus.Active,
                        Name = "SY 2026 - 2027"
                    };
                    SetEvents();
                }
            }
        }
        private void SetCurrentSchoolYear()
        {
            ISchoolYearManagerService service = new SchoolYearManagerService();
            var sy = service.GetCurrentSchoolYear();
            _view.SchoolYear = sy;
            service.Dispose();  
        }
        private EventHandler? _currentMainActionHandler;

        private void SetEvents()
        {
            if (_view.SchoolYear == null) return;
            // Remove previous handler if it exists
            //if (_currentMainActionHandler != null)
            //{
            //    _view.MainAction -= _currentMainActionHandler;
            //}

            //// Create and store new handler
            //_currentMainActionHandler = _view.SchoolYear.Status switch
            //{
            //    SchoolYearStatus.Active => (_, _) => ConcludeSY(),
            //    SchoolYearStatus.Locked => (_, _) => NewSYDraft(),
            //    SchoolYearStatus.Draft => (_, _) => ActivateDraft(),
            //    _ => (_, _) => DefaultHandler()
            //};

            //// Add new handler
            //_view.MainAction += _currentMainActionHandler;
        }

        private void DefaultHandler()
        {

        }


    }
    public interface ISchoolYearManagerService : IDisposable
    {
        //void ConcludeSY();
        //void StartNewSY();
        SchoolYearModel GetCurrentSchoolYear();
        SchoolYearModel CreateSchoolYearDraft();
        Status GenerateSchoolYearID(SchoolYearModel model);
    }

    public class SchoolYearManagerService : ISchoolYearManagerService
    {
        public SchoolYearModel CreateSchoolYearDraft()
        {
            var repo = RepositoryFactory.Create();
            SchoolYearModel curr = null!;
            try
            {
                curr = repo.SchoolYears.GetCurrentSchoolYear();
                

                var newSy = new SchoolYearModel()
                {
                    IsCurrent = true,
                };

                var result = GenerateSchoolYearID(newSy);
                
                
                if(result == Status.Ok)
                {
                    newSy.SchoolYearId = newSy.SchoolYearId;
                    newSy.Name = newSy.Name;
                } 
                else
                {
                    newSy.SchoolYearId = "N/A";
                    newSy.Name = "N/A"; 
                }

                if (curr != null)
                {
                    curr.IsCurrent = false;
                    repo.SchoolYears.Update(curr);
                }

                repo.SchoolYears.Add(newSy);
                repo.SaveChanges();

                return newSy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                repo.Dispose();
            }

            throw new InvalidOperationException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Status GenerateSchoolYearID(SchoolYearModel model)
        {
            try
            {
                string startYear = (DateTime.Now.Year % 100).ToString("D2");
                string endYear = ((DateTime.Now.Year + 1) % 100).ToString("D2");
                string yearCode = $"{startYear}{endYear}";
                string pattern = $@"^SY{startYear + endYear}(\.\d+)?$";
                Regex regex = new Regex(pattern);

                var schoolYears = RepositoryFactory.Create().SchoolYears.GetAll();

                int matchCount = schoolYears.Count(sy => regex.IsMatch(sy.SchoolYearId));

                model.SchoolYearId = matchCount == 0 ? $"SY{yearCode}" : $"SY{yearCode}.{matchCount}";
                model.Name = matchCount == 0 ? $"School Year {yearCode}" : $"School Year {yearCode}.{matchCount}";

                return Status.Ok;
            }
            catch (Exception ex){
                MessageBox.Show("An unexpected error occurred while generating the School Year ID: " + ex.Message);
                return Status.Error;
            }
        }

        public SchoolYearModel GetCurrentSchoolYear()
        {
            var repo = RepositoryFactory.Create();
            SchoolYearModel curr = null!;
            try
            {
                 curr = repo.SchoolYears.GetCurrentSchoolYear() ?? throw new InvalidOperationException("There is no school years marked as current");
                
                return curr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GC.SuppressFinalize(repo);
            }

            return curr;
        }
    }

}
