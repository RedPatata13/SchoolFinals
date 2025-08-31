using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Finals.Models;
using Finals.Repositories.Interfaces;
using Finals.Services.SY_Services.Contracts;

namespace Finals.Services.SY_Services
{
    public class SchoolYearCreator : ISchoolYearCreator
    {
        private readonly ITermGenerator _termGenerator;
        private readonly IClassSectionTermDataGenerator _programTermDataGenerator;
        private readonly Func<IRepository> _repositoryFactory;
        private readonly string _userId;
        public SchoolYearCreator(
            ITermGenerator termGenerator,
            IClassSectionTermDataGenerator programTermDataGenerator,
            Func<IRepository> repositoryFactory,
            string userId)
        {
            if (termGenerator == null) throw new ArgumentNullException(nameof(termGenerator));
            if (programTermDataGenerator == null) throw new ArgumentNullException(nameof(programTermDataGenerator));
            if (repositoryFactory == null) throw new ArgumentNullException(nameof(repositoryFactory));
            if (String.IsNullOrWhiteSpace(userId)) throw new ArgumentNullException(nameof(userId));

            _termGenerator = termGenerator;
            _programTermDataGenerator = programTermDataGenerator;
            _repositoryFactory = repositoryFactory;
            _userId = userId;
        }
        public SchoolYearModel CreateSchoolYear(SYTemplate template, bool concludeCurrentSchoolYear = false)
        {
            if (template == null) throw new ArgumentNullException(nameof(template));
            var sy = new SchoolYearModel();
            GenerateSchoolYearIdentity(sy);
            GenerateTerms(sy, template);
            GenerateProgramTermData(sy);
            if (concludeCurrentSchoolYear)
            {
                ConcludeCurrentSchoolYear();
                SetSchoolYearAsActive(sy);
            }

            return sy;
        }

        private void GenerateSchoolYearIdentity(SchoolYearModel model)
        {
            using var repo = _repositoryFactory()
                ?? throw new InvalidOperationException("Repository factory returned null.");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while generating the School Year ID and Name: " + ex.Message);
            }
            finally { repo.Dispose(); }
        }

        private void GenerateTerms(SchoolYearModel sy, SYTemplate template)
        {
            var terms = _termGenerator.GenerateTerms(sy.SchoolYearId, template.TermNames.ToArray());
            var termMap = terms.ToDictionary(t => t.TermName, t => t);
            foreach (var kv in template.ExtraTerms)
            {
                TermModel term = null!;
                if(!termMap.TryGetValue(kv.Key, out term!)) throw new InvalidOperationException($"Term '{kv.Key}' not found in generated terms.");
                var extraTermNames = kv.Value.Split(',').ToArray();

                _termGenerator.AddExtraTermsToStandardTerm(term, extraTermNames);
            }
            sy.Terms = terms.ToList();
        }

        private void GenerateProgramTermData(SchoolYearModel sy)
        {
            using var repo = _repositoryFactory()
                ?? throw new InvalidOperationException("Program repository factory returned null.");

            try
            {
                var programs = repo.Programs.GetAll().ToList();

                programs.ForEach(program =>
                    (program.ClassSections ?? new List<ClassSectionModel>()).ToList().ForEach(cs =>
                    {
                        cs.TermData ??= new List<ClassSectionTermDataModel>();
                        sy.Terms.ToList().ForEach(term =>
                            cs.TermData.Add(_programTermDataGenerator.GenerateProgramTermData(
                                cs.SectionID, sy.SchoolYearId, term.TermId))
                        );
                    })
                );

                repo.SaveChanges();
                MessageBox.Show("Program term data generated successfully.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating program term data: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }
        }

        private void ConcludeCurrentSchoolYear()
        {
            using var repo = _repositoryFactory()
                ?? throw new InvalidOperationException("Repository factory returned null.");

            try
            {
                var currentSY = repo.SchoolYears.GetCurrentSchoolYear();
                if (currentSY == null) return;
                currentSY.Status = SchoolYearStatus.Locked;
                //currentSY.
                currentSY.IsCurrent = false;
                repo.SchoolYears.Update(currentSY);
                repo.SaveChanges();
                MessageBox.Show("Current school year concluded successfully.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error concluding current school year: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }
        }

        private void SetSchoolYearAsActive(SchoolYearModel sy)
        {
            using var repo = _repositoryFactory()
                ?? throw new InvalidOperationException("Repository factory returned null.");

            try
            {
                sy.Status = SchoolYearStatus.Active;
                sy.IsCurrent = true;
                repo.SchoolYears.Add(sy);
                repo.SaveChanges();
                MessageBox.Show("New school year set as active successfully.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting new school year as active: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }
        }
    }
}
