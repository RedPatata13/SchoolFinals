using Finals.Data.Configuration;
using Finals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Configuration;
using Y2S1_INC_Compliance_proj.Data.Configuration;
using Y2S1_INC_Compliance_proj.Models;

namespace Y2S1_INC_Compliance_proj.Data
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
            modelBuilder.ApplyConfiguration(new SchoolYearModelConfiguration());
            modelBuilder.ApplyConfiguration(new SemesterModelConfiguration());
            modelBuilder.ApplyConfiguration(new ProgramModelConfiguration());
            modelBuilder.ApplyConfiguration(new ProgramModel_EditConfiguration());
            modelBuilder.ApplyConfiguration(new ClassSectionConfiguration());
            modelBuilder.ApplyConfiguration(new ClassSectionTransitionModelConfiguration());
            modelBuilder.ApplyConfiguration(new ClassSectionEditConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Y2S1_INC_Compliance_proj.Properties.Settings.DefaultConnection"].ConnectionString;
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36))); // <-- Set this to match your installed MySQL version
        }
        public DbSet<TestModel> TestModels { get; set; } = null!;
        public DbSet<UserModel> UserModels { get; set; } = null!;
        public DbSet<AdminModel> AdminModels { get; set; } = null!;
        public DbSet<TeacherModel> TeacherModels { get; set; } = null!;
        public DbSet<StudentModel> StudentModels { get; set; } = null!;
        public DbSet<SchoolYearModel> SchoolYearModels { get; set;} = null!;
        public DbSet<SemesterModel> Semesters { get; set; } = null!;

        public DbSet<ProgramModel> Program { get; set; } = null!;
        public DbSet<ProgramModel_Edits> ProgramEdits { get; set; } = null!;

        public DbSet<ClassSectionModel> ClassSections { get; set; } = null!;
        public DbSet<ClassSectionTransitionModel> ClassSectionsTransition { get; set; } = null!;
        public DbSet<ClassSectionEditLog> ClassSectionsEdits { get; set; } = null!;

    }
}
