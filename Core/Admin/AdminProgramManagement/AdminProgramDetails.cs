using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accessibility;
using Finals.Forms;
using Finals.Forms.UserControls;
using Finals.Models;
using Finals.Services;
using Finals.Services.Contracts;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Core.Admin.AdminProgramManagement
{
    public partial class AdminProgramDetails : UserControl, IAdminProgramDetails
    {
        private ProgramModel _model = null!;
        private UserModel _currentUser = null!;
        private string _programTitle = string.Empty;
        private Action _onAddToSection = null!;
        private Action _dgv_CellButtonClick = null!;

        public event EventHandler AddSectionToProgramClick
        {
            add => _addSectionToProgramButton.Click += value;
            remove => _addSectionToProgramButton.Click -= value;
        }

        public event EventHandler EditNameClick
        {
            add => _editProgramName.Click += value;
            remove => _editProgramName.Click -= value;
        }
        public event EventHandler EditDescriptionClick
        {
            add => _editDescriptionButton.Click += value;
            remove => _editDescriptionButton.Click -= value;
        }
        public event EventHandler EditStatusClick
        {
            add => _editStatusButton.Click += value;
            remove => _editStatusButton.Click -= value;
        }

        public event EventHandler BackClick
        {
            add => BackButton.Click += value;
            remove => BackButton.Click -= value;
        }

        public string ProgramTitle
        {
            get => _programTitle;
            set
            {
                _programTitle = value;
                ProgramTitleLabel.Text = _programTitle;
            }
        }

        public string CreatedBy
        {
            get => _progDetails_CreatedBy.Text;
            set => _progDetails_CreatedBy.Text = value;
        }

        public string LastEditedBy
        {
            get => _progDetails_LastEditor.Text;
            set => _progDetails_LastEditor.Text = value;
        }
        public ProgramModel Model
        {
            get => _model;
            set
            {
                _model = value;
                ProgramTitle = _model.ProgramName;
                CreatedBy = _model.CreatedBy?.UserName ?? "Unknown";
                LastEditedBy = _model.LastEditedBy?.UserName ?? "Unknown";
                DateCreated = _model.CreatedAt;
                ProgramDescription = _model.ProgramDescription ?? "No description available.";
                Sections = _model.ClassSections ?? new List<ClassSectionModel>();
            }
        }

        public DateTime? DateCreated
        {
            get => _model.CreatedAt;
            set
            {
                _model.CreatedAt = value;
                _progDetails_DateCreated.Text = (value == default(DateTime) || value == null) ? "Unknown" : value.Value.ToString("g");
            }
        }

        public string ProgramDescription
        {
            get => _progDetails_Description.Text;
            set
            {
                _progDetails_Description.Text = value;
            }
        }

        public UserModel CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
            }
        }
        public ICollection<ClassSectionModel> Sections
        {
            get => _model.ClassSections;
            set
            {
                _model.ClassSections = value;
                UpdateDGV();
            }
        }

        public Action OnAddSectionToProgram { get => _onAddToSection; set => _onAddToSection = value; }
        public Action DGV_CellButtonClick { get => _dgv_CellButtonClick; set => _dgv_CellButtonClick = value; }

        public AdminProgramDetails(ProgramModel model, UserModel user)
        {
            InitializeComponent();
            Model = model;
            CurrentUser = user;
            var presenter = new AdminProgramDetailsPresenter(this);
        }

        private void AddRowToSectionDGV(ClassSectionModel model)
        {
            //_dgv.Rows.Add(n)
        }

        private void UpdateDGV(bool clearRows = true)
        {
            if (clearRows) _dgv.Rows.Clear();
            if (_model.ClassSections == null)
            {
                _model.ClassSections = new List<ClassSectionModel>();
            }
            _model.ClassSections.ToList().ForEach(e =>
            {
                var row = new DataGridViewRow();
                row.CreateCells(_dgv, e.SectionName, e.SectionID, Ordinal(e.YearLevel), "13", "See Details");
                row.Tag = e;
                _dgv.Rows.Add(row);
            });
        }

        private string Ordinal(int number)
        {
            if (number % 100 / 10 == 1) return $"{number}th";
            switch (number % 10)
            {
                case 1: return $"{number}st";
                case 2: return $"{number}nd";
                case 3: return $"{number}rd";
                default: return $"{number}th";
            }
        }

        public void AddSectionToDGV(ClassSectionModel model)
        {
            var row = new DataGridViewRow();
            row.CreateCells(_dgv, model.SectionName, model.SectionID, Ordinal(model.YearLevel), "13", "See Details");
            row.Tag = model;
            _dgv.Rows.Add(row);
        }

        private void _dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int buttonColumnIndex = _dgv.Columns.Count - 1;
            if (e.ColumnIndex == buttonColumnIndex)
            {
                var row = _dgv.Rows[e.RowIndex];
                var classSection = row.Tag as ClassSectionModel;

                if (classSection != null)
                {
                    var parent = this.Parent;
                    if (parent != null)
                    {
                        var uc = new AdminClassSectionDetails(classSection);
                        Projector.Project(parent, uc);
                        uc.BackClick += (_, _) =>
                        {
                            Projector.Project(parent, this);
                            uc.Dispose();
                        };
                    }
                }
            }
        }
    }
    public interface IAdminProgramDetails
    {
        UserModel CurrentUser { get; set; }
        ProgramModel Model { get; set; }
        ICollection<ClassSectionModel> Sections { get; set; }
        string ProgramTitle { get; set; }
        string ProgramDescription { get; set; }
        string CreatedBy { get; set; }
        string LastEditedBy { get; set; }
        DateTime? DateCreated { get; set; }
        event EventHandler BackClick;
        event EventHandler EditNameClick;
        event EventHandler EditDescriptionClick;
        event EventHandler EditStatusClick;
        event EventHandler AddSectionToProgramClick;
        Action OnAddSectionToProgram { get; set; }
        Action DGV_CellButtonClick { get; set; }
        void AddSectionToDGV(ClassSectionModel model);
    }

    public class AdminProgramDetailsPresenter
    {
        private IAdminProgramDetails _view;
        public AdminProgramDetailsPresenter(IAdminProgramDetails view)
        {
            _view = view;
            WireEvents();
        }
        private void AddClassSectionToProgram()
        {
            using (var dialog = new ClassSectionDialog())
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                var result = dialog.ShowDialog();

                if(result == DialogResult.OK)
                {
                    foreach(var section in dialog.Value)
                    {
                        if (section == null) continue;
                        section.SectionID = Guid.NewGuid().ToString().Substring(0, 8);
                        section.ProgramId = _view.Model.ProgramId;
                        section.Program = _view.Model;
                        using (IProgramManagementService service = new ProgramManagementService())
                        {
                            service.AddSectionToProgram(_view.Model.ProgramId, _view.CurrentUser.UserID, section);
                        }

                        _view.Model.ClassSections.Add(section);
                        _view.AddSectionToDGV(section);
                    }   
                }
            }
        }
        private void WireEvents()
        {
            _view.EditNameClick += (_, _) => UpdateProgramName();
            _view.EditStatusClick += (_, _) => UpdateProgramStatus();
            _view.AddSectionToProgramClick += (_, _) => AddClassSectionToProgram();
        }

        private void UpdateProgramName()
        {
            using (var dialog = new UpdateStringDialog(_view.ProgramTitle))
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.Text = "Update Program Name";
               
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var repo = RepositoryFactory.Create();
                    try
                    {
                        var program = repo.Programs.GetById(_view.Model.ProgramId);
                        if(program == null)
                        {
                            throw new Exception("Program not found.");  
                        }
                        program.ProgramName = dialog.NewValue;

                        repo.Programs.Update(program);
                        _view.ProgramTitle = dialog.NewValue;

                        string edit = ProgramEditLogTemplate(dialog.OldValue, program.ProgramName);
                        var edit_log = LogProgramEdit(edit, program.ProgramId);

                        repo.ProgramEdits.Add(edit_log);
                        repo.SaveChanges();
                        MessageBox.Show($"Program updated succesfully, {edit}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating program name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        repo.Dispose();
                    }
                }
            }
        }
        private void UpdateProgramStatus()
        {
            var list = new List<string>() { "Open", "Close" };

            using (var dialog = new UpdateComboBoxDialog(list))
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var repo = RepositoryFactory.Create();
                    try
                    {
                        var program = repo.Programs.GetById(_view.Model.ProgramId);
                        if (program == null)
                        {
                            throw new Exception("Program not found.");
                        }
                        program.IsOpen = dialog.Value == "Open";
                        repo.Programs.Update(program);
                        _view.Model.IsOpen = program.IsOpen;

                        string edit = ProgramEditLogTemplate(dialog.Value, (program.IsOpen)? "Open" : "Close");
                        var edit_log = LogProgramEdit(edit, program.ProgramId);
                        repo.ProgramEdits.Add(edit_log);
                        repo.SaveChanges();
                        MessageBox.Show($"Program status updated succesfully, {edit}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating program status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        repo.Dispose();
                    }
                }
            }
        }

        private string ProgramEditLogTemplate(string oldValue, string newValue)
        {
            return $"\nold value: {oldValue}\nnew value: {newValue}";
        }


        private ProgramModel_Edits LogProgramEdit(string editMsg, string programId)
        {
            return new ProgramModel_Edits()
            {
                Edit_ID = Guid.NewGuid().ToString().Substring(0, 10),
                EditorId = _view.CurrentUser.UserID,
                Edit = editMsg,
                EditedAt = DateTime.Now,
                ProgramId = programId,
            };
        }
    }
}
