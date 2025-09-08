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

namespace Finals.Core.Teacher.UserControls
{
    public partial class StudentCollectionGradesEditDialog : Form, IStudentCollectionGradesEditDialog
    {
        private List<AssignedCourseGrade> _selectedStudents = new List<AssignedCourseGrade>();
        private List<AssignedCourseGrade> _unselectedStudents = new List<AssignedCourseGrade>();
        public StudentCollectionGradesEditDialog(List<AssignedCourseGrade> unselectedStudents)
        {
            InitializeComponent();
            UnselectedStudents = unselectedStudents ?? new List<AssignedCourseGrade>();
        }

        public ICollection<AssignedCourseGrade> UnselectedStudents
        {
            get => _unselectedStudents;
            set
            {
                _unselectedStudents = value.ToList() ?? new List<AssignedCourseGrade>();
                RenderUnselectedStudents();
            }
        }
        public ICollection<AssignedCourseGrade> SelectedStudents
        {
            get => _selectedStudents;
            set
            {
                _selectedStudents = value.ToList() ?? new List<AssignedCourseGrade>();
                RenderSelectedStudents();
            }
        }

        public void RenderSelectedStudents()
        {
            _selectedStudentsDGV.Rows.Clear();
            var selectedStudentList = _selectedStudents.Select(s => s.Student);
            foreach (var student in selectedStudentList)
            {
                var row = new DataGridViewRow();
                row.CreateCells(_selectedStudentsDGV, student.StudentID, student.ToString(), "N/A", "Remove");

                row.Tag = student;
                _selectedStudentsDGV.Rows.Add(row);
            }
        }

        public void RenderUnselectedStudents()
        {
            _unselectedStudentsDGV.Rows.Clear();
            var unselectedStudentList = _unselectedStudents.Select(s => s.Student);
            foreach (var student in unselectedStudentList)
            {
                var row = new DataGridViewRow();
                row.CreateCells(_unselectedStudentsDGV, student.StudentID, student.ToString(), "N/A", "Add");

                row.Tag = student;
                _unselectedStudentsDGV.Rows.Add(row);
            }
        }

        public void SelectStudent(AssignedCourseGrade student)
        {
            _unselectedStudents.Remove(student);
            _selectedStudents.Add(student);
            RenderStudents();
        }

        public void UnselectStudent(AssignedCourseGrade student)
        {
            _selectedStudents.Remove(student);
            _unselectedStudents.Add(student);
            RenderStudents();
        }

        private void RenderStudents()
        {
            RenderSelectedStudents();
            RenderUnselectedStudents();
        }

        private void _selectedStudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int buttonColumnIndex = _selectedStudentsDGV.Columns.Count - 1;
            if (e.ColumnIndex == buttonColumnIndex)
            {
                var student = _selectedStudentsDGV.Rows[e.RowIndex].Tag as AssignedCourseGrade;
                if (student != null)
                {
                    UnselectStudent(student);
                }
            }
        }

        private void _unselectedStudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int buttonColumnIndex = _unselectedStudentsDGV.Columns.Count - 1;
            if (e.ColumnIndex == buttonColumnIndex)
            {
                var student = _unselectedStudentsDGV.Rows[e.RowIndex].Tag as AssignedCourseGrade;
                if (student != null)
                {
                    SelectStudent(student);
                }
            }
        }
    }
    public interface IStudentCollectionGradesEditDialog
    {
        ICollection<AssignedCourseGrade> UnselectedStudents { get; set; }
        ICollection<AssignedCourseGrade> SelectedStudents { get; set; }    

        void SelectStudent(AssignedCourseGrade student);
        void UnselectStudent(AssignedCourseGrade student);

        void RenderSelectedStudents();
        void RenderUnselectedStudents();
    }
}
