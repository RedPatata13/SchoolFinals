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
    public partial class NewStringDialog : Form, INewStringDialog
    {
        public string Message { get => this.label1.Text; set => this.label1.Text = value; }
        public string Value { get => this.textBox1.Text; set => textBox1.Text = value; }

        public NewStringDialog()
        {
            InitializeComponent();
        }

        public NewStringDialog(string message, string formMessage) : this() { }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBox1.Text))
            {
                button2.Enabled = false;
                button2.BackColor = SystemColors.Menu;
                button2.ForeColor = SystemColors.ScrollBar;
            }
            else
            {
                button2.Enabled = true;
                button2.BackColor = SystemColors.Highlight;
                button2.ForeColor = SystemColors.HighlightText;
            }
        }
    }

    public interface INewStringDialog
    {
        string Message { get; set; }
        string Value { get; set; }
    }
}
