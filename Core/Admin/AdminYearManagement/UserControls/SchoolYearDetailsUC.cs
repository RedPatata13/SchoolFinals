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
        }

        public SchoolYearModel? SchoolYear 
        {
            get => _sy;
            set
            {
                if(value == null)
                {
                    foreach(Control control in this.Controls)
                    {
                        control.Visible = false;
                    }
                    NoSchoolYear.Visible = true;
                    NoSchoolYear.BringToFront();
                    _sy = null!;
                    return;
                }

                foreach(Control control in this.Controls)
                {
                    control.Visible = true;
                }
                NoSchoolYear.Visible = false;
                _sy = value;
                LoadSchoolYearDetails(value);
            }
        }

        private void LoadSchoolYearDetails(SchoolYearModel model)
        {
            if(model == null) throw new Exception("School year model cannot be null.");

            _syBannerContainer.Controls.Clear();
            var uc = new SchoolYearPhaseUserControl() { Dock = DockStyle.Fill, SchoolYear = model };
            _syBannerContainer.Controls.Add(uc);
        }
    }

    public interface ISchoolYearDetailsUC
    {
        SchoolYearModel? SchoolYear { get; set; }
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

        }
    }
}
