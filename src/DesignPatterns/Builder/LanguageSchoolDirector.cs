using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class LanguageSchoolDirector
    {
        CourseBuilder builder;

        public LanguageSchoolDirector(CourseBuilder builder)
        {
            this.builder = builder;
        }

        public void BeginCourse()
        {
            builder.NewCourse();
            builder.SetLanguage();
            builder.SetCourseBooks();
            builder.SetPrice();
        }

        public Course GetCourse()
        {
            return builder.GetCourse();
        }
    }
}
