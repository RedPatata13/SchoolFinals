using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Teacher.TeacherCourseTasks
{
    public partial class TeacherCourseTasks_Main : UserControl
    {
        public TeacherCourseTasks_Main()
        {
            InitializeComponent();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            using (var popup = new TaskDetailsDialog())
            {
                popup.ShowDialog(this);
                popup.StartPosition = FormStartPosition.CenterParent;
                
            };
        }
    }
}
