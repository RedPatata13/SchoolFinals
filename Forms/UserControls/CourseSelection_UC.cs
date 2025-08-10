using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Models;

namespace Finals.Forms.UserControls
{
    public partial class CourseSelection_UC : UserControl, ICourseSelection_UC
    {
        private CourseModel _value;
        public CourseSelection_UC(CourseModel value)
        {
            InitializeComponent();
            _value = value;
        }

        public CourseModel Value 
        { 
            get => _value; 
            set
            {
                _value = value;
                label1.Text = _value.CourseName ?? "Unnamed Course";
            }
        }
        public bool isSelected { get => checkBox1.Checked; }

        public event EventHandler OnCheck
        {
            add => checkBox1.CheckedChanged += value;
            remove => checkBox1.CheckedChanged -= value;
        }
    }

    public interface ICourseSelection_UC
    {
        CourseModel Value { get; }
        bool isSelected { get; }
        event EventHandler OnCheck;
    }
}
