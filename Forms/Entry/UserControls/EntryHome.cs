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
    public partial class EntryHome : UserControl, IEntryHome
    {
        private Action _loginClick = null!;
        private Action _registrationClick = null!;
        private Action _entry = null!;
        public EntryHome()
        {
            InitializeComponent();
            var presenter = new EntryHomePresenter(this);
        }

        public Action? LoginClick { get => _loginClick; set => _loginClick = value!; }
        public Action? RegistrationClick { get => _registrationClick; set => _registrationClick = value!; }
        public Action? Entry { get => _entry; set => _entry = value!; }

        event EventHandler IEntryHome.OnLoginClick
        {
            add
            {
                LoginPanel.Click += value;
            }

            remove
            {
                LoginPanel.Click -= value;
            }
        }

        event EventHandler IEntryHome.OnRegistrationClick
        {
            add
            {
                RegistrationPanel.Click += value;
            }

            remove
            {
                RegistrationPanel.Click -= value;
            }
        }

        private void LoginPanel_MouseEnter(object sender, EventArgs e)
        {
            LoginPanel.BackColor = Color.LightGray;
        }
        private void LoginPanel_MouseLeave(object sender, EventArgs e)
        {
            LoginPanel.BackColor = Color.White;
        }
        private void RegistrationPanel_MouseEnter(object sender, EventArgs e)
        {
            RegistrationPanel.BackColor = Color.LightGray;
        }

        private void RegistrationPanel_MouseLeave(object sender, EventArgs e)
        {
            RegistrationPanel.BackColor = Color.White;
        }
    }

    public interface IEntryHome
    {
        public Action? LoginClick { get; set; }
        public Action? RegistrationClick {  get; set; }
        public Action? Entry {  get; set; }

        event EventHandler OnLoginClick;
        event EventHandler OnRegistrationClick;
    }

    public class EntryHomePresenter
    {
        private readonly IEntryHome _view;
        public EntryHomePresenter(IEntryHome view)
        {
            _view = view;
            WireEvents();
        }

        private void WireEvents()
        {
            _view.OnLoginClick += (_, _) => _view.LoginClick?.Invoke();
            _view.OnRegistrationClick += (_, _) => _view.RegistrationClick?.Invoke();
        }

    }
}
