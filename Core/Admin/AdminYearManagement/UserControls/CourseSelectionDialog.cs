using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Admin.AdminYearManagement.UserControls
{
    public partial class CourseSelectionDialog : Form
    {
        public CourseSelectionDialog()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = comboBox3.SelectedIndex = 0;
        }
    }
}
