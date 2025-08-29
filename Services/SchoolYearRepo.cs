using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Models;
using Finals.Repositories.Interfaces;

namespace Finals.Services
{
    public static class SchoolYearRepo
    {
        public static ICollection<SchoolYearModel> GetAll()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                return repo.SchoolYears.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving school years", ex);
            }
            finally
            {
                repo.Dispose();
            }
        }

        public static SchoolYearModel CreateNewSchoolYear(bool concludeCurrentSchoolYear = false)
        {
            if (concludeCurrentSchoolYear)
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
            Func<string, TermModel> semester_template = (string name) =>
            {
                return new TermModel()
                {
                    TermId = Guid.NewGuid().ToString().Substring(0, 10),
                    TermName = name,
                    DateStart = DateTime.MinValue,
                    DateEnd = DateTime.MinValue,
                    DateCreated = DateTime.Now,
                    SchoolYearId = newSy.SchoolYearId,
                    Status = TermStatus.Preparatory,
                    IsActive = false
                };
            };
            var fSemester = semester_template("First Semester");
            var sSemester = semester_template("Second Semester");
            var summerSemester = semester_template("Summer");
            sSemester.ExtraTerms = new List<TermModel>() { summerSemester };
            newSy.Terms = new List<TermModel> { fSemester, sSemester };
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

        private static Status GenerateSchoolYearID(SchoolYearModel model)
        {
            var repo = RepositoryFactory.Create();
            try
            {
                string startYear = (DateTime.Now.Year % 100).ToString("D2");
                string endYear = ((DateTime.Now.Year + 1) % 100).ToString("D2");
                string yearCode = $"{startYear}{endYear}";
                string pattern = $@"^SY{startYear + endYear}(\.\d+)?$";
                Regex regex = new Regex(pattern);

                var schoolYears = repo.SchoolYears.GetAll();

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
            finally { repo.Dispose(); }
        }

        public static void ConcludeCurrentSchoolYear()
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while concluding the current school year: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }
        }

        public static void AddSemesterToSchoolYear(string sy_id, TermModel model)
        {
            IRepository repo = RepositoryFactory.Create();
            try
            {
                if (sy_id == null)
                {
                    MessageBox.Show("School Year ID cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (model == null)
                {
                    MessageBox.Show("Semester model cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var schoolYear = repo.SchoolYears.GetById(sy_id);
                    if (schoolYear == null)
                    {
                        MessageBox.Show("School Year not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    model.SchoolYearId = schoolYear.SchoolYearId;
                    if(String.IsNullOrWhiteSpace(model.TermId))
                    {
                        model.TermId = Guid.NewGuid().ToString().Substring(0, 10);
                    }

                    repo.Semesters.Add(model);
                    repo.SaveChanges();
                    MessageBox.Show("School year updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the school year: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }
        }

        public static SchoolYearModel? GetCurrentSchoolYear()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                var sy = repo.SchoolYears.GetCurrentSchoolYear();
                //if (sy != null) MessageBox.Show(sy.SchoolYearId);
                return sy;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the current school year: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                repo.Dispose();
            }
        }

        public static SchoolYearModel? GetPreviousSchoolYear()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                var sy = repo.SchoolYears.GetPreviousSchoolYear();
                return sy;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the previous school year: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                repo.Dispose();
            }
        }

        public static SchoolYearModel? GetUpcomingSchoolYear()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                var sy = repo.SchoolYears.GetUpcomingSchoolYear();
                return sy;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the upcoming school year: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                repo.Dispose();
            }
        }
    }
}
