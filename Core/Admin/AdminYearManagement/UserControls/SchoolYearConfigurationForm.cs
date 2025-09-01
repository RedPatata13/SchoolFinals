using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Forms.UserControls;
using Finals.Models;
using Finals.Services;
using Finals.Services.SY_Services;

namespace Finals.Core.Admin.AdminYearManagement.UserControls
{
    public partial class SchoolYearConfigurationForm : Form, ISchoolYearConfigurationForm
    {
        private SYTemplate SYTemplate = null!;
        private Label NoTerms = new Label()
        {
            Text = "No Terms",
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 12, FontStyle.Italic),

        };

        public SYTemplate Template
        {
            get => SYTemplate;
            set
            {
                SYTemplate = value;
                RenderTerms();
            }
        }

        public SchoolYearConfigurationForm(SYTemplate template)
        {
            InitializeComponent();
            Template = template;
        }

        private void MainActionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SecondaryActiomButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RenderTerms()
        {
            _termsContainer.Controls.Clear();
            if (SYTemplate.TermNames == null || SYTemplate.TermNames.Count == 0)
            {
                _termsContainer.Controls.Add(NoTerms);
                return;
            }
            _termsContainer.Controls.Remove(NoTerms);
            var tabControl = new TabControl()
            {
                Dock = DockStyle.Fill,
            };
            
            var terms = SYTemplateUtil.ConstructTermsFromTemplate(SYTemplate);
            terms.OrderBy(t => t.Precendence == - 1? int.MaxValue : t.Precendence);
            foreach (var term in terms)
            {
                var termUc = new SemesterTemplateUC(term);
                termUc.Dock = DockStyle.Fill;

                var tabPage = new TabPage(term.TermName);
                tabPage.Controls.Add(termUc);

                tabControl.TabPages.Add(tabPage);
            }

            _termsContainer.Controls.Add(tabControl);
        }
    }

    public interface ISchoolYearConfigurationForm
    {
        SYTemplate Template { get; set; }
    }
}
