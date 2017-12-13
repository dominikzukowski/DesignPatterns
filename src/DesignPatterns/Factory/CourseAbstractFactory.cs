using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.LanguageSchool;

namespace DesignPatterns.Factory
{
    public class CourseAbstractFactory
    {
        IAbstractFactory factory;

        public IStudent student { get; set; }
        public ICourseType courseType { get; set; }

        public CourseAbstractFactory(IAbstractFactory factory)
        {
            this.factory = factory;
        }

        public void BeginCourse()
        {
            student = factory.GetStudent();
            courseType = factory.GetCourseType();
        }
    }
}
