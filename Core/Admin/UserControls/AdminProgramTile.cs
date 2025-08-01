using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Forms.UserControls;
using Finals.Models;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Core.Admin.UserControls
{
    public partial class AdminProgramTile : UserControl, IAdminProgramTile
    {
        private string _title = string.Empty;
        private ProgramModel _model = null!;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                ProgramName.Text = _title;
            }
        }

        public ProgramModel Program 
        {
            get => _model;
            set
            {
                Title = value.ProgramName;
                _model = value;

                if (value.IsOpen)
                {
                    ProgramName.ForeColor = SystemColors.ControlText;
                } 
                else
                {
                    ProgramName.ForeColor = SystemColors.GrayText;
                }
            }
        }

        public event EventHandler ThisClick
        {
            add
            {
                this.Click += value;
                DFS_SetEvents(this, value);
            }
            remove
            {
                this.Click -= value;
                DFS_SetEvents(this, value, false);
            }
        }
        public AdminProgramTile()
        {
            InitializeComponent();
            IHoverEffects hover = new SimpleHoverEffect(SystemColors.Control);
            hover.ApplyEvents(this.mainPanel);
        }

       private void DFS_SetEvents(Control control, EventHandler e, bool add = true)
        {
            foreach(Control c in control.Controls)
            {
                if (add)
                {
                    c.Click += e;
                    DFS_SetEvents(c, e);
                } else
                {
                    c.Click -= e;
                    DFS_SetEvents(c, e, false);
                }
            }
        }
    }
    public interface IAdminProgramTile
    {
        string Title { get; set; }
        ProgramModel Program { get; set; }
        event EventHandler ThisClick;
    }

}
