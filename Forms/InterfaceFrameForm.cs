using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core;
using Finals.Core.Admin.AdminAccountsCRUD;
using Finals.Forms.UserControls;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Forms
{
    public partial class InterfaceFrameForm : Form, IInterfaceFrame
    {
        private Action _navItem_OnClick = null!;
        private Action _navItem_OnPush = null!;
        private Action<IFeature> _feature_OnRegister = null!;
        private Action<IFeature> _feature_OnSwap = null!;
        private Action _viewSwap = null!;
        private UserModel _user;
        //private IFeature _curr = null!;
        public InterfaceFrameForm(UserModel user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = Screen.FromHandle(this.Handle).WorkingArea;
            _user = user;
            var presenter = new InterfaceFramePresenter(this);

            AdjustLayout();
        }

        public Action NavItemOnClick { get => _navItem_OnClick; set => _navItem_OnClick = value; }
        public Action NavItemOnPush { get => _navItem_OnPush; set => _navItem_OnPush = value; }
        public Action<IFeature> OnFeatureRegister { get => _feature_OnRegister; set => _feature_OnRegister = value; }
        public Action<IFeature> OnFeatureSwap { get => _feature_OnSwap; set => _feature_OnSwap = value; }
        public Action ViewSwapBehavior { get => _viewSwap; set => _viewSwap = value; }
        public string CurrentFeatureTitle { get => FeatureName.Text; set => FeatureName.Text = value; }
        public string CurrentFeatureDescription { get => FeatureDescription.Text; set => FeatureDescription.Text = value; }
        public Panel ProjectionArea { get => MainContentArea; }

        public FlowLayoutPanel Sidebar => this.SidebarMain;

        Panel IInterfaceFrame.MainContentArea => MainArea;

        public UserModel CurrentUser { get => _user; set => _user = value; }

        public void PushToNav(UserControl userControl)
        {
            _navItem_OnPush?.Invoke();
        }

        public void RegisterFeature(IFeature feature)
        {
            _feature_OnRegister?.Invoke(feature);
        }

        public void Swap(IFeature feature)
        {

        }

        private void InterfaceFrameForm_Load(object sender, EventArgs e)
        {

        }

        private void AdjustLayout()
        {
            // 1. Set sidebar width to 20% of Form
            SidebarArea.Width = (int)(this.ClientSize.Width * 0.2);

            // 2. The panelMain is already docked to Fill, so no need to resize

            // 3. Set panelContent width to golden ratio of panelMain
            double goldenRatio = 0.75;
            int contentWidth = (int)(MainArea.ClientSize.Width * goldenRatio);
            int contentHeight = MainArea.ClientSize.Height; // or desired height

            ContentArea.Size = new Size(contentWidth, contentHeight);

            // 4. Center horizontally
            ContentArea.Left = (MainArea.ClientSize.Width - contentWidth) / 2;
            ContentArea.Top = 0; // or center vertically if needed


        }

        private void MainArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new Form())
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.ShowDialog(this);
            }
        }
    }

}
