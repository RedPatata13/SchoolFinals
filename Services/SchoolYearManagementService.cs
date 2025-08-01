using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Repositories.Interfaces;
using Finals.Services.Contracts;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Services
{
    public class SchoolYearManagementService : ISchoolYearManagementService
    {
        public void ConcludeCurrentSchoolYear()
        {
            IRepository repo = RepositoryFactory.Create();
            try
            {
                var currSy = repo.SchoolYears.GetCurrentSchoolYear();
                currSy.IsCurrent = false;
                currSy.Status = SchoolYearStatus.Locked;

                repo.SchoolYears.Update(currSy);
                repo.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred while concluding the current school year: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }
        }

        public SchoolYearModel CreateNewSchoolYear(bool concludeCurrentSchoolYear = false)
        {
            if(concludeCurrentSchoolYear)
            {
                ConcludeCurrentSchoolYear();   
            }

            var newSy = new SchoolYearModel()
            {
                // temporarily empty    
            };

            var result = GenerateSchoolYearID(newSy);

            if (result != Status.Ok)
            {
                throw new InvalidOperationException("Failed to generate a valid School Year ID and Name.");
            }

            newSy.IsCurrent = true;
            newSy.Status = SchoolYearStatus.Draft;
            newSy.IsRegistrationOpen = false;

            var repo = RepositoryFactory.Create();
            try
            {
                repo.SchoolYears.Add(newSy);
                repo.SaveChanges();
                return newSy;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating a new school year: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }

            throw new NotImplementedException("An operation that should not be reached has occured");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Status GenerateSchoolYearID(SchoolYearModel model)
        {
            try
            {
                string startYear = (DateTime.Now.Year % 100).ToString("D2");
                string endYear = ((DateTime.Now.Year + 1) % 100).ToString("D2");
                string yearCode = $"{startYear}{endYear}";
                string pattern = $@"^SY{startYear + endYear}(\.\d+)?$";
                Regex regex = new Regex(pattern);

                var schoolYears = RepositoryFactory.Create().SchoolYears.GetAll();

                int matchCount = schoolYears.Count(sy => regex.IsMatch(sy.SchoolYearId));

                model.SchoolYearId = matchCount == 0 ? $"SY{yearCode}" : $"SY{yearCode}.{matchCount}";
                model.Name = matchCount == 0 ? $"School Year {yearCode}" : $"School Year {yearCode}.{matchCount}";

                return Status.Ok;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while generating the School Year ID: " + ex.Message);
                return Status.Error;
            }
        }
    }
}
