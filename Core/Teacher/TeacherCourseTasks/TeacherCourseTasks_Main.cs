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
    public partial class TeacherCourseTasks_Main : UserControl, ITeacherCourseTasks_Main
    {
        public TeacherCourseTasks_Main()
        {
            InitializeComponent();
        }

        public event EventHandler BackClick
        {
            add => _backButton.Click += value;
            remove => _backButton.Click -= value;
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

    public interface ITeacherCourseTasks_Main
    {
        event EventHandler BackClick;
    }
}
