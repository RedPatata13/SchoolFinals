using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Admin.AdminProgramManagement
{
    public partial class ProgramCreationDialog : Form, IProgramCreationDialog
    {
        public string ProgramName => textBox1.Text;

        public string ProgramDescription => textBox2.Text;

        public ProgramCreationDialog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                MainActionButton.Enabled = true;
                MainActionButton.ForeColor = SystemColors.HighlightText;
                MainActionButton.BackColor = SystemColors.Highlight;
            }
            else
            {
                MainActionButton.Enabled = false;
                MainActionButton.ForeColor = SystemColors.ScrollBar;
                MainActionButton.BackColor = SystemColors.Menu;
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

    public interface IProgramCreationDialog
    {
        string ProgramName { get; }
        string ProgramDescription { get; }
    }
}
