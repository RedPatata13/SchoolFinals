using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Forms
{
    public static class Projector
    {
        public static void Project(Control container, Control child)
        {
            container.SuspendLayout();
            container.Controls.Clear();
            container.Controls.Add(child);
            child.Location = new Point(0, 0);
            container.AutoScrollOffset = new Point(0, 0);
            //child.Dock = DockStyle.Fill;
            container.ResumeLayout();
        }
    }
}
