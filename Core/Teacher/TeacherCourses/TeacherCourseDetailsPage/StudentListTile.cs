using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Forms.UserControls;

namespace Finals.Core.Teacher.TeacherCourses.TeacherCourseDetailsPage
{
    public partial class StudentListTile : UserControl, IStudentListTile
    {

        public StudentListTile()
        {
            InitializeComponent();
            IHoverEffects hover = new SimpleHoverEffect(Color.LightGray);
            hover.ApplyEvents(tableLayoutPanel1);
        }

        public string StudentName
        {
            get => label1.Text;
            set
            {
                label1.Text = value.Trim();
            }
        }

        public string StudentType
        {
            get => label2.Text;
            set
            {
                label2.Text = value.Trim();
            }
        }
    }

    public interface IStudentListTile
    {
        string StudentName { get; set; }
        string StudentType { get; set; }

    }
    
}
