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
        private Dictionary<StudentModel, AssignedCourseGrade> _map = new();
        private Dictionary<int, CourseGrade> _gradeMap = new()
        {
            {0, CourseGrade.NotSet },
            {1, CourseGrade.OnePointZero },
            {2, CourseGrade.OnePointTwentyFive },
            {3, CourseGrade.OnePointFifty },
            {4, CourseGrade.OnePointSeventyFive },
            {5, CourseGrade.TwoPointZero },
            {6, CourseGrade.TwoPointTwentyFive },
            {7, CourseGrade.TwoPointFifty },
            {8, CourseGrade.TwoPointSeventyFive },
            {9, CourseGrade.ThreePointZero },
            {10, CourseGrade.FourPointZero },
            {11, CourseGrade.FivePointZero },
            {12, CourseGrade.INC }
        };
        public StudentCollectionGradesEditDialog(List<AssignedCourseGrade> unselectedStudents)
        {
            InitializeComponent();
            UnselectedStudents = unselectedStudents ?? new List<AssignedCourseGrade>();
            _map = UnselectedStudents.ToDictionary(acg => acg.Student, acg => acg);
            SetGradeComboBox();
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

        public CourseGrade SelectedGrade => _gradeMap.TryGetValue(_gradeComboBox.SelectedIndex, out var grade) ? grade : CourseGrade.NotSet;
        public void RenderSelectedStudents()
        {
            _selectedStudentsDGV.Rows.Clear();
            foreach (var grades in _selectedStudents)
            {
                var row = new DataGridViewRow();
                row.CreateCells(
                    _selectedStudentsDGV,
                    grades.Student.StudentID,
                    grades.Student.ToString(),
                    CourseGradeTranslator.TranslateFromCourseGrade(grades.Grade),
                    "Add");

                row.Tag = grades.Student;
                _selectedStudentsDGV.Rows.Add(row);
            }
        }

        public void RenderUnselectedStudents()
        {
            _unselectedStudentsDGV.Rows.Clear();

            foreach (var grades in _unselectedStudents)
            {
                var row = new DataGridViewRow();
                row.CreateCells(
                    _unselectedStudentsDGV,
                    grades.Student.StudentID,
                    grades.Student.ToString(),
                    CourseGradeTranslator.TranslateFromCourseGrade(grades.Grade),
                    "Remove");

                row.Tag = grades.Student;
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
                var student = _selectedStudentsDGV.Rows[e.RowIndex].Tag as StudentModel;
                if (student != null)
                {
                    UnselectStudent(_map[student]);
                }
            }
            ValidateInput();
        }

        private void _unselectedStudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int buttonColumnIndex = _unselectedStudentsDGV.Columns.Count - 1;
            if (e.ColumnIndex == buttonColumnIndex)
            {
                var student = _unselectedStudentsDGV.Rows[e.RowIndex].Tag as StudentModel;
                if (student != null)
                {
                    SelectStudent(_map[student]);
                    //MessageBox.Show("called");
                }
            }
            ValidateInput();
        }
        private void SetGradeComboBox()
        {
            _gradeComboBox.Items.Clear();
            foreach (var kv in _gradeMap)
            {
                _gradeComboBox.Items.Insert(kv.Key, CourseGradeTranslator.TranslateFromCourseGrade(kv.Value));
            }
            _gradeComboBox.SelectedIndex = 0;
        }

        private void _gradeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void ValidateInput()
        {
            if (_gradeComboBox.SelectedIndex <= 0 ||
                _selectedStudents.Count == 0)
            {
                MainActionButton.BackColor = SystemColors.ScrollBar;
                MainActionButton.ForeColor = SystemColors.Menu;
                MainActionButton.Enabled = false;
            }
            else
            {
                MainActionButton.BackColor = SystemColors.Highlight;
                MainActionButton.ForeColor = SystemColors.HighlightText;
                MainActionButton.Enabled = true;
            }
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
    public interface IStudentCollectionGradesEditDialog
    {
        ICollection<AssignedCourseGrade> UnselectedStudents { get; set; }
        ICollection<AssignedCourseGrade> SelectedStudents { get; set; }    

        void SelectStudent(AssignedCourseGrade student);
        void UnselectStudent(AssignedCourseGrade student);

        void RenderSelectedStudents();
        void RenderUnselectedStudents();

        CourseGrade SelectedGrade { get; }
    }
}
