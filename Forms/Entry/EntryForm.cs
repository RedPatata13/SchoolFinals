using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Forms.Entry.UserControls;

namespace Finals.Forms
{
    public partial class EntryForm : Form, IEntryForm
    {
        private EntryHome _eh = new EntryHome();
        private LoginPage _loginPage = new();
        private RegistrationPage _registrationPage = new();
        public EntryForm()
        {
            InitializeComponent();
            var presenter = new EntryFormPresenter(this);
        }

        public LoginPage LoginPage { get => _loginPage; set => _loginPage = value; }
        EntryHome IEntryForm.EntryHome => _eh;

        //LoginPage IEntryForm.LoginPage => 

        RegistrationPage IEntryForm.RegistrationPage => _registrationPage;

        EntryForm IEntryForm.MainForm => this;

        public void SwapToMainInterface()
        {

        }

        void IEntryForm.SwapPage(UserControl uc)
        {
            this.SuspendLayout();
            Controls.Clear();
            Controls.Add(uc);
            
            this.ResumeLayout();
        }
    }

    public interface IEntryForm
    {
        EntryHome EntryHome { get; }
        LoginPage LoginPage { get; set;  }
        RegistrationPage RegistrationPage { get; }
        EntryForm MainForm { get; }
        void SwapPage(UserControl uc);
        void SwapToMainInterface();
    }

    public class EntryFormPresenter
    {
        private readonly IEntryForm _view;
        public EntryFormPresenter(IEntryForm view)
        {
            _view = view;
            WireEvents();
            _view.MainForm.Controls.Add(_view.EntryHome);
            
        }
        private void WireEvents()
        {
            if(_view is EntryForm container)
            {
                if (_view.LoginPage is ILoginPage loginPage)
                {
                    loginPage.Container = container;
                }
                else throw new Exception("Invalid type");
            } else throw new Exception("Invalid type");
            EntryHome_LoginClick();
            EntryHome_RegistrationClick();
            LoginPage_BackClick();
            RegistrationPage_BackClick();
            //LoginPage_LoginClick();
        }

        private void EntryHome_LoginClick()
        {
            _view.EntryHome.LoginClick = () => _view.SwapPage(_view.LoginPage);
        }

        private void EntryHome_RegistrationClick()
        {
            _view.EntryHome.RegistrationClick= () => _view.SwapPage(_view.RegistrationPage);
        }

        private void LoginPage_BackClick()
        {
            _view.LoginPage.BackClick = () => _view.SwapPage(_view.EntryHome);
        }

        private void RegistrationPage_BackClick()
        {
            _view.RegistrationPage.BackClick = () => _view.SwapPage(_view.EntryHome);
        }


    }
}
