using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finals.Core;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Forms.Entry.UserControls
{
    public partial class LoginPage : UserControl, ILoginPage
    {
        private Action _backClick = null!;
        private Action<UserModel> _loginClick = null!;
        private Form _container = null!;
        public LoginPage()
        {
            InitializeComponent();
            var presenter = new LoginPagePresenter(this);
        }

        public Action BackClick { get => _backClick; set => _backClick = value; }
        public Action<UserModel> LoginClick { get => _loginClick; set => _loginClick = value; }

        public string UID => LoginField.Text;

        public string Password => PasswordField.Text;

        Form ILoginPage.Container { get => _container; set => _container = value; }

        public event EventHandler OnLoginClick
        {
            add
            {
                LoginButton.Click += value;
            }

            remove
            {
                LoginButton.Click -= value;
            }
        }

        public event EventHandler OnBackClick
        {
            add
            {
                BackLink.Click += value;
            }

            remove
            {
                BackLink.Click -= value;
            }
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckbox.Checked)
            {
                PasswordField.PasswordChar = '\0';
            } else
            {
                PasswordField.PasswordChar = '*';
            }
        }
    }
    public interface ILoginPage
    {
        string UID { get; }
        string Password { get; }
        Action BackClick { get; set; }
        Action<UserModel> LoginClick { get; set; }

        event EventHandler OnLoginClick;
        event EventHandler OnBackClick;

        Form Container { get; set; }
    }

    public class LoginPagePresenter
    {
        private readonly ILoginPage _view;
        public LoginPagePresenter(ILoginPage view)
        {
            _view = view;
            _view.OnBackClick += (_, _) => _view.BackClick?.Invoke();
            //_view.OnLoginClick += (_, _) => _view.LoginClick?.Invoke();

            WireEvents();
        }

        private void WireEvents() 
        {
            _view.LoginClick = (model) =>
            {
                var container = _view.Container;
                if (container == null) throw new Exception("Container is not initialized");
                container.Hide();
                InterfaceFrameForm form = new InterfaceFrameForm(model);
                form.ShowDialog();
                form.Dispose();
                container.Show();

            };
            _view.OnLoginClick += (_, _) =>
            {

                var service = LoginPageServiceFactory.Create();

                
                service.OnVerifyResponse = () =>
                {
                    try
                    {
                        switch (service.AuthStatus)
                        {
                            case AuthStatus.Success:
                                _view.LoginClick?.Invoke(service.FoundUser);
                                break;
                            case AuthStatus.NotFound:
                                throw new Exception("Account not found. Please check input and try again.");
                            case AuthStatus.Error:
                                throw new Exception("Password is incorrect.");
                            case AuthStatus.Empty:
                                throw new Exception("Password or UID field is empty. Please try again");
                            default:
                                throw new Exception("Unknown error");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        service.Dispose();
                    }
                };
                service.Authenticate(_view.UID, _view.Password);
            };

        }
    }
    public static class LoginPageServiceFactory
    {
        public static ILoginPageService Create()
        {
            return new LoginPageService();
        }
    }

    public interface ILoginPageService : IDisposable
    {
        Action OnVerifyResponse { get; set; }
        void Authenticate(string uid, string password);
        AuthStatus AuthStatus { get; }
        UserModel FoundUser { get; }
    }

    public class LoginPageService : ILoginPageService
    {
        private Action _onVerify = null!;
        private AuthStatus _authStatus = AuthStatus.Unfinished;
        private UserModel _user = null!;
        public Action OnVerifyResponse { get => _onVerify; set => _onVerify = value; }

        public AuthStatus AuthStatus => _authStatus;

        public UserModel FoundUser => _user;

        public void Authenticate(string uid, string password)
        {
            var repo = RepositoryFactory.Create();
            try
            {
                //MessageBox.Show("This gets called");
                if (String.IsNullOrEmpty(uid) || String.IsNullOrEmpty(password)){
                    _authStatus = AuthStatus.Empty;
                    _onVerify?.Invoke();
                    //MessageBox.Show("Fields are empty");
                    return;
                }
                var user = repo.Users.GetById(uid);
                if (user == null)
                {
                    _authStatus = AuthStatus.NotFound;
                }
                else if (user.UserPassword != password)
                {
                    _authStatus = AuthStatus.Error;
                } else if (user.UserPassword == password)
                {
                    _user = user;
                    _authStatus = AuthStatus.Success;
                }
                //MessageBox.Show($"{all.Count()}");
            } 
            finally
            {
                repo.Dispose();
            }
            //_authStatus = AuthStatus.Success;
            _onVerify?.Invoke();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

    public enum AuthStatus
    {
        Success, Error, NotFound, Empty, Unfinished
    }
}
