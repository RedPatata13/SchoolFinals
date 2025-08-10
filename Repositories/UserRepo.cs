using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Models;

namespace Finals.Repositories
{
    public static class UserRepo
    {
        public static ICollection<TeacherModel> GetTeachers()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                return repo.Teacher.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving teachers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<TeacherModel>();
            }
            finally { repo.Dispose(); }    
        }
    }
}
