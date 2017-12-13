using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LanguageSchool
{
    public class FullTimeCourse : ICourseType
    {
        string address;

        public void BeginCourse()
        {
            throw new NotImplementedException();
        }


        public string GetCourseAddress()
        {
            return "Warsaw, Al. Jerozolimskie 1";
        }
    }
}
