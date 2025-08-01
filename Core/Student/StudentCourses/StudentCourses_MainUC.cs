using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Student.StudentCourses
{
    public partial class StudentCourses_MainUC : UserControl
    {
        public StudentCourses_MainUC()
        {
            InitializeComponent();
            this.Controls.Add(new StudentCourses_LandingPage());
        }
    }


}
