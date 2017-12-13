using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.LanguageSchool;


namespace DesignPatterns.Factory
{
    public class OnlineCourseAbstractFactory : IAbstractFactory
    {
        public IStudent student;
        public ICourseType courseType;


        public LanguageSchool.IStudent GetStudent()
        {
            return new Student();
        }

        public LanguageSchool.ICourseType GetCourseType()
        {
            return new OnlineCourse();
        }
    }
}
