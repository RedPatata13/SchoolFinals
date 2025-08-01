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

namespace Finals.Core.Teacher.UserControls
{
    public partial class CoursePanel : UserControl, ICoursePanel
    {
        private bool _isOngoing = false;
        private Action _onOngoingCheck = null!;
        private IHoverEffects _hoverEffects = new HoverEffect();
        private IHoverEffects _ongoingHoverEffects = new HoverEffect() { MouseEnter = Color.SlateBlue };
        public override Color BackColor 
        {
            get => MainPanel.BackColor;
            set => MainPanel.BackColor = value;
        }
        public bool IsOngoing 
        { 
            get => _isOngoing;
            set
            {
                _isOngoing = value;
                _onOngoingCheck?.Invoke();
            }
        }
        public IHoverEffects DefaultHoverEffects
        {
            get => _hoverEffects;
            set
            {
                _hoverEffects = value;
                value.ApplyEvents(this);
            }
        }

        public Action OnOngoingChanged
        {
            get => _onOngoingCheck;
            set => _onOngoingCheck = value;
        }
        //public IHoverEffects OngoingHoverEffects { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CoursePanel()
        {
            InitializeComponent();
            var presenter = new CoursePanelPresenter(this);
        }
    }

    public interface ICoursePanel
    {
        bool IsOngoing { get; set; }
        Action OnOngoingChanged { get; set; }
        IHoverEffects DefaultHoverEffects { get; set; }
        //IHoverEffects OngoingHoverEffects { get; set; }
    }

    public class CoursePanelPresenter
    {
        private readonly ICoursePanel _view;
        private Color _ongoingBackColor = SystemColors.Highlight;
        private Color _defaultBackColor = SystemColors.ControlLight;
        public CoursePanelPresenter(ICoursePanel view)
        {
            _view = view;
            WireEvents();
        }

        private void WireEvents()
        {
            if(_view is CoursePanel cp)
            {
                if (_view.IsOngoing)
                {
                    _view.OnOngoingChanged = () =>
                    {
                        DefaultHover(cp);
                    };
                }
                else
                {
                    _view.OnOngoingChanged = () =>
                    {
                        OngoingHover(cp);
                    };
                }
            }

            void DefaultHover(CoursePanel cp)
            {
                cp.BackColor = SystemColors.Highlight;
                _view.DefaultHoverEffects.MouseEnter = _ongoingBackColor;

            }

            void OngoingHover(CoursePanel cp)
            {
                cp.BackColor = SystemColors.ControlLightLight;
                _view.DefaultHoverEffects.MouseEnter = _defaultBackColor;
            }
        }
    }
}
