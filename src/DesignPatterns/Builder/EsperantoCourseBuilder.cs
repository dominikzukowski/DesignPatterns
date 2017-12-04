using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class EsperantoCourseBuilder : CourseBuilder
    {
        public override void SetLanguage()
        {
            course.Language = "Esperanto";
        }

        public override void SetCourseBooks()
        {
            course.CourseBooks.Add("Esperanto Course Book");
        }

        public override void SetPrice()
        {
            course.Price = 900;
        }
    }
}