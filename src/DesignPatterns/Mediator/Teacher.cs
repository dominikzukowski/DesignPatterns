using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Teacher
    {
        Mediator mediator;

        public Teacher(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void BeginTest()
        {
            mediator.Send("Begin test");
        }

        public string GetCourseLevel()
        {
            return mediator.Send<string>("Course Level");
        }
    }
}
