using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class EnglishCourseBuilder : CourseBuilder
    {
        public override void SetLanguage()
        {
            course.Language = "English";
        }

        public override void SetCourseBooks()
        {
            course.CourseBooks.Add("English Course Book");
            course.CourseBooks.Add("English Excercise Book");
        }

        public override void SetPrice()
        {
            course.Price = 1200;
        }
    }
}
