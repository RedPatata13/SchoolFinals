using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.Core.Student.StudentAccount
{
    public partial class UserInfoRow : UserControl, IUserInfoRow
    {
        private bool _isEditing = false;
        private Action _editSet = null!;
        private Action _onSave = null!;
        private Action _onEdit = null!;
        private Action _onCancel = null!;
        private Task<Status> _preSave = null!;
        public UserInfoRow()
        {
            InitializeComponent();
            var presenter = new UserInfoRowPresenter(this);
        }

        public string Value { get => ValueField.Text; set => ValueField.Text = value; }
        public string EditValue { get => EditValueTextBox.Text; set => EditValueTextBox.Text = value; }
        public bool IsEditing { get => _isEditing; set { _isEditing = value; _editSet?.Invoke(); }  }

        public Action EditingChanged { get => _editSet; set => _editSet = value; }
        public Action OnSave { get => _onSave; set => _onSave = value; }
        public Action OnCancel { get => _onCancel; set => _onCancel = value; }
        public Action OnEdit { get => _onEdit; set => _onEdit = value; }
        public Task<Status> PreSave { get => _preSave; set => _preSave = value; }

        public void OnEditing()
        {
            ValueField.Visible = false;
            EditValueTextBox.Visible = true;

            EditOrSaveButton.Text = "Save";
            CancelButton.Visible = true;
        }

        public void OnViewing()
        {
            ValueField.Visible = true;
            EditValueTextBox.Visible = false;

            EditOrSaveButton.Text = "Edit";
            CancelButton.Visible = false;
        }
    }

    public interface IUserInfoRow
    {
        string Name { get; set; }
        string Value { get; set; }
        string EditValue { get; set; }

        bool IsEditing { get; }

        void OnEditing();
        void OnViewing();

        Action EditingChanged { get; set; }
        Action OnSave { get; set; }
        Action OnCancel { get; set; }
        Action OnEdit { get; set; }
        Task<Status> PreSave { get; set; }
    }
    public class UserInfoRowPresenter
    {
        private readonly IUserInfoRow _view;
        public UserInfoRowPresenter(IUserInfoRow view)
        {
            _view = view;
        }

        private void WireEvents()
        {

        }

        private async Task OnSaveAsync()
        {
            if (_view.PreSave == null)
            {
                // continue
            }
            else
            {
                var result = await _view.PreSave;
                if (result == Status.Error)
                {
                    throw new Exception("Failed pre-save.");
                }
            }

            _view.Value = _view.EditValue;
            _view.EditValue = string.Empty;
        }

    }
}
