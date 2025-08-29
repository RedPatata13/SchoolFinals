using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Models;

namespace Finals.Services
{
    public static class ProgramRepo
    {
        public static ICollection<ProgramModel> GetAll()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                return repo.Programs.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error has occured while attempting to retrieve all programs. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { repo.Dispose(); }

            return new List<ProgramModel>();
        }
    }
}
