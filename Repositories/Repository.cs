using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Finals.Data;
using Finals.Models;
using Finals.Services.SY_Services;

namespace Finals.Repositories
{
    
    public class Repository : IRepository
    {
        private readonly AppDbContext _dbContext;
        private IUserModelRepository _users = null!;
        private ITeacherRepository _teachers = null!;
        private ISchoolYearModelRepository _schools = null!;
        private IProgramRepository _programs = null!;
        private IProgramEditsRepository _programEdits = null!;
        private IClassSectionTransitionRepository _classSectionTransitions = null!;
        private IClassSectionEditRepository _classSectionEdits = null!;
        private IClassSectionRepository _classSections = null!;
        private IClassBatchRepository _classBatches = null!;
        private IClassEntryRepository _classEntries = null!;
        private ICourseTemplateRepository _courseTemplates = null!;
        private IGradesClassificationRepository _gradesClassifications = null!;
        private IGradesTreeRepository _gradesTrees = null!;
        private ICourseRepository _courses = null!;
        private IAssignedCoursesRepository _assignedCourses = null!;
        private ISemesterRepository _semesters = null!;
        private BaseRepository<SYTemplate> _syTemplates = null!;    

        IUserModelRepository IRepository.Users => _users;
        ISchoolYearModelRepository IRepository.SchoolYears => _schools;

        IProgramRepository IRepository.Programs => _programs;

        IProgramEditsRepository IRepository.ProgramEdits => _programEdits;

        IClassSectionEditRepository IRepository.ClassSectionEdits => _classSectionEdits;

        IClassSectionRepository IRepository.ClassSections => _classSections;

        IClassSectionTransitionRepository IRepository.ClassSectionTransitions => _classSectionTransitions;

        IClassBatchRepository IRepository.ClassBatches => _classBatches;

        IClassEntryRepository IRepository.ClassEntries => _classEntries;

        ICourseTemplateRepository IRepository.CourseTemplates => _courseTemplates;

        IGradesClassificationRepository IRepository.GradesClassifications => _gradesClassifications;

        IGradesTreeRepository IRepository.GradesTrees => _gradesTrees;

        ICourseRepository IRepository.Courses => _courses;

        IAssignedCoursesRepository IRepository.AssignedCourses => _assignedCourses;

        ITeacherRepository IRepository.Teacher => _teachers;


        ISemesterRepository IRepository.Semesters => _semesters;

        BaseRepository<SYTemplate> IRepository.SYTemplates => _syTemplates;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _users = new UserModelRepository(_dbContext);
            _teachers = new TeacherRepository(_dbContext);
            _schools = new SchoolYearRepository(_dbContext);
            _programs = new ProgramRepository(_dbContext);
            _programEdits = new ProgramEditsRepository(_dbContext);
            _classSectionEdits = new ClassSectionEditLogRepository(_dbContext);
            _classSectionTransitions = new ClassSectionTransitionRepository(_dbContext);
            _classSections = new ClassSectionRepository(_dbContext);
            _classBatches = new ClassBatchRepository(_dbContext);
            _classEntries = new ClassEntryRepository(_dbContext);
            _courseTemplates = new CourseTemplateRepository(_dbContext);
            _gradesClassifications = new GradeClassificationRepository(_dbContext);
            _gradesTrees = new GradesTreeRepository(_dbContext);
            _courses = new CourseRepository(_dbContext);
            _assignedCourses = new AssignedCoursesRepository(_dbContext);
            _semesters = new SemesterRepository(_dbContext);
            _syTemplates = new BaseRepository<SYTemplate>(_dbContext);
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
