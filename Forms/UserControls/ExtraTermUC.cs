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
    public partial class ExtraTermUC : UserControl, IExtraTermUC
    {
        private TermModel _term = null!;
        public ExtraTermUC(TermModel model)
        {
            InitializeComponent();
            Term = model;
        }

        public TermModel Term
        {
            get => _term;
            set
            {
                _term = value;
                string termName = (String.IsNullOrWhiteSpace(_term.TermName)) ? "Unnamed Term" : _term.TermName;
                _termName.Text = termName;
                _termNameHeader.Text = $"{termName} Configuration";
            }
        }
    }

    public interface IExtraTermUC
    {
        TermModel Term { get; set; }
    }
}
