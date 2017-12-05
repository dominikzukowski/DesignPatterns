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
    }

    public enum CourseType
    { Online, FullTime}
}
