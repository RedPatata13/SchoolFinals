using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Y2S1_INC_Compliance_proj.Data;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Repositories
{
    
    public class Repository : IRepository
    {
        private readonly AppDbContext _dbContext;
        private IUserModelRepository _users = null!;
        private ISchoolYearModelRepository _schools = null!;
        private IProgramRepository _programs = null!;
        private IProgramEditsRepository _programEdits = null!;
        private IClassSectionTransitionRepository _classSectionTransitions = null!;
        private IClassSectionEditRepository _classSectionEdits = null!;
        private IClassSectionRepository _classSections = null!;
        private IClassBatchRepository _classBatches = null!;
        private IClassEntryRepository _classEntries = null!;
        IUserModelRepository IRepository.Users => _users;
        ISchoolYearModelRepository IRepository.SchoolYears => _schools;

        IProgramRepository IRepository.Programs => _programs;

        IProgramEditsRepository IRepository.ProgramEdits => _programEdits;

        IClassSectionEditRepository IRepository.ClassSectionEdits => _classSectionEdits;

        IClassSectionRepository IRepository.ClassSections => _classSections;

        IClassSectionTransitionRepository IRepository.ClassSectionTransitions => _classSectionTransitions;

        IClassBatchRepository IRepository.ClassBatches => _classBatches;

        IClassEntryRepository IRepository.ClassEntries => _classEntries;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _users = new UserModelRepository(_dbContext);
            _schools = new SchoolYearRepository(_dbContext);
            _programs = new ProgramRepository(_dbContext);
            _programEdits = new ProgramEditsRepository(_dbContext);
            _classSectionEdits = new ClassSectionEditLogRepository(_dbContext);
            _classSectionTransitions = new ClassSectionTransitionRepository(_dbContext);
            _classSections = new ClassSectionRepository(_dbContext);
            _classBatches = new ClassBatchRepository(_dbContext);
            _classEntries = new ClassEntryRepository(_dbContext);
        }

        void IDisposable.Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        void IRepository.SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
