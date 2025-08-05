using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Models;

namespace Finals.Services
{
    public static class CourseRepo
    {
        public static void CreateCourse(string courseId, string courseName, int defaultUnits, string description, string creatorId)
        {
            var repo = RepositoryFactory.Create();
            try
            {
                var course = new CourseModel
                {
                    CourseId = courseId,
                    CourseName = courseName,
                    DefaultUnits = defaultUnits,
                    DateCreated = DateTime.Now,
                    Description = description,
                    CreatorId = creatorId
                };
                //repo.CourseTemplates.Add(course);
                if(!Validate(course))
                {
                    MessageBox.Show("Invalid course data. Please check the input values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                repo.Courses.Add(course);
                repo.SaveChanges();
                MessageBox.Show("Course created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while creating the course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { repo.Dispose(); }
        }

        public static void CreateCourse(CourseModel course)
        {
            if (!Validate(course))
            {
                MessageBox.Show("Invalid course data. Please check the input values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var repo = RepositoryFactory.Create();
                try
                {
                    repo.Courses.Add(course);
                    repo.SaveChanges();
                    MessageBox.Show("Course created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while creating the course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally { repo.Dispose(); }
            }
        }

        public static ICollection<CourseModel> GetAllCourses()
        {
            var repo = RepositoryFactory.Create();
            try
            {
                return repo.Courses.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CourseModel>();
            }
            finally { repo.Dispose(); }
        }

        public static void UpdateCourse(CourseModel course)
        {
            var repo = RepositoryFactory.Create();
            try
            {
                if (!Validate(course))
                {
                    MessageBox.Show("Invalid course data. Please check the input values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var existingCourse = repo.Courses.GetById(course.CourseId);
                if (existingCourse == null)
                {
                    MessageBox.Show("Course not found. Please check the course ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                existingCourse.CourseName = course.CourseName;
                existingCourse.DefaultUnits = course.DefaultUnits;
                existingCourse.Description = course.Description;

                if (!Validate(existingCourse))
                {
                    MessageBox.Show("Invalid course data. Please check the input values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                repo.Courses.Update(existingCourse);
                repo.SaveChanges();
                MessageBox.Show("Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while updating the course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                repo.Dispose();
            }
        }

        private static bool Validate(CourseModel course)
        {
            if (string.IsNullOrWhiteSpace(course.CourseId) ||
                string.IsNullOrWhiteSpace(course.CourseName) ||
                course.DefaultUnits <= 0 ||
                string.IsNullOrWhiteSpace(course.Description) ||
                course.DateCreated == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(course.CreatorId)
                )
            {
                return false;
            }
            return true;
        }
    }
}
