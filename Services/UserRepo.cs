using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Models;

namespace Finals.Services
{
    public static class UserRepo
    {
        public static void CreateUser(UserModel userModel)
        {
            var repo = RepositoryFactory.Create();
            try
            {
                userModel.Creator = null!; //null cuz entity starts tripping if it isn't
                var set = new HashSet<string>( repo.Users.GetAll().Select(u => u.UserID) );
                var idGen = (UserModel userModel, HashSet<string> idSet) =>
                {
                    string newId;
                    do
                    {
                        newId = DateTime.Now.Year.ToString() + "_" + Guid.NewGuid().ToString().Substring(0, 5);
                    } while (idSet.Contains(newId));
                    return newId;
                };
                userModel.UserID = idGen(userModel, set);

                if (!ValidateModel(userModel))
                {
                    throw new ArgumentException("Invalid user model. Please ensure all required fields are filled out correctly.");
                }
                repo.Users.Add(userModel);
                repo.SaveChanges();
                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions such as duplicate user ID or other database errors
                MessageBox.Show($"Error creating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { repo.Dispose(); }
        }
        public static ICollection<UserModel> GetAllUsers()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                return repo.Users.GetAll().ToList();
            }
            catch (Exception ex)
            {
                // Handle exceptions such as database connection issues
                MessageBox.Show($"Error retrieving users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<UserModel>();
            }
            finally { repo.Dispose(); }
        }

        private static bool ValidateModel(UserModel userModel)
        {
            return !String.IsNullOrWhiteSpace(userModel.UserID) ||
                   !String.IsNullOrWhiteSpace(userModel.UserName) ||
                   !String.IsNullOrWhiteSpace(userModel.UserEmail) ||
                   !String.IsNullOrWhiteSpace(userModel.UserPassword) ||
                   userModel.DateCreated != DateTime.MinValue;
        }
    }
}
