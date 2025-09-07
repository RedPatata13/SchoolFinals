using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Models;

namespace Finals.Services
{
    public static class AssignedCourseRepo
    {
        public static void AddAssignedCourse(params CourseModel_Assigned[] assignedCourses)
        {
            if (assignedCourses == null || assignedCourses.Length == 0)
            {
                throw new ArgumentException("At least one assigned course must be provided.");
            }
            var repo = RepositoryFactory.Create();
            try
            {
                foreach (var course in assignedCourses)
                {
                    if (course == null)
                    {
                        throw new ArgumentNullException(nameof(course), "Assigned course cannot be null.");
                    }
                    course.Course = null!;
                    course.AssignedBy = null!;
                    course.Teacher = null!;
                    repo.AssignedCourses.Add(course);

                }
                repo.SaveChanges();
                MessageBox.Show("Assigned courses added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding assigned courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw ex;
            }
            finally
            {
                repo.Dispose();
            }
        }

        public static ICollection<CourseModel_Assigned> GetAllBySection(string sectionId)
        {
            if (string.IsNullOrEmpty(sectionId))
            {
                throw new ArgumentException("Section ID cannot be null or empty.", nameof(sectionId));
            }
            var repo = RepositoryFactory.Create();
            try
            {
                return repo.AssignedCourses.GetByClassSectionId(sectionId);
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed, e.g., log them or rethrow
                MessageBox.Show($"An error occurred while retrieving assigned courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CourseModel_Assigned>();
            }
            finally
            {
                repo.Dispose();
            }
        }

        public static void UpdateAssignedTeacher(string ac_id, string teacher_id)
        {
            var repo = RepositoryFactory.Create();
            try
            {
                var teacher = repo.Teacher.GetById(teacher_id);
                if (teacher == null) throw new Exception("Selected Teacher cannot be found");

                var ac = repo.AssignedCourses.GetById(ac_id);
                if (ac == null) throw new Exception("Selected course cannot be found");

                ac.Teacher = null!;
                ac.TeacherId = teacher.TeacherID;

                repo.AssignedCourses.Update(ac);
                repo.SaveChanges();

                MessageBox.Show("Assigned course succesfully updated!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while trying to update the Assigned Course " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { repo.Dispose(); }
        }

        public static ICollection<CourseModel_Assigned> GetTeacherAssignedCoursesForCurrentTerm(string teacherId)
        {
            var repo = RepositoryFactory.Create();
            try
            {
                var currentTerm = repo.Semesters.GetCurrentTerm();
                if (currentTerm == null) throw new Exception("No current term found.");

                return repo.AssignedCourses.GetByTeacherIdForTerm(teacherId, currentTerm.TermId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving assigned courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CourseModel_Assigned>();
            }
            finally
            {
                repo.Dispose();
            }
        }
    }
}
