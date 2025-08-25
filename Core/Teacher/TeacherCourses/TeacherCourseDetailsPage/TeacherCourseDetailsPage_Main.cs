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
using Finals.Models;

namespace Finals.Core.Teacher.TeacherCourseDetailsPage
{
    public partial class TeacherCourseDetailsPage_Main : UserControl, ITeacherCourseDetailsPage_Main
    {
        public TeacherCourseDetailsPage_Main(CourseModel_Assigned course)
        {
            InitializeComponent();
        }

        public event EventHandler BackClick
        {
            add => _backButton.Click += value;
            remove => _backButton.Click -= value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GradesClassification final = new GradesClassification()
            {
                Name = "Final Grade",
                Value = 1,
                Depth = 0
            };

            GradesClassification finalsTerm = new GradesClassification(final)
            {
                Name = "Finals Term",
                Value = 0.6,
                Depth = 0
            };

            GradesClassification midTerm = new GradesClassification(final)
            {
                Name = "Midterm",
                Value = 0.4,
                Depth = 0
            };

            GradesClassification ft_Exam = new GradesClassification(finalsTerm)
            {
                Name = "Exam",
                Value = 0.6,
                Depth = 0
            };

            GradesClassification classStanding = new GradesClassification(finalsTerm)
            {
                Name = "Class Standing",
                Value = 0.4,
                Depth = 0
            };

            var mt_ex = (GradesClassification)ft_Exam.Clone();
            var mt_cs = (GradesClassification)classStanding.Clone();

            mt_cs.Parent = mt_ex.Parent = midTerm;

            midTerm.Children = new List<GradesClassification>();
            midTerm.Children.Add(mt_ex);
            midTerm.Children.Add(mt_cs);

            using (var dialog = new GradesTreeDialog(final))
            {
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.ShowDialog(this);
            }
        }
    }
    public interface ITeacherCourseDetailsPage_Main
    {
        event EventHandler BackClick;
    }
}
