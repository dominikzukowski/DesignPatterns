using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Course
    {
        public string CourseStatus { get; set; }

        public void BeginCourse()
        {
            CourseStatus = "Course is started.";
        }
    }
}
