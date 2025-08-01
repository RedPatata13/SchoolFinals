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
    public partial class AdminCourseManagement_Container : UserControl
    {
        public AdminCourseManagement_Container()
        {
            InitializeComponent();
            this.Controls.Add(new AdminCourseManagement_LandingPage());
        }
    }
}
