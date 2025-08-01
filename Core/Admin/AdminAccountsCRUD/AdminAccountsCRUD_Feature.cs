using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Forms.UserControls;

namespace Finals.Core.Admin.AdminAccountsCRUD
{
    public class AdminAccountsCRUD_Feature : IFeature
    {
        private bool _edited = false;
        private string _name = "User accounts management.";
        private string _description = "Manage the information of your users.";
        private UserControl _userControl = new AdminAccountsCRUD();
        public bool IsEdited { get => _edited; set => _edited = value; }

        public Image Image => throw new NotImplementedException();

        public string Name => _name;

        public string Description => _description;

        public UserControl UserControl => _userControl;

        public void PreSwap()
        {
            
        }
    }
}
