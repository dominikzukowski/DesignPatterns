using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LanguageSchool
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public bool IsDoingExcercise;

        public void Update()
        {
            IsDoingExcercise = true;
        }

    }
}
