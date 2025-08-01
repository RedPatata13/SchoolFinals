using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core.Teacher.UserControls;

namespace Finals.Core.Teacher.TeacherCoursesPage
{
    public partial class TeacherCoursePage_MainContainer : UserControl
    {
        public TeacherCoursePage_MainContainer()
        {
            InitializeComponent();
            panel3.Controls.Add(new CoursePanel());
        }
    }
}
