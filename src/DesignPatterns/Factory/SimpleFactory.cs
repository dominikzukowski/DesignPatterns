using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.LanguageSchool;

namespace DesignPatterns.Factory
{
    public static class SimpleFactory
    {
        public static ICourseType CreateClassrom(CourseType type)
        {
            switch (type)
            {
                case CourseType.FullTime:
                    return new FullTimeCourse();
                case CourseType.Online:
                    return new OnlineCourse();
            }
            return null;
        }
    }
}
