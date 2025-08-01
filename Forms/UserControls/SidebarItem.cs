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
    public partial class SidebarItem : UserControl, ISidebarItem
    {
        private bool _isActive = false;
        private Color _defaultInactive = SystemColors.ControlDark;
        private Color _defaultActive = SystemColors.HighlightText;

        public event EventHandler SidebarClick
        {
            add
            {
                this.Click += value;
                foreach (Control control in this.Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                this.Click -= value;
                foreach (Control control in this.Controls)
                {
                    control.Click -= value;
                }
            }
        }
        public SidebarItem(SidebarItemConfig config = null!)
        {
            InitializeComponent();

            SidebarTitle.MouseEnter += (sender, e) =>
            {
                SidebarTitle.ForeColor = (config != null) ? config.HoverColor : _defaultActive;
            };

            SidebarTitle.MouseLeave += (sender, e) =>
            {
                if (_isActive)
                {
                    SidebarTitle.ForeColor = (config != null) ? config.ActiveColor : _defaultActive;
                }
                else
                {
                    SidebarTitle.ForeColor = (config != null) ? config.InactiveColor : _defaultInactive;
                }
            };

        }

        public string Title { get => SidebarTitle.Text; set => SidebarTitle.Text = value; }
        public bool IsActive 
        { 
            get => _isActive; 
            set 
            {
                if (value)
                {
                    _isActive = value;
                    Highlight.Visible = true;
                    SidebarTitle.ForeColor = _defaultActive;
                } else
                {
                    _isActive = value;
                    Highlight.Visible = false;
                    SidebarTitle.ForeColor = _defaultInactive;
                }
            } 
        }

        private void SidebarTitle_Click(object sender, EventArgs e)
        {

        }
    }

    public interface ISidebarItem
    {
        string Title { get; set; }
        //Image image { get; set;  }
        bool IsActive { get; set; }
    }

    public class SidebarItemConfig
    {
        public Color ActiveColor { get; set; } = SystemColors.ActiveCaptionText;
        public Color InactiveColor { get; set; } = SystemColors.InactiveCaptionText;
        public Color HoverColor { get; set; } = SystemColors.ControlDarkDark;
    }
}
