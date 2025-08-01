using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Models;

namespace Finals.Core.Admin.AdminProgramManagement
{
    public partial class ClassSectionDialog : Form, IClassSectionDialog
    {
        private ICollection<ClassSectionModel> sections = new List<ClassSectionModel>();
        private int yearLevel = 0;

        public event EventHandler CreateClassButtonClick
        {
            add => _createClassButton.Click += value;
            remove => _createClassButton.Click -= value;
        }

        public string SectionName
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public int YearLevel
        {
            get => yearLevel;
            set
            {
                yearLevel = value;
                comboBox1.SelectedIndex = (value <= 5) ? value : 5;
            }
        }

        public ICollection<ClassSectionModel> Value
        {
            get => sections;
            set
            {
                sections = value;
                if (sections != null && sections.Count > 0)
                {
                    //tba update
                }
            }
        }
        public ClassSectionDialog()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            var presenter = new ClassSectionDialogPresenter(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                YearLevel = 0;
            }
            else
            {
                YearLevel = comboBox1.SelectedIndex;
            }
            ValidateFields();
        }
        private void ValidateFields()
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || comboBox1.SelectedIndex == 0)
            {
                _createClassButton.ForeColor = SystemColors.Menu;
                _createClassButton.BackColor = SystemColors.ScrollBar;
                _createClassButton.Enabled = false;
            }
            else
            {
                _createClassButton.ForeColor = SystemColors.HighlightText;
                _createClassButton.BackColor = SystemColors.Highlight;
                _createClassButton.Enabled = true;
            }
        }

        public void UpdateValue()
        {
            if (Value.Count != 0)
            {
                MainActionButton.Enabled = true;
                MainActionButton.BackColor = SystemColors.Highlight;
                MainActionButton.ForeColor = SystemColors.HighlightText;
            }
            else
            {
                MainActionButton.Enabled = false;
                MainActionButton.BackColor = SystemColors.ScrollBar;
                MainActionButton.ForeColor = SystemColors.Menu;
            }
        }

        private string Ordinal(int n)
        {
            if (n % 100 / 10 == 1) return n + "th";
            switch (n % 10)
            {
                case 1: return n + "st";
                case 2: return n + "nd";
                case 3: return n + "rd";
                default: return n + "th";
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

    public interface IClassSectionDialog
    {
        string SectionName { get; set; }
        int YearLevel { get; set; }
        ICollection<ClassSectionModel> Value { get; }

        void UpdateValue();
        event EventHandler CreateClassButtonClick;
    }

    public class ClassSectionDialogPresenter
    {
        private readonly IClassSectionDialog _view;
        public ClassSectionDialogPresenter(IClassSectionDialog view)
        {
            _view = view;
            _view.CreateClassButtonClick += (_, _) =>
            {
                _view.Value.Add(GetModelFromClassCreation());
                _view.UpdateValue();
            };
        }
        private void OnCreateClassButtonClick(object sender, EventArgs e)
        {
            // Logic to handle class creation
            // For example, validate and save the class section
            _view.UpdateValue();
        }

        private ClassSectionModel GetModelFromClassCreation()
        {
            return new ClassSectionModel
            {
                SectionID = String.Empty,
                SectionName = _view.SectionName,
                YearLevel = _view.YearLevel

            };
        }
    }
}
