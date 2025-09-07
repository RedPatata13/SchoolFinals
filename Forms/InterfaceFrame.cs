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
using Finals.Core.FeatureRegister;
using Finals.Core.Student.StudentRegistration;
using Finals.Forms.UserControls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Finals.Models;

namespace Finals.Forms
{
    public partial class InterfaceFrame : UserControl, IInterfaceFrame
    {
        private Action _navItem_OnClick = null!;
        private Action _navItem_OnPush = null!;
        private Action<IFeature> _feature_OnRegister = null!;
        private Action<IFeature> _feature_OnSwap = null!;
        private Action _viewSwap = null!;
        //private IFeature _curr = null!;
        public InterfaceFrame()
        {
            InitializeComponent();
            var presenter = new InterfaceFramePresenter(this);
        }

        public Action NavItemOnClick { get => _navItem_OnClick; set => _navItem_OnClick = value; }
        public Action NavItemOnPush { get => _navItem_OnPush; set => _navItem_OnPush = value; }
        public Action<IFeature> OnFeatureRegister { get => _feature_OnRegister; set => _feature_OnRegister = value; }
        public Action<IFeature> OnFeatureSwap { get => _feature_OnSwap; set => _feature_OnSwap = value; }
        public Action ViewSwapBehavior { get => _viewSwap; set => _viewSwap = value; }
        public string CurrentFeatureTitle { get => FeatureName.Text; set => FeatureName.Text = value; }
        public string CurrentFeatureDescription { get => FeatureDescription.Text; set => FeatureDescription.Text = value; }
        public Panel ProjectionArea { get => MainContentArea; }

        public FlowLayoutPanel Sidebar => this.Sidebar;

        public UserModel CurrentUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Panel IInterfaceFrame.MainContentArea => MainArea;

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
    }

    public interface IInterfaceFrame
    {
        string CurrentFeatureTitle { get; set; }
        string CurrentFeatureDescription { get; set; }
        Panel ProjectionArea { get; }
        Panel MainContentArea { get; }
        FlowLayoutPanel Sidebar { get; }
        Action NavItemOnClick { get; set; }
        Action NavItemOnPush { get; set; }
        Action<IFeature> OnFeatureRegister { get; set; }
        Action<IFeature> OnFeatureSwap { get; set; }
        Action ViewSwapBehavior { get; set; }
        UserModel CurrentUser { get; set; }
        void RegisterFeature(IFeature feature);
        void Swap(IFeature feature);
        void PushToNav(UserControl userControl);
    }
    public class InterfaceFramePresenter
    {
        private readonly IInterfaceFrame _view;
        private Stack<UserControl> _ucStack = new();
        private IFeature _currentFeature = null!;
        private SidebarItem _currentSidebarItem = null!;
        public InterfaceFramePresenter(IInterfaceFrame view)
        {
            _view = view;
            WireEvents();

            _view.Sidebar.Controls.Clear();
            RegisterFeatures();
        }
        private void RegisterFeatures()
        {
            IFeatureRegistrator register = null!;
            switch (_view.CurrentUser.UserRole)
            {
                case UserRole.Admin:
                    register = new FeatureRegister_Admin(_view.CurrentUser);
                    break;
                case UserRole.Teacher:
                    register = new FeatureRegister_Teacher(_view.CurrentUser);
                    break;
                case UserRole.Student:
                    register = new FeatureRegister_Student();
                    break;
                default:
                    throw new Exception("Invalid User Type");
            }
            register.RegisterFeatures(_view);
        }
        private void FeatureSwap(IFeature feature)
        {
            _currentFeature = feature;
            _view.MainContentArea.SuspendLayout();
            _view.ViewSwapBehavior = MainUserControlSwap;
            MainUserControlSwap();
            UpdateViewHeader(feature);
            _view.MainContentArea.ResumeLayout();

            void MainUserControlSwap()
            {
                _view.ProjectionArea.Controls.Clear();
                _currentFeature.UserControl.Dock = DockStyle.Top;
                _view.ProjectionArea.Controls.Add(_currentFeature.UserControl);
            }

            void UpdateViewHeader(IFeature feature)
            {
                _view.CurrentFeatureTitle = feature.Name;
                _view.CurrentFeatureDescription = feature.Description;
            }
        }
        
        private void WireEvents()
        {
            _view.OnFeatureSwap = FeatureSwap;
            _view.OnFeatureRegister = RegisterFeature;
        }

        private void RegisterFeature(IFeature feature)
        {
            //_view.Sidebar.Controls.Add

            SidebarItem sidebarItem = new SidebarItem();
            sidebarItem.Title = feature.Name;
            sidebarItem.Size = new Size(_view.Sidebar.Width, sidebarItem.Height);
            sidebarItem.SidebarClick += (_, _) =>
            {
                if(_currentSidebarItem != null)
                {
                    _currentSidebarItem.IsActive = false;
                }

                _currentSidebarItem = sidebarItem;
                _currentSidebarItem.IsActive = true;
                FeatureSwap(feature);
            };
            _view.Sidebar.Controls.Add(sidebarItem);
        }
    }

}
