using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.LanguageSchool;


namespace DesignPatterns.Builder
{
    public abstract class CourseBuilder
    {
        protected Course course;

        public void NewCourse()
        {
            course = new Course();
        }

        public Course GetCourse()
        {
            return course;
        }

        public abstract void SetLanguage();
        public abstract void SetCourseBooks();
        public abstract void SetPrice();

    }
}
