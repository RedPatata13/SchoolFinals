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

namespace Finals.Forms.UserControls
{
    public partial class ClassTransitionUC : UserControl, IClassTransitionUserControl
    {
        private ClassSectionTransitionModel _model = null!;
        private double _value = 0.0;
        private UserControlState _state = UserControlState.Viewing;
        public ClassSectionTransitionModel Model 
        {
            get => _model;
            set
            {
                _model = value;
                Value = _model.TransitionPercentage;
                ClassName = _model.ToSection?.SectionName ?? "Placeholder";
            }
        }

        public UserControlState State
        {
            get => _state;
            set
            {
                _state = value;
                if (value == UserControlState.Viewing)
                {
                    StateIsViewing();
                }
                else if (value == UserControlState.Editing)
                {
                    StateIsEditing();
                }
            }
        }

        public double Value 
        {
            get => _value;
            set
            {
                _value = value;
                textBox2.Text = value.ToString("0.00");
            }
        }

        public string ClassName 
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public ClassTransitionUC()
        {
            InitializeComponent();
            Value = 0.0;
        }
        
        private void StateIsViewing()
        {
            // Logic for viewing state
        }

        private void StateIsEditing()
        {
            // Logic for editing state
        }
    }

    public interface IClassTransitionUserControl
    {
        ClassSectionTransitionModel Model { get; set; }
        UserControlState State { get; set; }
        double Value { get; set; }
        string ClassName { get; set; }
    }
    
    public enum UserControlState
    {
        Viewing, Editing
    }
}
