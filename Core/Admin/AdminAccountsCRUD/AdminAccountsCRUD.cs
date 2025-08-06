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
using Finals.Services;

namespace Finals.Core.Admin.AdminAccountsCRUD
{
    public partial class AdminAccountsCRUD : UserControl, IAdminAccountsCRUD
    {
        private string _userId = null!;
        private ICollection<UserModel> _users = new List<UserModel>();
        public AdminAccountsCRUD(string userId)
        {
            InitializeComponent();
            _userId = userId;
            var presenter = new AdminAccountCRUDPresenter(this);
        }

        public string UserId { get => _userId; }
        public ICollection<UserModel> Users 
        {
            get => _users;
            set 
            {
                _users = value;
                UpdateDGV();
            }
        }

        public event EventHandler CreateAccountClicked
        {
            add => _createAccButton.Click += value;
            remove => _createAccButton.Click -= value;
        }

        private void UpdateDGV()
        {
            _dgv.Rows.Clear();
            foreach (var user in Users)
            {
                _dgv.Rows.Add(
                    user.UserName,
                    user.UserID,
                    user.UserRole.ToString(),
                    (user.DateCreated != default(DateTime)) ? user.DateCreated.ToString() : "Unknown",
                    user.CreatorId ?? "Unknown",
                    "See Details"
                );
            }
        }
    }

    public interface IAdminAccountsCRUD
    {
        event EventHandler CreateAccountClicked;
        string UserId { get; }
        ICollection<UserModel> Users { get; set; }
    }

    public class AdminAccountCRUDPresenter
    {
        private readonly IAdminAccountsCRUD _view;
        public AdminAccountCRUDPresenter(IAdminAccountsCRUD view)
        {
            _view = view;
            WireEvents();
        }

        private void WireEvents()
        {
            _view.CreateAccountClicked += (_, _) => CreateAccount();
            _view.Users = UserRepo.GetAllUsers(); 
        }

        private void CreateAccount()
        {
            using (var dialog = new UserCRUDDialog())
            {
                dialog.Text = "Create New Account";
                dialog.StartPosition = FormStartPosition.CenterScreen;
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var value = dialog.Value;
                    value.DateCreated = DateTime.Now;
                    value.CreatorId = _view.UserId;

                    UserRepo.CreateUser(value);
                    _view.Users = UserRepo.GetAllUsers();
                }
            }
        }
    }
}
