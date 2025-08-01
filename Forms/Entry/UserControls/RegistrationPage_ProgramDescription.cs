using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Forms.Entry.UserControls
{
    public partial class RegistrationPage_ProgramDescription : UserControl, IRegistrationPage_ProgramDescription
    {
        private Action _back = null!;
        private Action _next = null!;
        public RegistrationPage_ProgramDescription()
        {
            InitializeComponent();
            var presenter = new RegistrationPage_ProgramDescription_Presenter(this);
        }

        public Action OnBack { get => _back; set => _back = value; }
        public Action OnNext { get => _next; set => _next = value; }

        public event EventHandler BackClick
        {
            add
            {
                button1.Click += value;
            }

            remove
            {
                button1.Click -= value;
            }
        }
        public event EventHandler NextClick
        {
            add
            {
                button2.Click += value;
            }
            remove
            {
                button2.Click -= value;
            }
        }
    }

    public interface IRegistrationPage_ProgramDescription
    {
        Action OnBack { get; set; }
        Action OnNext { get; set; }
        event EventHandler BackClick;
        event EventHandler NextClick;
    }

    public class RegistrationPage_ProgramDescription_Presenter
    {
        private readonly IRegistrationPage_ProgramDescription _view;

        public RegistrationPage_ProgramDescription_Presenter(IRegistrationPage_ProgramDescription view)
        {
            _view = view;
            WireEvents();
        }

        private void WireEvents()
        {
            _view.BackClick += (_, _) => _view.OnBack?.Invoke();
            _view.NextClick += (_, _) => _view.OnNext?.Invoke();
        }
    }
}
