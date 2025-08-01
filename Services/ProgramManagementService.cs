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
    public class ProgramManagementService : IProgramManagementService
    {
        private List<ClassSectionModel> _sectionsCreated = new List<ClassSectionModel>();
        private List<ClassSectionModel> _sectionsUpdated = new List<ClassSectionModel>();
        private List<ClassSectionModel> _sectionsCRUDError = new List<ClassSectionModel>();
        private Dictionary<string, List<string>> _sectionsErrorCauses = new();

        public List<ClassSectionModel> SectionsUpdated
        {
            get => _sectionsUpdated;
            set => _sectionsUpdated = value ?? throw new ArgumentNullException(nameof(value), "SectionsUpdated cannot be null.");
        }

        public List<ClassSectionModel> SectionsCreated
        {
            get => _sectionsCreated;
            set => _sectionsCreated = value ?? throw new ArgumentNullException(nameof(value), "SectionsCreated cannot be null.");
        }

        public int SectionsCreatedCount
        {
            get => _sectionsCreated.Count;
            set => throw new NotSupportedException("SectionsCreatedCount is read-only.");
        }

        public int SectionsUpdatedCount
        {
            get => _sectionsUpdated.Count;
            set => throw new NotSupportedException("SectionsUpdatedCount is read-only.");
        }
        public void AddSectionToProgram(string programId, string userId, params ClassSectionModel[] sectionIds)
        {
            var repo = RepositoryFactory.Create();
            try
            {
                var program = repo.Programs.GetById(programId);
                var classSections = repo.ClassSections.GetAll();
                if (program == null)
                {
                    throw new ArgumentException($"Program with ID {programId} does not exist.");
                }
                var ids = new HashSet<string>( classSections.Select(p => p.SectionID) );

                foreach (var section in sectionIds)
                {
                    if (section == null) throw new ArgumentNullException(nameof(section), "Section cannot be null.");
                    if (String.IsNullOrWhiteSpace(section.SectionID))
                    {
                        throw new ArgumentException("Section ID cannot be null or empty.", nameof(section));
                    }
                    // update section's ProgramId to the current program
                    if (ids.Contains(section.SectionID))
                    {
                        var s = repo.ClassSections.GetById(section.SectionID);
                        s.ProgramId = programId;

                        var editLog = CreateClassSectionEditLog //log the edit
                        (
                            $"Section {s.SectionName} has been added to program {program.ProgramName}.",
                            userId,
                            s.SectionID,
                            ClassSectionEditType.SectionProgramChange
                        );

                        repo.ClassSections.Update(s);
                        repo.ClassSectionEdits.Add(editLog);
                    } 
                    else //create section if it doesn't exist yet, has a try catch due to possibility of invalid values
                    {
                        try
                        {
                            repo.ClassSections.Add(section);

                            var editLog = CreateClassSectionEditLog //log the creation
                            (
                                $"Section {section.SectionName} has been created and added to program {program.ProgramName}.",
                                userId,
                                section.SectionID,
                                ClassSectionEditType.SectionCreated
                            );

                            repo.ClassSectionEdits.Add(editLog);
                        } 
                        catch (Exception ex) //catch any errors during section creation
                        {
                            if (!_sectionsCRUDError.Contains(section)) _sectionsCRUDError.Add(section);
                            if (!_sectionsErrorCauses.ContainsKey(section.SectionID))
                            {
                      
                                _sectionsErrorCauses[section.SectionID] = new List<string>();
                            }

                            _sectionsErrorCauses[section.SectionID].Add(ex.Message);
                        }
                    }
                }

                repo.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding sections to the program: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }
        }

        public void CreateNewProgram(string programName, string description, string creatorId, bool isOpen = true)
        {
            throw new NotImplementedException();
        }

        public void UpdateProgram(string programId, string programName, string description, string lastEditorId, bool isOpen = true)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        private ClassSectionEditLog CreateClassSectionEditLog(string msg, string userId, string sectionId, ClassSectionEditType editType)
        {
            return new ClassSectionEditLog
            {
                LogId = Guid.NewGuid().ToString().Substring(0, 10),
                EditDescription = msg,
                EditedByUserId = userId,
                EditDateTime = DateTime.Now,
                EditType = editType,
                SectionId = sectionId,
            };
        }
    }
}
