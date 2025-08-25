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

namespace Finals.Core.Teacher.TeacherCoursesPage
{
    public partial class AssignedCourseTile : UserControl, IAssignedCourseTile
    {
        private CourseModel_Assigned _courseModel = null!;

        public event EventHandler TileClicked
        {
            add
            {
                this.Click += value;
                panel1.Click += value;
            } 

            remove
            {
                this.Click -= value;
                panel1.Click -= value;
            }
        }

        public CourseModel_Assigned CourseModel
        {
            get => _courseModel;
            set
            {
                if(value.Course == null)
                {
                    CourseIsNull();
                    return;
                }

                RenderContent(value);
            }
        }
        public AssignedCourseTile(CourseModel_Assigned model)
        {
            
            InitializeComponent();
            CourseModel = model;
            var hover = new SimpleHoverEffect(Color.LightGray);
            hover.ApplyEvents(panel1);
        }

        private void CourseIsNull()
        {
            _courseName.Text = "N/A";
            _schedule.Text = "N/A";
            _statusLabel.Text = String.Empty;
        }

        private void RenderContent(CourseModel_Assigned value)
        {
            _courseModel = value;
            _courseName.Text = value.Course.CourseName ?? "N/A";
            _schedule.Text = (value.Schedules?.FirstOrDefault() is { } first)
            ? first.Location + (value.Schedules!.Count > 1 ? $" {value.Schedules.Count - 1}" : string.Empty)
            : "N/A";
        }
    }

    public interface IAssignedCourseTile
    {
        CourseModel_Assigned CourseModel { get; set; }
        event EventHandler TileClicked;
    }
}
