using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class OnlineCourseDecorator : CourseDecorator
    {
        ICourse course;
        public OnlineCourseDecorator(ICourse course) 
            : base(course)
        {
            this.course = course;
        }

        public override void BeginCourse()
        {
            course.BeginCourse();
            Description = "Online " + course.Description;
        }

        public override string GetDescription()
        {
            return "Online " + course.GetDescription();
        }
    }
}
