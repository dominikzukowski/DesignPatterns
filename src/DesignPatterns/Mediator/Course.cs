using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Course
    {
        Mediator mediator = new Mediator();

        public string test;

        public Course(Mediator mediator)
        {
            this.mediator = mediator;
            mediator.Register("Begin test", StartTest);
            mediator.Register<string>("Course Level", GetCourseLevel);
        }

        private void StartTest()
        {
            test = "The test is in progress.";
        }

        private string GetCourseLevel()
        {
            return "B2";
        }
    }
}
