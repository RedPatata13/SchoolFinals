using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Services.Contracts
{
    public interface IProgramManagementService : IDisposable
    {
        int SectionsCreatedCount { get; }
        int SectionsUpdatedCount { get; }
        List<ClassSectionModel> SectionsCreated { get; set; }
        List<ClassSectionModel> SectionsUpdated { get; set; }
        void CreateNewProgram(string programName, string description, string creatorId, bool isOpen = true);
        void UpdateProgram(string programId, string programName, string description, string lastEditorId, bool isOpen = true);
        void AddSectionToProgram(string programId, string userId, params ClassSectionModel[] sectionIds);

        //string GenerateIDForClassSection(string programId, int yearLevel);
    }
}
