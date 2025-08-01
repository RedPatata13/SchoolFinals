using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Admin.AdminCourseManagement
{
    public partial class AdminCourseManagement_LandingPage : UserControl
    {
        public AdminCourseManagement_LandingPage()
        {
            InitializeComponent();
            comboBox3.SelectedIndex = comboBox2.SelectedIndex = 0;
        }
    }
}
