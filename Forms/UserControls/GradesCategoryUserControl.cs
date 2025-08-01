using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Forms.UserControls
{
    public partial class GradesCategoryUserControl : UserControl, IGradesCategoryUserControl
    {
        private double _value = -1;
        public GradesCategoryUserControl()
        {
            InitializeComponent();
        }

        public string Title { get => textBox1.Text; set => textBox1.Text = value; }
        public double Value 
        { 
            get => _value;
            set
            {
                _value = value;
                textBox2.Text = _value.ToString();
            }
        }

        public event EventHandler EditButtonClick
        {
            add => _editButton.Click += value;
            remove => _editButton.Click -= value;
        }
        public event EventHandler DeleteButtonClick
        {
            add => _deleteButton.Click+= value;
            remove => _deleteButton.Click -= value;
        }
    }
    public interface IGradesCategoryUserControl
    {
        string Title { get; set; }
        double Value { get; set; }

        event EventHandler EditButtonClick;
        event EventHandler DeleteButtonClick;
    }

}
