using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core.Admin.UserControls;
using Finals.Models;
using Finals.Models;

namespace Finals.Core.Admin.AdminProgramManagement
{
    public partial class AdminProgramManagement : UserControl, IAdminProgramManagement
    {
        private ICollection<ProgramModel> _programs = new List<ProgramModel>();
        private Action<ProgramModel> _programAction = null!;
        private UserModel _currentUser = null!;
        public AdminProgramManagement(UserModel currentUser)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            _currentUser = currentUser;
            var presenter = new AdminProgramManagementPresenter(this);
        }

        /// <summary>
        /// Note: Don't inherit argumentless constructor so that "_programAction" has a value first before the presenter gets called which populates the Programs
        /// </summary>
        /// <param name="action">Action to be invoked when an AdminProgramTile is clicked</param>
        public AdminProgramManagement(Action<ProgramModel> action)
        {
            InitializeComponent();
           _programAction = action;

            comboBox1.SelectedIndex = 0;
            var presenter = new AdminProgramManagementPresenter(this);
        }

        public ICollection<ProgramModel> Programs 
        {
            get => _programs;
            set
            {
                _programs = value;
                _programsContainer.Controls.Clear();

                int opened = 0;
                int closed = 0;
                int total = _programs.Count;
                foreach(var p in _programs)
                {
                    AdminProgramTile apt = new AdminProgramTile()
                    {
                        Program = p
                    };
                    apt.ThisClick += (_, _) => _programAction?.Invoke(p);
    
                    _programsContainer.Controls.Add(apt);

                    if (p.IsOpen) opened++;
                    else closed++;
                }

                _totalPrograms.Text = total.ToString();
                _openedPrograms.Text = opened.ToString();
                _closedPrograms.Text = closed.ToString();

            }
        }

        public Action<ProgramModel> ProgramAction { get => _programAction; set => _programAction = value; }

        public UserModel CurrentUser => _currentUser;

        public event EventHandler AddProgramClick
        {
            add => _addProgramButton.Click += value;
            remove => _addProgramButton.Click -= value;
        }
    }

    public interface IAdminProgramManagement
    {
        UserModel CurrentUser { get; }
        ICollection<ProgramModel> Programs { get; set; }
        Action<ProgramModel> ProgramAction { get; set; }
        event EventHandler AddProgramClick;
    }

    public class AdminProgramManagementPresenter
    {
        private readonly IAdminProgramManagement _view;
        public AdminProgramManagementPresenter(IAdminProgramManagement view)
        {
            _view = view;
            WireEvents();
        }
        private void WireEvents()
        {
            _view.ProgramAction = (model) => MessageBox.Show(model.ProgramName);
            _view.Programs.Clear();
            GetAllPrograms();

            _view.AddProgramClick += (_, _) => AddProgram();
        }

        private void AddProgram()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                var programs = repo.Programs.GetAll();
                using (var dialog = new ProgramCreationDialog())
                {
                    dialog.StartPosition = FormStartPosition.CenterScreen;
                    var result = dialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {

                        ProgramModel model = new ProgramModel()
                        {
                            ProgramId = $"PROG-{programs.Count() + 1}",
                            ProgramName = dialog.ProgramName,
                            ProgramDescription = dialog.ProgramDescription,
                            CreatorId = _view.CurrentUser.UserID,
                            LastEditorId = _view.CurrentUser.UserID,
                            CreatedAt = DateTime.Now,
                            IsOpen = true
                        };

                        ProgramModel_Edits edits = new ProgramModel_Edits()
                        {
                            Edit_ID = Guid.NewGuid().ToString().Substring(0, 10),
                            EditorId = _view.CurrentUser.UserID,
                            Edit = "Initial Create of Program",
                            ProgramId = model.ProgramId,
                            EditedAt = DateTime.Now,
                        };

                        repo.Programs.Add(model);
                        repo.ProgramEdits.Add(edits);

                        repo.SaveChanges();
                        MessageBox.Show("Program added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var newList = _view.Programs.ToList();
                        newList.Insert(0, model);

                        _view.Programs = newList;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding a program: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
                    
            }
        }
        private void GetAllPrograms()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                _view.Programs = repo.Programs.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching programs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }
        }
    }
}
