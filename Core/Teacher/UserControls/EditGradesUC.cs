using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Teacher.UserControls
{
    public partial class EditGradesUC : UserControl, IEditGradesUC
    {
        public EditGradesUC()
        {
            InitializeComponent();
        }

        public string StudentName
        {
            get => label1.Text.Trim();
            set => label1.Text = value.Trim();
        }
        public string StudentGrade
        {
            get => textBox1.Text.Trim();
            set => textBox1.Text = value.Trim();
        }


        public event EventHandler EditClick
        {
            add => EditButton.Click += value;
            remove => EditButton.Click -= value;
        }

    }

    public interface IEditGradesUC
    {
        string StudentName { get; set; }
        string StudentGrade { get; set; }
        event EventHandler EditClick;
    }
}
