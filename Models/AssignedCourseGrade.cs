using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class AssignedCourseGrade
    {
        public string GradeId { get; set; } = null!;
        public string AssignedCourseId { get; set; } = null!;
        public CourseModel_Assigned AssignedCourse { get; set; } = null!;

        public string StudentId { get; set; } = null!;
        public StudentModel Student { get; set; } = null!;

        public string RegistrationId { get; set; } = null!;
        public AssignedCourseRegistration Registration { get; set; } = null!;

        public CourseGrade Grade { get; set; } = CourseGrade.NotSet;

        public DateTime DateAssigned { get; set; } = DateTime.MinValue;
    }
    public enum CourseGrade
    {
        NotSet, INC, Unknown, OnePointZero, OnePointTwentyFive, OnePointFifty, OnePointSeventyFive,
        TwoPointZero, TwoPointTwentyFive, TwoPointFifty, TwoPointSeventyFive,
        ThreePointZero, FourPointZero, FivePointZero
    }

    public static class CourseGradeTranslator
    {
        public static string TranslateFromCourseGrade(CourseGrade grade)
        {
            return grade switch
            {
                CourseGrade.NotSet => "Not Set",
                CourseGrade.INC => "INC",
                CourseGrade.OnePointZero => "1.0",
                CourseGrade.OnePointTwentyFive => "1.25",
                CourseGrade.OnePointFifty => "1.5",
                CourseGrade.OnePointSeventyFive => "1.75",
                CourseGrade.TwoPointZero => "2.0",
                CourseGrade.TwoPointTwentyFive => "2.25",
                CourseGrade.TwoPointFifty => "2.5",
                CourseGrade.TwoPointSeventyFive => "2.75",
                CourseGrade.ThreePointZero => "3.0",
                CourseGrade.FourPointZero => "4.0",
                CourseGrade.FivePointZero => "5.0",
                CourseGrade.Unknown => "Unknown",
                _ => "Unknown"
            };
        }

        public static CourseGrade TranslateToCourseGrade(string courseGrade)
        {
            return courseGrade.ToLower() switch
            {
                "not set" => CourseGrade.NotSet,
                "inc" => CourseGrade.INC,
                "1.0" => CourseGrade.OnePointZero,
                "1.25" => CourseGrade.OnePointTwentyFive,
                "1.5" => CourseGrade.OnePointFifty,
                "1.75" => CourseGrade.OnePointSeventyFive,
                "2.0" => CourseGrade.TwoPointZero,
                "2.25" => CourseGrade.TwoPointTwentyFive,
                "2.5" => CourseGrade.TwoPointFifty,
                "2.75" => CourseGrade.TwoPointSeventyFive,
                "3.0" => CourseGrade.ThreePointZero,
                "4.0" => CourseGrade.FourPointZero,
                "5.0" => CourseGrade.FivePointZero,
                _ => CourseGrade.NotSet
            };
        }
    }
}
