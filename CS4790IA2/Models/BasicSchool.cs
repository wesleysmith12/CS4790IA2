using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS4790IA2.Models
{
    public class BasicSchool
    {
        public static Course getCourse(int? id)
        {
            BasicSchoolDbContext db = new Models.BasicSchoolDbContext();
            Course course = db.courses.Find(id);

            return course;
        }



        public static List<Course> getAllCourses()
        {
            BasicSchoolDbContext db = new Models.BasicSchoolDbContext();
            return db.courses.ToList();
        }

        public static CourseSection getCourseAndSection(int? id)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();
            CourseSection courseSection = new CourseSection();
            courseSection.course = db.sections.Find(id);

            var sections = db.sections.Where(s => s.courseNumber == courseSection.course.courseNumber);
            courseSection.sections = sections.ToList();

            return CourseSection;
        }

    }

 

    // define table name
    [Table("Course")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string courseNumber { get; set; }
        public string courseName { get; set; }
        public int creditHours { get; set; }
        public int? maxEnrollment { get; set; }

    }

    // define table name
    [Table("Section")]
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public int sectionID { get; set; }
        public int sectionNumber { get; set; }
        public string courseNumber { get; set; }
        public string sectionDays { get; set; }
        public DateTime sectionTime { get; set; }
    }

    public class BasicSchoolDbContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Section> sections { get; set; }
    }

}