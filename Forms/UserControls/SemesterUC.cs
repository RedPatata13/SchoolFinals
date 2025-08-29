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
    public partial class SemesterUC : UserControl, ISemesterUC
    {
        private TermModel _model = new TermModel();
        public SemesterUC(TermModel model)
        {
            InitializeComponent();
            Model = model;
        }

        public TermModel Model
        {
            get => _model;
            set => _model = value;
        }
    }

    public interface ISemesterUC
    {
        TermModel Model { get; set; }
    }
}
