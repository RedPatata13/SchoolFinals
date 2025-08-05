using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core.Admin.UserControls;
using Finals.Models;

namespace Finals.Core.Admin.AdminCourseManagement
{
    public partial class CourseCRUDDialog : Form, ICourseCRUDDialog
    {
        private CourseModel _value = null!;

        public event EventHandler SaveCourseClicked
        {
            add => MainActionButton.Click += value;
            remove => MainActionButton.Click -= value;
        }

        public CourseModel Value { 
            get 
            {
                _value.DateCreated = DateTime.Now;
                return _value;
            } 
            set => _value = value; 
        }
        public string CourseDescription
        {
            get => _value.Description;
            set
            {
                _value.Description = value;
                textBox2.Text = value;
            }
        }
        public string CourseName 
        { 
            get => _value.CourseName; 
            set
            {
                _value.CourseName = value;
                textBox1.Text = value;
            }
        }
        public int DefaultUnits 
        { 
            get => _value.DefaultUnits; 
            set 
            {
                int val = (value <= 5 && value > 0) ? value : 0;
                _value.DefaultUnits = val;
                comboBox1.SelectedIndex = val;
            }
        }
        public DateTime DateCreated { get => _value.DateCreated; set => _value.DateCreated = value; }

        public CourseCRUDDialog(CourseModel course = null!)
        {
            InitializeComponent();
            if(course != null)
            {
                _value = course;
                CourseName = course?.CourseName ?? string.Empty;
                CourseDescription = course?.Description ?? string.Empty;
                DefaultUnits = course?.DefaultUnits ?? 0;
                ValidateInput();
            }
            else
            {
                _value = course ?? new CourseModel();
                comboBox1.SelectedIndex = 0;
            }
        }

        private void ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               comboBox1.SelectedIndex == 0)
            {
                MainActionButton.Enabled = false;
                MainActionButton.ForeColor = SystemColors.ScrollBar;
                MainActionButton.BackColor = SystemColors.Menu;
            }
            else
            {
                MainActionButton.Enabled = true;
                MainActionButton.ForeColor = SystemColors.ControlText;
                MainActionButton.BackColor = SystemColors.Highlight;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CourseName = textBox1.Text;
            ValidateInput();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefaultUnits = comboBox1.SelectedIndex;
            ValidateInput();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CourseDescription = textBox2.Text;
            ValidateInput();
        }

        private void MainActionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SecondaryActiomButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    public interface ICourseCRUDDialog
    {
        CourseModel Value { get; set; }
        string CourseDescription { get; set; }
        string CourseName { get; set; }
        int DefaultUnits { get; set; }
        DateTime DateCreated { get; set; }
        event EventHandler SaveCourseClicked;
    }

    public class CourseCRUDDialogPresenter
    {
        private readonly ICourseCRUDDialog _view;
        public CourseCRUDDialogPresenter(ICourseCRUDDialog view)
        {
            _view = view;
        }
        public void LoadCourse(CourseModel course)
        {
            _view.Value = course;
            _view.CourseDescription = course.CourseId;
            _view.CourseName = course.CourseName;
            _view.DefaultUnits = course.DefaultUnits;
            _view.DateCreated = course.DateCreated;
        }
        public void SaveCourse()
        {
            // Logic to save the course
            // This could involve validation and saving to a database
        }
    }
}
