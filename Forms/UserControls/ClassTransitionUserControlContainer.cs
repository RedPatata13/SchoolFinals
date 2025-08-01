using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Models;

namespace Finals.Forms.UserControls
{
    public partial class ClassTransitionUserControlContainer : UserControl, IClassTransitionUserControlContainer
    {
        private ICollection<ClassSectionTransitionModel> _incomingTransitions = new List<ClassSectionTransitionModel>();

        public ICollection<ClassSectionTransitionModel> IncomingTransitions
        {
            get => _incomingTransitions;
            set
            {
                _incomingTransitions = value;
                OnTransitionsUpdate();
            }
        }

        public event EventHandler AddClick
        {
            add => _addEntryButton.Click += value;
            remove => _addEntryButton.Click -= value;
        }

        public event EventHandler ClearAllClick
        {
            add => _clearAllClick.Click += value;
            remove => _clearAllClick.Click -= value;
        }
        public ClassTransitionUserControlContainer()
        {
            InitializeComponent();
        }

        private void OnTransitionsUpdate()
        {
            this.UC_Container.Controls.Clear();
            int y = 2;
            int gap = 4;

            UC_Container.AutoScroll = true;
            _incomingTransitions.ToList().ForEach(e =>
            {
                var uc = new ClassTransitionUC();
                uc.Model = e;
                uc.Size = new Size(this.UC_Container.Width - 30, uc.Height);
                uc.Location = new Point(2, y);
                //uc.Dock = DockStyle.Top;
                uc.Margin = new Padding(0, 0, 0, 5);
                uc.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                this.UC_Container.Controls.Add(uc);

                y += uc.Height + gap;
            });
            //MessageBox.Show($"Transitions updated successfully. {this.Container.Controls.Count}", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _addEntryButton_Click(object sender, EventArgs e)
        {
            //_incomingTransitions.Add(new ClassSectionTransitionModel
            //{
            //    TransitionId = Guid.NewGuid().ToString(),
            //    FromSectionId = string.Empty,
            //    ToSectionId = string.Empty,
            //    TransitionPercentage = 0.0,
            //    IsLocked = false
            //});

            //OnTransitionsUpdate();
        }
    }

    public interface IClassTransitionUserControlContainer
    {
        ICollection<ClassSectionTransitionModel> IncomingTransitions { get; set; }
        event EventHandler AddClick;
        event EventHandler ClearAllClick;
    }

    public class ClassTransitionUserControlContainerPresenter
    {
        private readonly IClassTransitionUserControlContainer _view;
        public ClassTransitionUserControlContainerPresenter(IClassTransitionUserControlContainer view)
        {
            _view = view;
            WireEvents();
        }
        private void WireEvents()
        {
            _view.AddClick += (_, _) => AddNewTransition();
            _view.ClearAllClick += (_, _) => ClearAllTransitions();
        }
        private void AddNewTransition()
        {
            _view.IncomingTransitions.Add(new ClassSectionTransitionModel
            {
                TransitionId = Guid.NewGuid().ToString(),
                FromSectionId = string.Empty,
                ToSectionId = string.Empty,
                TransitionPercentage = 0.0,
                IsLocked = false
            });
        }
        private void ClearAllTransitions()
        {
            _view.IncomingTransitions = new List<ClassSectionTransitionModel>();
        }
    }
}
