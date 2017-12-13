using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class CourseDecorator : ICourse
    {
        ICourse course;

        public CourseDecorator(ICourse course)
        {
            this.course = course;
        }

        public abstract string GetDescription();
    }
}
