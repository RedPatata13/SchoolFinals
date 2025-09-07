using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Services.Contracts
{
    public interface ITermRepo
    {
        TermModel? GetCurrentTerm();
    }
}
