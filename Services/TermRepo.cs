using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Models;
using Finals.Services.Contracts;

namespace Finals.Services
{
    public class TermRepo : ITermRepo
    {
        public TermModel? GetCurrentTerm()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                return repo.Semesters.GetCurrentTerm();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                repo.Dispose();
            }

            throw new InvalidOperationException("Unreachable code.");
        }
    }
}
