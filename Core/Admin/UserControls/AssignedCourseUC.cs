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

namespace Finals.Core.Admin.UserControls
{
    public partial class AssignedCourseUC : UserControl, IAssignedCourseUC
    {
        private ICollection<CourseModel_Assigned> _courses;
        private int totalUnits = -1;
        private int _currentUnits = -1;

        public int TotalUnits
        { 
            get => totalUnits;
            set
            {
                totalUnits = value;
                _totalUnits.Text = totalUnits.ToString();
            }
        }
        public int RequiredUnits
        {
            get => _currentUnits;
            set
            {
                _currentUnits = value;
                _unitsRequired.Text = _currentUnits.ToString();
            }
        }
        //private ICollection<CourseModel_Assigned> _courses;
        public ICollection<CourseModel_Assigned> Courses
        {
            get => _courses;
            set
            {
                _courses = value;

                // Clear old columns and rows
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                // Define columns
                dataGridView1.Columns.Add("CourseName", "Course Name");
                dataGridView1.Columns.Add("TeacherUsername", "Teacher Username");

                var buttonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Action",
                    Text = "TestButton",
                    UseColumnTextForButtonValue = true,
                    Name = "Action"
                };
                dataGridView1.Columns.Add(buttonColumn);

                // Add rows
                foreach (var ac in _courses)
                {
                    //dataGridView1.Rows.Add(ac.Course.CourseName, ac.Teacher.UserName);
                }

                // Attach button click event
                dataGridView1.CellContentClick -= DataGridView1_CellContentClick; // avoid duplicate handlers
                dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            }
        }

        // Button click handler
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("event added");
            }
        }


        public event EventHandler DeleteButton_Click
        {
            add => _removeButton.Click += value;
            remove => _removeButton.Click -= value;
        }
        public event EventHandler AddButton_Click
        {
            add => _addButton.Click += value;
            remove => _addButton.Click -= value;
        }
        public AssignedCourseUC(ICollection<CourseModel_Assigned> models)
        {
            InitializeComponent();
            _courses = models;
        }

        

        private class IAssignedCourseUCPresenter
        {
            private readonly IAssignedCourseUC _view;
            public IAssignedCourseUCPresenter(IAssignedCourseUC view)
            {
                _view = view;
            }
        }
    }
    public interface IAssignedCourseUC
    {
        event EventHandler DeleteButton_Click;
        event EventHandler AddButton_Click;

        int TotalUnits { get; set; }
        int RequiredUnits { get; set; }

        ICollection<CourseModel_Assigned> Courses { get; set; }
    }
}
