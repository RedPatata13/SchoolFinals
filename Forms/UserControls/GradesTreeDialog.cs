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
    public partial class GradesTreeDialog : Form, IGradesTreeDialog
    {
        private GradesClassification _curr = null!;
        private bool _isReadonly = false;
        
        public GradesTreeDialog(GradesClassification root, bool isReadOnly = false)
        {
            InitializeComponent();
            PopulateGradesTree(root);
            _curr = root;
            _isReadonly = isReadOnly;
        }

        public string ClassAndCourseName => throw new NotImplementedException();

        public ICollection<GradesClassification> Classifications => throw new NotImplementedException();

        public GradesClassification CurrentClassification => throw new NotImplementedException();

        public Action DeleteEntry { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Action AddEntry { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler AddButtonClick
        {
            add => AddButton.Click += value;
            remove => AddButton.Click -= value;
        }
        public event EventHandler AddAttendanceButtonClick
        {
            add => AddAttendanceButton.Click += value;
            remove => AddAttendanceButton.Click -= value;
        }

        private void PopulateGradesTree(GradesClassification root, TreeNode? parentNode = null)
        {
            if (root == null) return;
            if (root.Children == null || root.Children.Count() == 0) return;

            var treeNode = new TreeNode(root.Name ?? "Name not set")
            {
                Tag = root
            };

            if (parentNode == null)
            {
                _gradesTree.Nodes.Add(treeNode);
            }
            else
            {
                parentNode.Nodes.Add(treeNode);
            }

            if (root.Children == null) return;

            foreach (var child in root.Children)
            {
                PopulateGradesTree(child, treeNode);
            }
        }

        private void ProjectValues(GradesClassification node)
        {


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is GradesClassification selectedSubject)
            {
                _childrenValues.Controls.Clear();
                _category.Text = selectedSubject.Name;
                _curr = selectedSubject;
                foreach (var child in selectedSubject.Children ?? new List<GradesClassification>())
                {
                    var cat = new GradesCategoryUserControl();
                    cat.Tag = selectedSubject;
                    cat.Dock = DockStyle.Top;

                    cat.Title = child.Name;
                    cat.Value = child.Value;
                    _childrenValues.Controls.Add(cat);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new NewStringDialog("Create new subcategory", "Enter Value: "))
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //_childrenValues.Controls.Add
                    var cat = new GradesCategoryUserControl();
                    cat.Dock = DockStyle.Top;

                    var category = new GradesClassification()
                    {
                        Name = dialog.Value,
                        Depth = _curr.Depth + 1,
                        Parent = _curr,
                        Value = 0
                    };

                    cat.Title = category.Name;
                    cat.Value = category.Value;
                    _childrenValues.Controls.Add(cat);

                    if(_curr.Children == null) _curr.Children = new List<GradesClassification>();
                    _curr.Children.Add(category);
                }
            }
        }
    }

    public interface IGradesTreeDialog
    {
        string ClassAndCourseName { get; }
        ICollection<GradesClassification> Classifications { get; }
        GradesClassification CurrentClassification { get; }

        Action DeleteEntry { get; set; }
        Action AddEntry { get; set; }


        event EventHandler AddButtonClick;
        event EventHandler AddAttendanceButtonClick;
    }

    public class GradesTreeDialogPresenter
    {

    }
}
