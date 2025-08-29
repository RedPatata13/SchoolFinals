using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Forms;
using Finals.Forms.UserControls;
using Finals.Models;
using Finals.Services;

namespace Finals.Core.Admin.AdminYearManagement.UserControls
{
    public partial class SchoolYearDetailsUC : UserControl, ISchoolYearDetailsUC
    {
        private SchoolYearModel? _sy = null!;
        private Label NoSchoolYear = new Label()
        {
            BackColor = SystemColors.Control,
            ForeColor = SystemColors.ControlText,
            Text = "No such school year",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(0, 0),
            BorderStyle = BorderStyle.FixedSingle,
            Font = new Font("Segoe UI", 24, FontStyle.Regular),
        };
        public SchoolYearDetailsUC(SchoolYearModel? sy)
        {
            InitializeComponent();
            this.Controls.Add(NoSchoolYear);
            SchoolYear = sy;
            var presenter = new SchoolYearDetailsPresenter(this);
        }

        public SchoolYearModel? SchoolYear
        {
            get => _sy;
            set
            {
                if (value == null)
                {
                    foreach (Control control in this.Controls)
                    {
                        control.Visible = false;
                    }
                    NoSchoolYear.Visible = true;
                    NoSchoolYear.BringToFront();
                    _sy = null!;
                    return;
                }

                foreach (Control control in this.Controls)
                {
                    control.Visible = true;
                }
                NoSchoolYear.Visible = false;
                _sy = value;
                LoadSchoolYearDetails(value);
                LoadSemesters();
            }
        }

        public event EventHandler AddSemesterClick
        {
            add => _addSemesterButton.Click += value;
            remove => _addSemesterButton.Click -= value;
        }

        private void LoadSchoolYearDetails(SchoolYearModel model)
        {
            if (model == null) throw new Exception("School year model cannot be null.");

            _syBannerContainer.Controls.Clear();
            var uc = new SchoolYearPhaseUserControl() { Dock = DockStyle.Fill, SchoolYear = model };
            _syBannerContainer.Controls.Add(uc);
        }
        private void LoadSemesters()
        {
            if (_sy == null) return;
            _semestersContainer.Controls.Clear();
            if (_sy.Terms == null || _sy.Terms.Count == 0)
            {
                _semestersContainer.Controls.Add(new Label()
                {
                    Text = "No semesters available",
                    Dock = DockStyle.Fill,
                    BackColor = SystemColors.Control,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 14, FontStyle.Italic),
                    ForeColor = SystemColors.GrayText
                });
                return;
            }

            var tabControl = new TabControl();
            foreach (var semester in _sy.Terms)
            {
                var tabPage = new TabPage(semester.TermName)
                {
                    Dock = DockStyle.Fill,
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoScroll = true
                };
                tabControl.TabPages.Add(tabPage);

                var uc = new SemesterUC(semester)
                {
                    Dock = DockStyle.Fill
                };

                tabPage.Controls.Add(uc);
            }
            tabControl.Dock = DockStyle.Fill;   
            _semestersContainer.Controls.Add(tabControl);
        }
        public void RefreshInput()
        {
            //_sy = _sy!;
            LoadSemesters();
        }
    }

    public interface ISchoolYearDetailsUC
    {
        SchoolYearModel? SchoolYear { get; set; }
        event EventHandler AddSemesterClick;
        void RefreshInput();
    }

    public class SchoolYearDetailsPresenter
    {
        private readonly ISchoolYearDetailsUC _view;
        public SchoolYearDetailsPresenter(ISchoolYearDetailsUC view)
        {
            _view = view;
            WireEvents();
        }

        private void WireEvents()
        {
            _view.AddSemesterClick += AddSemesterButton_Click;
        }

        private void AddSemesterButton_Click(object? sender, EventArgs? e)
        {
            using (var dialog = new SemesterCreationDialog())
            {
                dialog.Text = "Create a new semester";
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var semester = dialog.Value;
                    if(_view.SchoolYear == null)
                    {
                        MessageBox.Show("No school year selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    semester.SchoolYearId = _view.SchoolYear.SchoolYearId;
                    if(_view.SchoolYear.Terms == null)
                    {
                        _view.SchoolYear.Terms = new List<TermModel>();
                    }
                    else if (_view.SchoolYear.Terms.Any(s => s.TermName == semester.TermName))
                    {
                        MessageBox.Show("A semester with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _view.SchoolYear.Terms.Add(semester);
                    SchoolYearRepo.AddSemesterToSchoolYear(_view.SchoolYear.SchoolYearId, semester);
                    _view.RefreshInput();
                }
            }
        }
    }
}
