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
            }
        }
    }

    public interface IExtraTermUC
    {
        TermModel Term { get; set; }
    }
}
