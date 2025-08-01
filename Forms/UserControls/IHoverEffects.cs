using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Forms.UserControls
{
    public interface IHoverEffects
    {
        Color MouseEnter { get; set; }
        Color PrevColor { get; set; }
        void ApplyEvents(Control control);
    }

    public class HoverEffect : IHoverEffects
    {
        private Color _defaultMouseEnterColor = SystemColors.Control;
        private Color _prevColor = Color.Transparent;
        public Color MouseEnter { get => _defaultMouseEnterColor; set => _defaultMouseEnterColor = value; }
        public Color PrevColor { get => _prevColor; set => _prevColor = value; }



        public void ApplyEvents(Control control)
        {
            PrevColor = control.BackColor;

            control.MouseEnter += (_, _) =>
            {
                control.BackColor = MouseEnter;
            };

            control.MouseLeave += (_, _) =>
            {
                control.BackColor = PrevColor;
            };
        }
    }

    public class SimpleHoverEffect : IHoverEffects
    {
        private Color _mouseEnter = Color.Transparent;
        private Color _prevColor = Color.Transparent;
        public Color MouseEnter { get => _mouseEnter; set => _mouseEnter = value; }
        public Color PrevColor { get => _prevColor; set =>  _prevColor = value; }

        public void ApplyEvents(Control control)
        {
            _prevColor = control.BackColor;
            control.MouseEnter += (_, _) =>
            {
                control.BackColor = MouseEnter;
            };

            control.MouseLeave += (_, _) =>
            {
                control.BackColor = PrevColor;
            };
        }

        public SimpleHoverEffect(Color color)
        {
            _mouseEnter = color;
        }
    }
}
