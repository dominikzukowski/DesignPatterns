using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class GroupCourseDecorator : CourseDecorator
    {
        ICourse course;
        public GroupCourseDecorator(ICourse course) 
            : base(course)
        {
            this.course = course;
        }

        public override string GetDescription()
        {
            return "Group " + course.GetDescription();
        }
    }
}
