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
        private SemesterModel _model = new SemesterModel();
        public SemesterUC(SemesterModel model)
        {
            InitializeComponent();
            Model = model;
        }

        public SemesterModel Model
        {
            get => _model;
            set => _model = value;
        }
    }

    public interface ISemesterUC
    {
        SemesterModel Model { get; set; }
    }
}
