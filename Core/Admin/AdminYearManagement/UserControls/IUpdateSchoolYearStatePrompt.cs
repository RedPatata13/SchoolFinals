using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Core.Admin.AdminYearManagement.UserControls
{
    public interface IUpdateSchoolYearStatePrompt
    {
        Status Status { get; }
        void Confirm();
        void Cancel();
    }
}
