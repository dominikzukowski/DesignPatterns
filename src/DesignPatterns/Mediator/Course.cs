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
            mediator.Register("test", StartTest);
        }

        private void StartTest()
        {
            test = "Test trwa";
        }

    }
}
