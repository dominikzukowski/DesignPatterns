using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LanguageSchool
{
    public class OnlineCourse : ICourseType
    {
        string url;

        public void BeginCourse()
        {
            throw new NotImplementedException();
        }


        public string GetCourseAddress()
        {
            return "http://url.com";
        }
    }
}
