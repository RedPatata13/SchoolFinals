using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Forms.UserControls;

namespace Finals.Core
{
    public interface IFeature
    {
        bool IsEdited { get; set; }
        //SidebarItem SidebarItem { get; }
        Image Image { get; }
        string Name { get; }
        string Description { get; } 
        UserControl UserControl { get; }
        void PreSwap();
    }

    public class TestFeature : IFeature
    {
        public UserControl _uc = null!;
        public string _name = null!;
        public string _description = null!;
        public bool IsEdited { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Image Image => throw new NotImplementedException();

        public string Name => _name;

        public string Description => _description;

        public UserControl UserControl => _uc;

        public void PreSwap()
        {
            throw new NotImplementedException();
        }
    }
}
