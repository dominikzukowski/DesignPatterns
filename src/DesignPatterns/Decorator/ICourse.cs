using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class ICourse
    {
        public string Description;
        public abstract void BeginCourse();
        public abstract string GetDescription();
    }
}
