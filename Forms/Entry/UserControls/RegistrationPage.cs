using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Finals.Forms.Entry.UserControls
{
    public partial class RegistrationPage : UserControl, IRegistratonPage
    {
        private Action _backClick = null!;
        public RegistrationPage()
        {
            InitializeComponent();
            var presenter = new RegistrationPagePresenter(this);
        }

        public Action BackClick { get => _backClick; set => _backClick = value; }
        Panel IRegistratonPage.MainContentArea { get => MainContentArea; }

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
    }

    public interface IRegistratonPage
    {
        Action BackClick { get; set; }
        event EventHandler OnBackClick;
        Panel MainContentArea { get; }
    }

    public class RegistrationPagePresenter
    {
        private readonly IRegistratonPage _view;
        private Stack<UserControl> _stack = new();
        public RegistrationPagePresenter(IRegistratonPage view)
        {
            _view = view;
            _view.OnBackClick += (_, _) => _view.BackClick?.Invoke();


            var home = new RegistrationPage_Greeting();

            _stack.Push(home);
            _view.MainContentArea.Controls.Add(home);


            home.Location = new Point(0, 0);
            SetWizard(home);
        }

        private void SetWizard(IRegistrationPage_Greeting root)
        {
            root.Next = () =>
            {
                _view.MainContentArea.SuspendLayout();
                _view.MainContentArea.Controls.Clear();
                //_view.MainContentArea.AutoScroll = false;
                IRegistrationPage_ProgramDescription next = new RegistrationPage_ProgramDescription();
                if (next is RegistrationPage_ProgramDescription rpg)
                {
                    _stack.Push(rpg);
                    _view.MainContentArea.Controls.Add(rpg);
                    next.OnNext = RegistrationPage_UserInfo_UC_Action;
                    next.OnBack = SwapToPrev;
                    _view.MainContentArea.AutoScrollPosition = new Point(0, 0);
                    rpg.Location = new Point(0, 0);

                } else
                {
                    throw new Exception("rpg is of wrong type");
                }
                _view.MainContentArea.ResumeLayout();
            };
        }

        private void RegistrationPage_UserInfo_UC_Action()
        {
            _view.MainContentArea.SuspendLayout();
            _view.MainContentArea.Controls.Clear();
            //_view.MainContentArea.AutoScroll = true;
            //IRegistrationPage_ProgramDescription next = new RegistrationPage_ProgramDescription();
            IRegistrationPage_UserInfo n = new RegistrationPage_UserInfo();

            if (n is RegistrationPage_UserInfo rpc)
            {
                _stack.Push(rpc);
                _view.MainContentArea.Controls.Add(rpc);
                n.OnNext = RegistrationPage_Completion_Action;
                n.OnBack = SwapToPrev;
                _view.MainContentArea.AutoScrollPosition = new Point(0, 0);
                rpc.Location = new Point(0, 0);
            }
            else
            {
                throw new Exception("rpg is of wrong type");

            }

            _view.MainContentArea.ResumeLayout();
        }

        private void RegistrationPage_Completion_Action()
        {
            _view.MainContentArea.SuspendLayout();
            _view.MainContentArea.Controls.Clear();
            //_view.MainContentArea.AutoScroll = false;
            IRegistrationPage_Completion n = new RegistrationPage_Completion();

            if (n is RegistrationPage_Completion rpc)
            {
                _stack.Push(rpc);
                _view.MainContentArea.Controls.Add(rpc);

                n.Back = SwapToPrev;

                //next.OnNext = RegistrationPage_UserInfo_UC_Action;
                _view.MainContentArea.AutoScrollPosition = new Point(0, 0);
                rpc.Location = new Point(0, 0);
            }
            else
            {
                throw new Exception("rpg is of wrong type");

            }

            _view.MainContentArea.ResumeLayout();
        }

        private void SwapToPrev()
        {
            if (_stack.Count > 1)
            {
                _view.MainContentArea.SuspendLayout();
                _view.MainContentArea.Controls.Clear();

                // Step 1: Pop current (discard it)
                _stack.Pop();

                // Step 2: Peek previous (don't pop it)
                var previousPage = _stack.Peek();

                // Step 3: Show it
                _view.MainContentArea.Controls.Add(previousPage);
                _view.MainContentArea.AutoScrollPosition = new Point(0, 0);
                previousPage.Location = new Point(0, 0);
                _view.MainContentArea.ResumeLayout();
            }
            else
            {
                MessageBox.Show("UC Stack only has the initial page.");
            }
        }

    }
}

