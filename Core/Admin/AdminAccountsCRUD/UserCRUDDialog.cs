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

namespace Finals.Core.Admin.AdminAccountsCRUD
{
    public partial class UserCRUDDialog : Form, IUserCRUDDialog
    {
        public UserCRUDDialog(UserModel model = null!)
        {
            InitializeComponent();
            _model = model ?? new UserModel
            {
                UserID = string.Empty,
                UserName = string.Empty,
                UserEmail = string.Empty,
                UserPassword = string.Empty,
            };
            _userRole.SelectedIndex = 0;
        }

        private UserModel _model = null!;

        public UserModel Value { get => _model; set => _model = value; }

        public string UserID => _model.UserID;

        public string UserName => _model.UserName;

        public string UserEmail => _model.UserEmail;

        public string UserPassword => _model.UserPassword;

        public string UserRole => _model.UserRole.ToString();

        private void ValidateInput()
        {
            if (
                String.IsNullOrWhiteSpace(_userName.Text) ||
                String.IsNullOrWhiteSpace(_userEmail.Text) ||
                String.IsNullOrWhiteSpace(_userPassword.Text) ||
                _userRole.SelectedIndex <= 0
            )
            {
                MainActionButton.Enabled = false;
                MainActionButton.BackColor = SystemColors.Menu;
                MainActionButton.ForeColor = SystemColors.ScrollBar;
            }
            else
            {
                MainActionButton.Enabled = true;
                MainActionButton.BackColor = SystemColors.Highlight;
                MainActionButton.ForeColor = SystemColors.HighlightText;
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            _model.UserName = _userName.Text;
            ValidateInput();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            _model.UserEmail = _userEmail.Text;
            ValidateInput();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            _model.UserPassword = _userPassword.Text;
            ValidateInput();
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_userRole.SelectedIndex > 0)
            {
                _model.UserRole = _userRole.SelectedIndex switch
                {
                    3 => Models.UserRole.Admin,
                    2 => Models.UserRole.Teacher,
                    1 => Models.UserRole.Student,
                    _ => throw new InvalidOperationException("Invalid role") // Default fallback
                };
            }
            ValidateInput();
        }

        private void MainActionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SecondaryActionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }   
    }

    public interface IUserCRUDDialog
    {
        UserModel Value { get; set; }
        string UserID { get; }
        string UserName { get; }
        string UserEmail { get; }
        string UserPassword { get; }
        string UserRole { get; }
    }


}
