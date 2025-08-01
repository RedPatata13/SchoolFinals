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
    public partial class UpdateStringDialog : Form, IUpdateStringDialog
    {
        public string OldValue { get => textBox1.Text; set => textBox1.Text = value ?? "--Not Set--"; }
        public string NewValue { get => textBox2.Text; set => textBox2.Text = value; }

        public UpdateStringDialog()
        {
            InitializeComponent();
        }

        public UpdateStringDialog(string oldValue) : this()
        {
            OldValue = oldValue;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                button2.Enabled = false;
                button2.BackColor = SystemColors.ScrollBar;
                button2.ForeColor = SystemColors.GrayText;
                label3.Visible = true;
            } else
            {
                button2.Enabled = true;
                button2.BackColor = SystemColors.Highlight;
                button2.ForeColor = SystemColors.HighlightText;
                //label3.Visible = true;
            }
        }
    }

    public interface IUpdateStringDialog
    {
        string OldValue { get; set; }
        string NewValue { get; set; }
    }
}
