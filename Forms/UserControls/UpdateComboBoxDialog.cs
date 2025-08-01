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
    public partial class UpdateComboBoxDialog : Form, IIUpdateComboBoxDialog
    {
        private Dictionary<int, string> data = new Dictionary<int, string>();
        public UpdateComboBoxDialog(IEnumerable<string> strings)
        {
            if (strings.Count() == 0)
            {
                throw new ArgumentException("The collection of strings cannot be empty.", nameof(strings));
            }
            InitializeComponent();
            PopulateData(strings);
        }

        public string Value
        {
            get => comboBox1.SelectedItem?.ToString() ?? string.Empty;
        }

        private void PopulateData(IEnumerable<string> strings)
        {
            for (int i = 0; i < strings.Count(); i++)
            {
                data.Add(i, strings.ElementAt(i));
                comboBox1.Items.Add(strings.ElementAt(i));
            }

            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    public interface IIUpdateComboBoxDialog
    {
        string Value { get; }
    }
}
