using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Services.SY_Creation_Pipe
{
    public interface IProgramTermDataGenerator
    {
        void GenerateProgramTermData(string programId, string schoolYearId);
    }
}
