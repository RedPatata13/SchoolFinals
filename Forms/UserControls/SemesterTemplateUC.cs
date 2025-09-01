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

namespace Finals.Forms.UserControls
{
    public partial class SemesterTemplateUC : UserControl, ISemesterTemplateUC
    {
        private TermModel _term = null!;
        private Label NoExtraTerms = new Label()
        {
            Text = "No Extra Terms",
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 12, FontStyle.Italic),
        };
        public SemesterTemplateUC(TermModel term)
        {
            InitializeComponent();
            _term = term;
        }

        public TermModel Term
        {
            get => _term;
            set
            {
                _term = value;
                RenderExtraTerms();
            }
        }

        private void RenderExtraTerms()
        {
            _extraTermsContainer.Controls.Clear();
            if(_term.ExtraTerms == null || _term.ExtraTerms.Count == 0)
            {
                _extraTermsContainer.Controls.Add(NoExtraTerms);
                return;
            }

            _extraTermsContainer.Controls.Remove(NoExtraTerms);
            var tabControl = new TabControl()
            {
                Dock = DockStyle.Fill,
            };
            foreach (var extraTerm in _term.ExtraTerms)
            {
                var extraTermUC = new SemesterUC(extraTerm);
                extraTermUC.Dock = DockStyle.Fill;

                var tabPage = new TabPage(extraTerm.TermName);
                tabPage.Controls.Add(extraTermUC);

                tabControl.TabPages.Add(tabPage);
            }

            _extraTermsContainer.Controls.Add(tabControl);
        }
    }

    public interface ISemesterTemplateUC
    {
        TermModel Term { get; set; }
    }
}
