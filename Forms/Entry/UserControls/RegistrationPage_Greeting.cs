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
    public partial class RegistrationPage_Greeting : UserControl, IRegistrationPage_Greeting
    {
        private Action _next = null!;
        public RegistrationPage_Greeting()
        {
            InitializeComponent();
            var presenter = new RegistrationPage_Greeting_Presenter(this);
        }

        public Action Next { get => _next; set => _next = value; }

        public event EventHandler NextClick
        {
            add { button1.Click += value; }
            remove { button1.Click -= value; }
        }
    }

    public interface IRegistrationPage_Greeting
    {
        Action Next { get; set; }
        event EventHandler NextClick;
    }

    public class RegistrationPage_Greeting_Presenter
    {
        private readonly IRegistrationPage_Greeting _view;

        public RegistrationPage_Greeting_Presenter(IRegistrationPage_Greeting view)
        {
            _view = view;

            _view.NextClick += (_, _) => _view.Next?.Invoke();
           
        }
    }
}
