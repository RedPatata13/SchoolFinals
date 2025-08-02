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

namespace Finals.Core.Admin
{
    public partial class AdminClassSectionDetails : UserControl, IAdminClassSectionDetails
    {
        private ClassSectionModel _model;
        public AdminClassSectionDetails(ClassSectionModel model)
        {
            InitializeComponent();
            _model = model;
        }

        public ClassSectionModel Model 
        {
            get => _model;
            set {
                _model = value;
            }
        }

        public event EventHandler BackClick
        {
            add => BackButton.Click += value;
            remove => BackButton.Click -= value;
        }
    }

    public interface IAdminClassSectionDetails
    {
        ClassSectionModel Model { get; set; }
        event EventHandler BackClick;
    }
}
