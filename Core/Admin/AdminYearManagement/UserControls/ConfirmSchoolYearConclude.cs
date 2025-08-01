using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Admin.AdminYearManagement.UserControls
{
    public partial class ConfirmSchoolYearConclude : Form
    {
        public ConfirmSchoolYearConclude()
        {
            InitializeComponent();
        }

        private void SecondaryActiomButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Yes, I confirm")
            {
                MainActionButton.Enabled = true;
            }
            else
            {
                MainActionButton.Enabled = false;
            }

            UpdatePrimaryButton();
        }

        private void UpdatePrimaryButton()
        {
            if (MainActionButton.Enabled)
            {
                MainActionButton.BackColor = SystemColors.Highlight;
                MainActionButton.ForeColor = SystemColors.HighlightText;
            }
            else
            {
                MainActionButton.BackColor = SystemColors.ControlLight;
                MainActionButton.ForeColor = Color.LightGray;
            }
        }

        private void MainActionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
