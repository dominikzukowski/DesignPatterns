using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class School
    {
        Course course;
        Student student;
        Teacher teacher;

        public School()
        {
            course = new Course();
            student = new Student();
            teacher = new Teacher();
        }

        public void BeginCourse()
        {
            course.BeginCourse();
            student.Register();
            teacher.BeginCourse();
        }

        public string CourseStatus
        {
            get
            {
                return course.CourseStatus;
            }
        }
    }
}
