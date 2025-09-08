using Finals.Data.Configuration;
using Finals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Configuration;
using Finals.Data.Configuration;
using Finals.Models;
using Finals.Services.SY_Services;

namespace Finals.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TestModelConfiguration());
            modelBuilder.ApplyConfiguration(new UserModelConfiguration());
            modelBuilder.ApplyConfiguration(new AdminModelConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherModelConfiguration());
            modelBuilder.ApplyConfiguration(new StudentModelConfiguration());
            
            modelBuilder.ApplyConfiguration(new TermModelConfiguration());
            modelBuilder.ApplyConfiguration(new ProgramModelConfiguration());
            modelBuilder.ApplyConfiguration(new ProgramModel_EditConfiguration());

            modelBuilder.ApplyConfiguration(new ClassBatchModelConfiguration());
            modelBuilder.ApplyConfiguration(new ClassEntryModelConfiguration());
            modelBuilder.ApplyConfiguration(new CourseTemplateModelConfiguration());
            modelBuilder.ApplyConfiguration(new CourseTemplateItemModelConfiguration());
            modelBuilder.ApplyConfiguration(new CourseModel_AssignedConfiguration());
            modelBuilder.ApplyConfiguration(new CourseModelConfiguration());
            modelBuilder.ApplyConfiguration(new GradesClassificationConfiguration());
            modelBuilder.ApplyConfiguration(new GradesTreeConfiguration());
            modelBuilder.ApplyConfiguration(new VenueModelConfiguration());

            // SY
            modelBuilder.ApplyConfiguration(new SchoolYearModelConfiguration());
            modelBuilder.ApplyConfiguration(new SchoolYearRegistrationConfiguration());
            modelBuilder.ApplyConfiguration(new SYTemplateConfiguration());

            // Class Section
            modelBuilder.ApplyConfiguration(new ClassSectionTermDataConfiguration());
            modelBuilder.ApplyConfiguration(new ClassSectionConfiguration());
            modelBuilder.ApplyConfiguration(new ClassSectionTransitionModelConfiguration());
            modelBuilder.ApplyConfiguration(new ClassSectionEditConfiguration());

            // Courses
            modelBuilder.ApplyConfiguration(new AssignedCourseRegistrationModelConfiguration());
            modelBuilder.ApplyConfiguration(new AssignedCourseGradeConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Y2S1_INC_Compliance_proj.Properties.Settings.DefaultConnection"].ConnectionString;
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36)));
        }
        // School Cycle
        public DbSet<SchoolYearModel> SchoolYearModels { get; set; } = null!;
        public DbSet<SchoolYearRegistration> SchoolYearRegistrations { get; set; } = null!;
        public DbSet<SYTemplate> SYTemplates { get; set; } = null!;

        public DbSet<TermModel> Semesters { get; set; } = null!;

        //Class Sections
        public DbSet<ClassSectionTermDataModel> ClassSectionTermDatas { get; set; } = null!;
        public DbSet<ClassSectionModel> ClassSections { get; set; } = null!;
        public DbSet<ClassBatchModel> ClassBatches { get; set; } = null!;
        public DbSet<ClassSectionTransitionModel> ClassSectionsTransition { get; set; } = null!;
        public DbSet<ClassSectionEditLog> ClassSectionsEdits { get; set; } = null!;
        public DbSet<ClassEntryModel> ClassEntries { get; set; } = null!;

        // Courses
        public DbSet<AssignedCourseRegistration> AssignedCourseRegistrations { get; set; } = null!;

        public DbSet<TestModel> TestModels { get; set; } = null!;
        public DbSet<UserModel> UserModels { get; set; } = null!;
        public DbSet<AdminModel> AdminModels { get; set; } = null!;
        public DbSet<TeacherModel> TeacherModels { get; set; } = null!;
        public DbSet<StudentModel> StudentModels { get; set; } = null!;
        
        

        public DbSet<ProgramModel> Program { get; set; } = null!;
        public DbSet<ProgramModel_Edits> ProgramEdits { get; set; } = null!;

        
        public DbSet<CourseModel> Courses { get; set; } = null!;
        public DbSet<CourseTemplateModel> CourseTemplates { get; set; } = null!;
        public DbSet<CourseTemplateItem> CourseTemplatesItems { get; set; } = null!;
        public DbSet<CourseModel_Assigned> AssignedCourses { get; set; } = null!;
        public DbSet<GradesTreeModel> GradesTreeConfigurations { get; set; } = null!;
        public DbSet<GradesClassification> GradesClassifications { get; set; } = null!;

        public DbSet<VenueModel> Venues { get; set; } = null!;
    }
}
