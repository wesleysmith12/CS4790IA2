using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4790IA2.Models
{
    public class Repository
    {
        public static CourseSection getCourseAndSection(int? id)
        {
            CourseSection courseSection = BasicSchool.getCourseAndSection(id);

            return courseSection;
        }

        public static Course getCourse(int? id)
        {
            Course course = BasicSchool.getCourse(id);
            return course;
        }

    }

    public class CourseSection
    {
        public CourseSection()
        {

        }
    }

    public class CourseAndSections
    {

        public Course course { get; set; }
        public List<Section> sections { get; set;  }

    }

}