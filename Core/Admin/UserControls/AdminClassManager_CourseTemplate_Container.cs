using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Forms.UserControls;
using Finals.Models;

namespace Finals.Core.Admin.UserControls
{
    public partial class AdminClassManager_CourseTemplate_Container : UserControl, IAdminClassManager_CourseTemplate_Container
    {
        private Panel NoTemplates => new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = Color.Transparent,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Padding = new Padding(10),
            Controls =
            {
                new Label
                {
                    Text = "No Course Templates Available",
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                }
            }
        };

        private Panel NoCourses => new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = Color.Transparent,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Padding = new Padding(10),
            Controls =
            {
                new Label
                {
                    Text = "No Courses Available",
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter
                }
            }
        };
        private ICollection<CourseTemplateModel> _courseTemplates = new List<CourseTemplateModel>();
        private CourseTemplateModel _curr = null!;
        private Action _onUpdate = null!;
        public string _programId { get; set; } = null!;
        private string _userId = null!;
        public AdminClassManager_CourseTemplate_Container()
        {
            InitializeComponent();
            //CourseTemplates = new List<CourseTemplateModel>();
            var presenter = new AdminClassManager_CourseTemplate_Container_Presenter(this);
        }

        public ICollection<CourseTemplateModel> CourseTemplates
        {
            get => _courseTemplates;
            set
            {
                _courseTemplates = value ?? new List<CourseTemplateModel>();
                ShowTemplates();
            }
        }

        public CourseTemplateModel CurrentTemplate
        {
            get => _curr;
            set => _curr = value;
        }

        public event EventHandler AddNewClick
        {
            add => _addButton.Click += value;
            remove => _addButton.Click -= value;
        }

        public string ProgramId
        {
            get => _programId;
            set => _programId = value ?? String.Empty;
        }

        public string UserId
        {
            get => _userId;
            set => _userId = value ?? String.Empty; 
        }

        public Action OnUpdateTemplates
        {
            get => _onUpdate;
            set => _onUpdate = value;
        }
        private void ShowTemplates()
        {
            //MessageBox.Show(_courseTemplates.Count.ToString());
            int y = 4;
            int gap = 1;
            _sidebar.Controls.Clear();
            foreach (var template in _courseTemplates)
            {
                var HoverEffect = new SimpleHoverEffect(SystemColors.ControlDark);
                var panel = new Label();
                panel.Size = new Size(_sidebar.Width - 10, 30);
                panel.Text = template.TemplateName ?? "Unnamed Template";
                panel.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                panel.Padding = new Padding(8, 0, 0, 0);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BackColor = SystemColors.ControlLightLight;
                panel.TextAlign = ContentAlignment.MiddleLeft;
                HoverEffect.ApplyEvents(panel);
                panel.Location = new Point(4, y);
                y += panel.Height + gap;
                _sidebar.Controls.Add(panel);
            }

            if (_courseTemplates.Count == 0)
            {
                _sidebar.Controls.Add(NoTemplates);
                //NoTemplates.Dock = DockStyle.Fill;
            }
        }
        public void UpdateTemplates()
        {
            _onUpdate?.Invoke();
            ShowTemplates();
        }
    }

    public interface IAdminClassManager_CourseTemplate_Container
    {
        ICollection<CourseTemplateModel> CourseTemplates { get; set; }
        CourseTemplateModel CurrentTemplate { get; set; }
        string UserId { get; set; }
        string ProgramId { get; set; }
        event EventHandler AddNewClick;
        void UpdateTemplates();
        Action OnUpdateTemplates { get; set; }
    }

    public class AdminClassManager_CourseTemplate_Container_Presenter
    {
        private readonly IAdminClassManager_CourseTemplate_Container _view;
        public AdminClassManager_CourseTemplate_Container_Presenter(IAdminClassManager_CourseTemplate_Container view)
        {
            _view = view;
            WireEvents();
        }
        private void WireEvents()
        {
            _view.CourseTemplates = GetTemplates();
            _view.OnUpdateTemplates = () => UpdateTemplates();
            _view.AddNewClick += (_, _) =>
            {
                AddNewTemplate();
            };
        }
        private ICollection<CourseTemplateModel> GetTemplates()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                //MessageBox.Show(_view.ProgramId);
                return repo.CourseTemplates.GetByProgramId(_view.ProgramId).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching templates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CourseTemplateModel>();
            }
            finally
            {
                repo.Dispose();
            }
        }
        private void AddNewTemplate()
        {
            using (var dialog = new NewStringDialog())
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var newTemplate = new CourseTemplateModel()
                    {
                        TemplateId = Guid.NewGuid().ToString().Substring(0, 10),
                        TemplateName = dialog.Value,
                        DateCreated = DateTime.Now,
                        CreatorId = _view.UserId,
                        ProgramId = _view.ProgramId
                    };
                    var repo = RepositoryFactory.Create();
                    try
                    {
                        repo.CourseTemplates.Add(newTemplate);
                        repo.SaveChanges();
                        MessageBox.Show(dialog.Value + " template created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving template: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        repo.Dispose();
                    }

                    _view.CourseTemplates.Add(newTemplate);
                    _view.CurrentTemplate = newTemplate;
                    _view.CourseTemplates = _view.CourseTemplates;
                }
            }
        }
        public void UpdateTemplates()
        {
            _view.CourseTemplates = GetTemplates();

        }
    }
}

