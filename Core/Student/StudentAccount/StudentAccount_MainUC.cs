using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Student.StudentAccount
{
    public partial class StudentAccount_MainUC : UserControl
    {
        public StudentAccount_MainUC()
        {
            InitializeComponent();
            Controls.Add(new StudentAccount_LandingPage());
        }
    }
}
