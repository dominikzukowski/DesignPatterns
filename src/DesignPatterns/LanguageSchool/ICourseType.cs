using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LanguageSchool
{
    public interface ICourseType
    {
        void BeginCourse();
        string GetCourseAddress();
    }

    public enum CourseType
    { Online, FullTime}
}
