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
        public AdminCourseManagement_Container(string userId)
        {
            InitializeComponent();
            var page = new AdminCourseManagement_LandingPage(userId);
            page.Dock = DockStyle.Fill;
            this.Controls.Add(page);
        }
    }
}
