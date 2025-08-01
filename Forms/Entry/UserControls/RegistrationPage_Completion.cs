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
    public partial class RegistrationPage_Completion : UserControl, IRegistrationPage_Completion
    {
        private Action _back = null!;
        public RegistrationPage_Completion()
        {
            InitializeComponent();
            var presenter = new RegistrationPage_Completion_Presenter(this);
        }

        public Action Back
        {
            get { return _back; }
            set { _back = value; }
        }

        public event EventHandler BackPressed
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

    public interface IRegistrationPage_Completion
    {
        Action Back { get; set;  }
        event EventHandler BackPressed;
    }

    public class RegistrationPage_Completion_Presenter
    {
        private readonly IRegistrationPage_Completion _view;
        public RegistrationPage_Completion_Presenter(IRegistrationPage_Completion view)
        {
            _view = view;
            WireEvents();
        }

        private void WireEvents()
        {
            _view.BackPressed += (_, _) => _view.Back?.Invoke();
        }
    }
}
